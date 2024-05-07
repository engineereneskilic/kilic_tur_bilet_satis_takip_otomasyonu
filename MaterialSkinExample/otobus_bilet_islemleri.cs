using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkinExample
{
    public partial class otobus_bilet_islemleri : MaterialForm
    {
        public otobus_bilet_islemleri()
        {
            InitializeComponent();
            // TEMA İLE İLGİLİ ÖZELLİKLER
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.Blue100, TextShade.WHITE);
        }
        ortak_degiskenler_classlar ortak_class = new ortak_degiskenler_classlar();
        public int secilen_koltukno; // tıklanan koltuk numarasına bu değişkene atıycaz

        private void otobus_bilet_islemleri_Load(object sender, EventArgs e)
        {
            this.Text = ortak_degiskenler_classlar.secilen_oto_seferno + " Sefer Sayılı " + ortak_degiskenler_classlar.secilen_oto_plaka + " Yolcu Listesi";

            baslik_label.Text = this.Text;


            sayfa_icerigi(); // sayfa yüklenirken yapılcakların tutulduğu metod
        }
        private void sayfa_icerigi()// sayfa içeriğini tek bir metodta tutuyorumki sayfa içeriğini yenilemek istediğim zaman metodu çalıştırmam yetiyor
        {
            secilenplaka_yolcu_ListView.Items.Clear(); // listeyi temizle çünkü sayfa içeriği daha önceden çalıştıysa içinde mutlaka item olcaktır onlar temizlensin
            using (var db = new Model.Context.yolcularDbContext())
            {
                var yolcu_listele = from k in db.yolcular
                                   where k.Yolcu_plaka == ortak_degiskenler_classlar.secilen_oto_plaka && k.Yolcu_seferno == ortak_degiskenler_classlar.secilen_oto_seferno
                                   orderby k.Yolcu_koltukno
                                   select k;
                                //secilen plaka ve sefernoya göre eşit olanları koltuk nosu küçükten büyük olcak şekilde getir
                foreach (var eleman in yolcu_listele)
                {
                    // delegate burda gerek yok çünkü kullanıcı bişey girmicek bu listeleme olduğu için

                    ListViewItem yolcu_item = new ListViewItem(eleman.Yolcu_id.ToString());
                    yolcu_item.SubItems.Add(eleman.Yolcu_durum.ToString());
                    yolcu_item.SubItems.Add(eleman.Yolcu_koltukno.ToString());
                    yolcu_item.SubItems.Add(eleman.Yolcu_isimsoyisim);
                    yolcu_item.SubItems.Add(eleman.Yolcu_cinsiyet);
                    yolcu_item.SubItems.Add(eleman.Yolcu_nereden);
                    yolcu_item.SubItems.Add(eleman.Yolcu_nereye);
                    yolcu_item.SubItems.Add(eleman.Yolcu_odemesekli);
                    ortak_class.Ucret = eleman.Yolcu_ucret.ToString();
                    yolcu_item.SubItems.Add(ortak_class.Ucret);

                    secilenplaka_yolcu_ListView.Items.Add(yolcu_item);

                }
            }
            // Koltuk Bilgileri Groupbox
            int rezervasyon = 0;
            int toplamyolcu = secilenplaka_yolcu_ListView.Items.Count;
            int boslukkoltuk = 35 - secilenplaka_yolcu_ListView.Items.Count;// 35 sayısı otobüs yolcu kapasitesi

            //Ödeme Bilgileri Groupbox
            double nakit = 0;
            double kredikarti = 0;
            // ikisini toplamı da toplamdır değişken tanımlamaya gerek yok
            foreach (ListViewItem item in secilenplaka_yolcu_ListView.Items) // lisvview misin elemanlarını listeleyelim
            {
                if (item.SubItems[1].Text == "Rezervasyon") rezervasyon++; // rezervasyon rowlarını sayalım
                else

                if (item.SubItems[7].Text == "Nakit")
                {
                    string[] tlsiz = item.SubItems[8].Text.Split(' '); // tlden arındıralım
                    nakit += Convert.ToDouble(tlsiz[0]);
                }
                else
                {
                   
                    string[] tlsiz = item.SubItems[8].Text.Split(' ');
                    MessageBox.Show(tlsiz[0].ToString());
                    kredikarti += Convert.ToDouble(tlsiz[0]);
                }

                if (item.SubItems[4].Text == "Bay") // cinsiyet sütünu (colu) bay ise
                {
                    // bütün bay olan koltuk numaralarına ağit resimleri ve labelleri çağıralım

                    //Not: item.SubItems[2].Text:koltukno sütünu
                    // namesine göre form elemanını çağır çağırırken koltuk numarası id olsun.., true da evet çağır demek as ise ata Picturebox olarak ata
                    PictureBox bay_yolcular_picturebox = this.Controls.Find("koltuk_" + item.SubItems[2].Text + "pictureBox", true).FirstOrDefault() as PictureBox; 
                    Label bay_yolcular_label = this.Controls.Find("koltuk_" + item.SubItems[2].Text + "label", true).FirstOrDefault() as Label; // yine picturebox ile name benzer yaptığım için aynı yöntemlede labeli bul
                    bay_yolcular_label.BackColor = Color.FromArgb(201, 229, 251);// label arkaplanını mavi tonu yap
                    bay_yolcular_picturebox.Image = resimlerim.mavi;// resmi mavi koltuk olarak değiştir..
                }
                else
                {// bütün bayan olan koltuk numaralarına ağit resimleri ve labelleri çağıralım

                    PictureBox bayan_yolcular_picturebox = this.Controls.Find("koltuk_" + item.SubItems[2].Text + "pictureBox", true).FirstOrDefault() as PictureBox;
                    Label bayan_yolcular_label = this.Controls.Find("koltuk_" + item.SubItems[2].Text + "label", true).FirstOrDefault() as Label;
                    bayan_yolcular_label.BackColor = Color.FromArgb(235, 216, 221);
                    bayan_yolcular_picturebox.Image = resimlerim.pembe;
                }

            }
            // Koltuk Bilgilerini atayalım
            rezervasyon_label.Text = rezervasyon.ToString();
            toplamyolcu_label.Text = toplamyolcu.ToString();
            boskoltuk_label.Text = boslukkoltuk.ToString();

            // Ödeme Bilgilerini atayalım
            ortak_class.Ucret = nakit.ToString(); // TL Formatı için ortak clasımızda kapsülletiroruz
            nakit_label.Text = ortak_class.Ucret;
            ortak_class.Ucret = kredikarti.ToString();
            kredikarti_label.Text = ortak_class.Ucret;
            ortak_class.Ucret = Convert.ToString(nakit + kredikarti);
            toplam_label.Text = ortak_class.Ucret;
        }

        /*
        kullanıcı otobüsün koltuklarına tıklarken labelinada tıklamış olabilir iki durumdada aşağıdaki metot çalışacak ve tıklanan türe göre eğer tıklanan picture box ise ona göre 
         secilen_koltukno çıkacak eğer label ise ona göre secilen koltukno çıkacak
         Not:Koltukların pictureboxlarının ve labellerinin hepsinin Click Eventi Bu metoda bağlı..
         */
        private void tum_koltuklar_Click(object sender, EventArgs e)
        {

            if (sender.GetType().Name.ToString() == "PictureBox") // kullanıcı picturebox tıkladıysa 
            {

                PictureBox tiklanan_koltuk = (PictureBox)sender; // o zaman bu object bir pictureboxtur
                /*
                tıklanan koltuk namesini ayıklarken substring kullandım.Kullanırken başlangıc değeri koltukno başlangıcı, bitiş değeri de koltukno bitişi olmalıydı ona göre kesmem lazım dı 
                fakat başlangıç noktaları hepsinin aynıydı ama bitiş noktaları basamak değerlerine görede değişiyordu örneğin  7 den başla 1 tane al dediğim zaman koltuk no 15 ise sadece 1 alıyordu 
                1 ve 5 i aynı anda almalıydı eğer sayı tek basak olsaydı yani sayi atıyorum 5 olsaydaı 7 den 1 tane alsam olurdu bunuda name uzunluğuna göre kesim yapıyorum yani özetle 1 basamaksa 1 tane kes 2 basamaksa 
                2 tane kes 
                */
                if (tiklanan_koltuk.Name.Length == 18) secilen_koltukno = Convert.ToInt32(tiklanan_koltuk.Name.Substring(7, 1)); else secilen_koltukno = Convert.ToInt32(tiklanan_koltuk.Name.Substring(7, 2));
            }
            else // değilse label ldır
            {
                // labelda kesmemi gerektircek bişey yoktu zaten secilen_koltukno labelin textinde yazıyordu onu direk almam yeterliydi
                Label tiklanan_label = (Label)sender;
                secilen_koltukno = Convert.ToInt32(tiklanan_label.Text);

            }
            // aldığım koltuk nonu bilet satış formuna göndermeliyimki ona göre bilet keseyim.

            bilet_satis bilet_satis_formu = new bilet_satis();
            bilet_satis_formu.secilen_koltukno = secilen_koltukno;
            bilet_satis_formu.Show();
        }


        private void listeyi_yenileButton_Click(object sender, EventArgs e)
        {
            sayfa_icerigi(); // sayfa içeriğini yenile
        }

        private void fatura_olusturButton_Click(object sender, EventArgs e)
        {
            fatura_olustur faturaolustur_formu = new fatura_olustur();//fatura kesme için açılan formumuzu çağır
            faturaolustur_formu.ShowDialog();//göster
        }


        //listview tıklandığında tetiklencek metot
        private void secilenplaka_yolcu_ListView_Click_MouseClick(object sender, MouseEventArgs e) // menu listwiev elemanlarına tıklandığı zaman tetiklencek metot
        {

            if (e.Button == MouseButtons.Left) // sol tıklanırsa
            {
                if (secilenplaka_yolcu_ListView.FocusedItem.Bounds.Contains(e.Location) == true) // focuslanan item ile moouse lokasyonu çakışıyormu
                {
                    secilen_koltukno = Convert.ToInt32(secilenplaka_yolcu_ListView.FocusedItem.SubItems[2].Text); /*seçilen koltuk numarası tıklanan yani focuslanan itemin 2 numaralı sütünu yani koltuk numarası yazan.. 
                                                                                                                  sütunu koltukno değişkenine ata*/
                    bilet_satis bilet_satis_formu = new bilet_satis();
                    bilet_satis_formu.secilen_koltukno = secilen_koltukno;
                    bilet_satis_formu.Show();
                }

            }
                // sağ tıklandığında ise ContextMenuStrip elemanımız gözüksün
            if (e.Button == MouseButtons.Right) // sağ tıklandığında
            {
                if (secilenplaka_yolcu_ListView.FocusedItem.Bounds.Contains(e.Location) == true) // focuslanan item ile moouse lokasyonu çakışıyormu
                {
                    cikar_ContextMenuStrip.Show(Cursor.Position);// çakışıyorsa tam bu çakışan noktada contextmenustripti yani normak ters tıkta açıldığı gibi menü gelsin

                }
            }
        }

        /*
        Yolcu silme işlemi
        ContextMenustritp bildiğimiz sağ tıklanınca kes kopyala yapıştır gibi çıkan menüler.Bu form elemanını liste üzerindeki itemlerden birine ters tıkladığınızda çıkar yazısı çıkacaktır ona aynı kesermiş gibi 
        tıklayarak onu listeden ve veritabanından silebiliriz.
        */
        private void cikarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new Model.Context.yolcularDbContext())
            {
                db.yolcular.Remove(db.yolcular.Find(Convert.ToInt32(secilenplaka_yolcu_ListView.FocusedItem.SubItems[0].Text))); // 0. eleman yani sefer_no aynı zamanda sefer tablosunun idsine göre o itemi sil
                db.SaveChanges();//değişiklikleri kaydet

                // şimdide koltuktan kaldıralım focuslanan satırın koltuk nuamrasına göre picturebox ve labeli getir ve değişkenlere aktar as (Picturebox,Label)
                PictureBox bos_yolcu_picturebox = this.Controls.Find("koltuk_" + secilenplaka_yolcu_ListView.FocusedItem.SubItems[2].Text + "pictureBox", true).FirstOrDefault() as PictureBox;
                Label bos_yolcu_label = this.Controls.Find("koltuk_" + secilenplaka_yolcu_ListView.FocusedItem.SubItems[2].Text + "label", true).FirstOrDefault() as Label;
                bos_yolcu_label.BackColor = Color.White;
                bos_yolcu_picturebox.Image = resimlerim.bos;

                // herşeyi yenileyeim
                sayfa_icerigi();
            }
        }


        // ŞOFÖR KISMI
        private void sofor_koltugu_Click(object sender, EventArgs e)
        {
            sofor_bilgileri soforbilgileri_formu = new sofor_bilgileri();
            soforbilgileri_formu.ShowDialog();

        }
    }
}
