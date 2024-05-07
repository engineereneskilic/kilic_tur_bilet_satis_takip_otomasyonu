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
    public partial class bilet_satis : MaterialForm
    {
        public bilet_satis()
        {
            InitializeComponent();
            // TEMA İLE İLGİLİ ÖZELLİKLER
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.Blue100, TextShade.BLACK);
        }
        ortak_degiskenler_classlar ortak_class = new ortak_degiskenler_classlar();
        public int secilen_koltukno; // tıklanan koltuk numarasının tutulduğu değişken
        private string kaydet_guncelle="kaydet"; // sayfa yüklendiğinde değer boş olarak geldiğini varsayalım eğer bu değişmez ise kayıt bulunduğunda hep kaydet kalsın
        private int yolcu_id;
        private void bilet_satis_Load(object sender, EventArgs e)
        {
            this.Text = secilen_koltukno + ". Koltuk Bilet Satış";

            using (var db=new Model.Context.yolcularDbContext())// veritabanı bağlantısı
            {

                var secilen_koltukno_bilgileri = from k in db.yolcular
                                                 where k.Yolcu_koltukno == secilen_koltukno && k.Yolcu_plaka==ortak_degiskenler_classlar.secilen_oto_plaka && k.Yolcu_seferno==ortak_degiskenler_classlar.secilen_oto_seferno
                                                 select k; //tıklanan koltuk no ve daha önceden atadığımız neredeyse bütün formlarda kullancağımız secilen plaka ve seferno bu üçü veritabanında aynı olanları getir
                if (secilen_koltukno_bilgileri != null) // secilen koltukno veritanında varsa göster yoksa boş zaten
                {
                   
                   // bu kısımda secilen koltuk numarasına plakasına sefer numarasına göre yolcu bilgileri geliyor form elemanlarımıza
                    foreach (var eleman in secilen_koltukno_bilgileri)
                    {
                        kaydet_guncelle = "guncelle";// secilen koltuk numarasına ait veritabanında kayıt var o zaman güncelleme işlemi yapcaz ama burda değil aşağıda görceksiniz
                        yolcu_id = eleman.Yolcu_id;

                        // gerekli şart sağlandığında tetiklencek olan delegate eventimize çağrıcağı metodu atıyoruz bu 3'ü içinde aynı
                        eleman.TelFormat += new Model.Entitiy.TelformatEventHandler(ortak_class.yolcu_TelFormat_Uyarisi); 
                        eleman.CinsiyetSecmediniz += new Model.Entitiy.CinsiyetEventHandler(ortak_class.yolcu_CinsiyetSecmediniz);
                        eleman.ayniGuzergahUyarisi += new Model.Entitiy.AyniguzergahEventHandler(ortak_class.yolcu_ayniguzergahUyarisi);

                        isimsoyisim_textbox.Text = eleman.Yolcu_isimsoyisim;
                        telno_textbox.Text = eleman.Yolcu_telno;
                        nereden_comboBox.Text = eleman.Yolcu_nereden;
                        nereye_comboBox.Text = eleman.Yolcu_nereye;
                        satistipi_comboBox.Text = eleman.Yolcu_durum;
                        ucret_textbox.Text = eleman.Yolcu_ucret.ToString();
                        odemesekli_comboBox.Text = eleman.Yolcu_odemesekli;

                        // yolcu cinsiyetine göre bay ise bay radio buttonu işaretle değilse zaten bayandır bayan radio buttonunu işaretle
                        if (eleman.Yolcu_cinsiyet == "Bay") bay_RadioButton.Checked = true; else bayan_RadioButton.Checked = true; 
                        


                    }
                    ucretOdemeSekliVisible(); // oluşturulduğu yerde açıkladım
                }
               
                if (kaydet_guncelle == "kaydet") // şimdi tek formda işlem olmasını istiyorum hep kaydetme hem güncelleme olsun bunuda yukarda kayıt varsa kaydet_guncelle değişkenimize ona göre atama yapıyoruz
                {
                    // buna görede button özellikleri değişsin(yazı/icon)
                    kaydet_guncelle_Button.Text = "KAYDET";
                    kaydet_guncelle_Button.Icon = resimlerim.tick;
                }
                else
                {
                    // buna görede button özellikleri değişsin(yazı/icon)
                    kaydet_guncelle_Button.Text = "GÜNCELLE";
                    kaydet_guncelle_Button.Icon = resimlerim.update_icon;
                    kaydet_guncelle_Button.Location = new Point(181, 369); // Guncelle yazısı gelince button kayıyor sola doğru az gelsin
                }
            }
        }

        private void satistipi_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucretOdemeSekliVisible();// oluşturulduğu yerde açıkladım

        }

        private void ucretOdemeSekliVisible() // Burda eğer satiş tipi rezervason seçilirse ne olcağını eğer bilet satış olduğunda yani program üstünden direk ödeme gerçekleştiğinde olucak işlemleri ayarlıyacağımız metod
        {
            //rezervasyon gelirse ödeme şekli label ve comboboxu gözükmesin ücret label combobox gözüksün not: rezervasyonda ücret almıyoruz doğal olarak da ödeme şeklide seçmememiz lazım
            if (satistipi_comboBox.Text=="Rezervasyon") 
            {
                ucret_label.Visible = false;
                ucret_textbox.Visible = false;
                tl_label.Visible = false;
                    
                odemesekli_label.Visible = false;
                odemesekli_comboBox.Visible = false;
            }
            else if(satistipi_comboBox.Text!="") // boş gelirse varsayılan visible false olarak devam etsin
            {
                ucret_label.Visible = true;
                ucret_textbox.Visible = true;
                tl_label.Visible = true;
                odemesekli_label.Visible = true;
                odemesekli_comboBox.Visible = true;
            }

         
        }

        private void kaydet_guncelle_Button_Click(object sender, EventArgs e)
        {
            // bu class bir group boxa agit tüm form elemanlarının boş olup olmadığınnı döngü şeklinde kontrol ediyor eğer biri boşsa true yani boş var diyor. Biri boşsa da zaten kaydedemeyiz veya güncelleyemeyiz
            if (!ortak_class.TumBosKontrolü(bilet_satis_bilgileri_groupBox))
            {
                //şimdi buttonun ne yapcağına karar verelim
                if (kaydet_guncelle == "kaydet")
                {

                    Kaydet();
                }
                else // else ise "guncelleme" olcaktır başka bişey olamaz
                {
                    Guncelle();
                }
            }
            
        }
        // yolcumuzu kaydettiğimiz metod
        private void Kaydet()
        {
            using (var db = new Model.Context.yolcularDbContext())
            {
                // burdada daha önceki formlarda gördüğünüz gibi normal bir şekilde class ımıza çağırım onun değişkenlerine atama yapıyoruz
                Model.Entitiy.yolcu yolcu = new Model.Entitiy.yolcu();
                yolcu.TelFormat += new Model.Entitiy.TelformatEventHandler(ortak_class.yolcu_TelFormat_Uyarisi); // 
                yolcu.CinsiyetSecmediniz += new Model.Entitiy.CinsiyetEventHandler(ortak_class.yolcu_CinsiyetSecmediniz);
                yolcu.ayniGuzergahUyarisi += new Model.Entitiy.AyniguzergahEventHandler(ortak_class.yolcu_ayniguzergahUyarisi);
                yolcu.Yolcu_durum = satistipi_comboBox.Text;
                yolcu.Yolcu_plaka = ortak_degiskenler_classlar.secilen_oto_plaka;
                yolcu.Yolcu_seferno = ortak_degiskenler_classlar.secilen_oto_seferno;
                yolcu.Yolcu_koltukno = Convert.ToInt32(secilen_koltukno.ToString());
                yolcu.Yolcu_isimsoyisim = isimsoyisim_textbox.Text;
                yolcu.Yolcu_telno = telno_textbox.Text;
                yolcu.Yolcu_nereden = nereden_comboBox.Text;
                yolcu.Yolcu_nereye = nereye_comboBox.Text;
                yolcu.Yolcu_cinsiyet = cinsiyet;
                if (odemesekli_comboBox.SelectedIndex != -1)// ödeme şekli combobax yoksa ödeme şekli bellidir "Ödeme Yapılmadı"
                {
                    yolcu.Yolcu_odemesekli = odemesekli_comboBox.Items[odemesekli_comboBox.SelectedIndex].ToString();
                    yolcu.Yolcu_ucret = Convert.ToDouble(ucret_textbox.Text);
                }
                else
                {
                    yolcu.Yolcu_odemesekli = "Ödeme Yapılmadı";
                    yolcu.Yolcu_ucret = 0;
                }

                // yapıcı metod ile yapmak istedim fakat enitiy yani içine gömülü veritabanı sistemi bunu desteklemiyor !
                //Model.Entitiy.yolcu yolcu = new Model.Entitiy.yolcu(satistipi_comboBox.Items[satistipi_comboBox.SelectedIndex].ToString(), isimsoyisim_textbox.Text, telno_textbox.Text, nereden_comboBox.Items[nereden_comboBox.SelectedIndex].ToString(), Convert.ToInt32(secilen_koltukno.ToString()), nereye_comboBox.Items[nereye_comboBox.SelectedIndex].ToString(), cinsiyet, yolcu_odeme_sekli, yolcu_ucret);


                    db.yolcular.Add(yolcu); // yolcu classımızın deişkenlerine atama yaptık artık bu classı veritabanına kaydedelim
                    db.SaveChanges();// değişiklikleri kaydet
                    ortak_class.olumlu_olumsuzMessageBox(true, "Yolcu Başarıyla Eklendi.."); /*bu metod benim bildiğiniz messagebox metodu ilk değişken olumlu bir mesaj mı yoksa olmumsuz bir mesaj mı onu gösteriyor 
                                                                                             diğeri ise gösterilcek mesaj*/
                this.Hide(); // kaydetme işlemi başarılysa formu gizle ki bi daha kayıt yapamasın kayıt üstüne
              
            }
        }
        //yolcumuzu güncellemediğimiz metod
        private void Guncelle()
        {
            using (var db = new Model.Context.yolcularDbContext())
            {
                // güncellencek olan idmizi alıyoruz veritabanında buluyoruz ve yeni değişkenleri atıyoruz
                var guncellencek_yolcu = db.yolcular.Find(yolcu_id);

                // delegate eventimize tetiklencek olan metodu atadığımız yerler
                guncellencek_yolcu.TelFormat += new Model.Entitiy.TelformatEventHandler(ortak_class.yolcu_TelFormat_Uyarisi); // 
                guncellencek_yolcu.CinsiyetSecmediniz += new Model.Entitiy.CinsiyetEventHandler(ortak_class.yolcu_CinsiyetSecmediniz);
                guncellencek_yolcu.ayniGuzergahUyarisi += new Model.Entitiy.AyniguzergahEventHandler(ortak_class.yolcu_ayniguzergahUyarisi);

                guncellencek_yolcu.Yolcu_durum = satistipi_comboBox.Text;
                guncellencek_yolcu.Yolcu_plaka = ortak_degiskenler_classlar.secilen_oto_plaka;
                guncellencek_yolcu.Yolcu_seferno = ortak_degiskenler_classlar.secilen_oto_seferno;
                guncellencek_yolcu.Yolcu_koltukno = Convert.ToInt32(secilen_koltukno.ToString());
                guncellencek_yolcu.Yolcu_isimsoyisim = isimsoyisim_textbox.Text;
                guncellencek_yolcu.Yolcu_telno = telno_textbox.Text;
                guncellencek_yolcu.Yolcu_nereden = nereden_comboBox.Text;
                guncellencek_yolcu.Yolcu_nereye = nereye_comboBox.Text;
                guncellencek_yolcu.Yolcu_cinsiyet = cinsiyet;

                if ( satistipi_comboBox.Text== "Bilet Satış") // ise normal değerler atansın
                {
                    guncellencek_yolcu.Yolcu_odemesekli = odemesekli_comboBox.Text;
                    guncellencek_yolcu.Yolcu_ucret = Convert.ToDouble(ucret_textbox.Text);
                }
                else // rezervasyon ise ödeme daha yapılmamıştır ve ücret ödenmemiştir
                {
                    guncellencek_yolcu.Yolcu_odemesekli = "Ödeme Yapılmadı";
                    guncellencek_yolcu.Yolcu_ucret = 0;
                }
                
               
                    db.SaveChanges();
                    ortak_class.olumlu_olumsuzMessageBox(true, "Yolcu Başarıyla Güncellendi..");
                
               

            }
        }

        private string cinsiyet=""; // cinsiyet ise işaretlenen radio buttonuna göre değişiyor değer alıyor

        private void bay_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Bay";
        }

        private void bayan_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Bayan";
        }

       

    }
}
