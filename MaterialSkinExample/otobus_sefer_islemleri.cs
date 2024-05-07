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
    public partial class otobus_sefer_islemleri : MaterialForm
    {
        public otobus_sefer_islemleri()
        {
            InitializeComponent();
            // TEMA İLE İLGİLİ ÖZELLİKLER
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.Blue100, TextShade.WHITE);
        }

        ortak_degiskenler_classlar ortak_sinif = new ortak_degiskenler_classlar();
        private void otobus_sefer_islemleri_Load(object sender, EventArgs e)
        {
            this.Text = ortak_degiskenler_classlar.secilen_oto_plaka;
            gelen_otobus_plaka_label.Text = ortak_degiskenler_classlar.secilen_oto_plaka;

            secilen_otobüs_sefer_listele();
        }

        public void secilen_otobüs_sefer_listele()
        {
            secilen_otobus_ListView.Items.Clear(); // eski sorguya ait listedeki itemler gitsin
            using (var db = new Model.Context.seferlerDbContext())
            {
                var secilen_otobüs_bilgileri = from k in db.seferler
                                               where k.Sefer_plaka == ortak_degiskenler_classlar.secilen_oto_plaka
                                               orderby k.Sefer_no
                                               select k; // secilen plakaya ait tüm seferler sefernosu küçükten büyüye olacak şeiklde gelsin

                foreach (var eleman in secilen_otobüs_bilgileri)
                 {
                        ListViewItem sefer_item = new ListViewItem(eleman.Sefer_no.ToString()); // bir listwiev item oluşturuyoruz ve başına sefernosunu koyuyoruz

                        // alt itemlerini giriyoruz
                        sefer_item.SubItems.Add(eleman.Sefer_varisperon_no.ToString());
                        sefer_item.SubItems.Add(eleman.Sefer_kalkis_tarihi.ToString().Substring(0, 10));
                        sefer_item.SubItems.Add(eleman.Sefer_kalkis_saat.ToString());
                        sefer_item.SubItems.Add(eleman.Sefer_guzergah.ToString());
                        sefer_item.SubItems.Add(eleman.Sefer_sofor.ToString());
                        secilen_otobus_ListView.Items.Add(sefer_item); // ListviewItem Listview'e bir item olarak ekliyoruz
                }
            }
        }

        // Yeni sefer ekliyeceğimiz formu açan metot
        private void yenisefer_ekleButton_Click(object sender, EventArgs e)
        {
            yenisefer yenisefer_formu = new yenisefer();
            yenisefer_formu.ShowDialog();
        }

        private void listeyi_yenileButton_Click(object sender, EventArgs e)
        {
            secilen_otobüs_sefer_listele(); // listeyi yenile
        }


        //listview tıklandığında tetiklencek metot
        private void secilen_otobus_ListView_Click_MouseClick(object sender, MouseEventArgs e) // menu listwiev elemanlarına tıklandığı zaman tetiklencek metot
        {
            // ders de de işlediğimiz gibi sol tıklandığında

            if (e.Button == MouseButtons.Left) // Ters tıklanırsa
            {
                if (secilen_otobus_ListView.FocusedItem.Bounds.Contains(e.Location) == true) // focuslanan item ile moouse lokasyonu çakışıyormu 
                {
                    ortak_degiskenler_classlar.secilen_oto_seferno = Convert.ToInt32(secilen_otobus_ListView.FocusedItem.SubItems[0].Text); // focuslananitemin  0.elemanı sefernodur

                    ortak_degiskenler_classlar.secilen_oto_sofor_ismi = secilen_otobus_ListView.FocusedItem.SubItems[5].Text;// focuslanan itemin 5.elemanı yani sütunu soför ismini ifade ediyor.

                    otobus_bilet_islemleri bilet_satis_formu = new otobus_bilet_islemleri();
                    bilet_satis_formu.Show();
                }

            }
            // sağ tıklandığında ise ContextMenuStrip elemanımız gözüksün
            if (e.Button == MouseButtons.Right)
            {
                if (secilen_otobus_ListView.FocusedItem.Bounds.Contains(e.Location) == true) // focuslanan item ile moouse lokasyonu çakışıyormu
                {
                    cikar_ContextMenuStrip.Show(Cursor.Position);// çakışıyorsa tam bu çakışan noktada contextmenustripti yani normak ters tıkta açıldığı gibi menü gelsin

                }
            }
        }

        // sefer silme işlemi
        // ContextMenustritp bildiğimiz sağ tıklanınca kes kopyala yapıştır gibi çıkan menüler.Bu form elemanını liste üzerindeki itemlerden birine ters tıkladığınızda çıkar yazısı çıkacaktır ona aynı kesermiş gibi tıklayarak veritabanından silebiliriz.
        private void cikarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new Model.Context.seferlerDbContext())
            {
                db.seferler.Remove(db.seferler.Find(Convert.ToInt32(secilen_otobus_ListView.FocusedItem.SubItems[0].Text))); // 0. eleman yani sefer_no aynı zamanda sefer tablosunun idsine göre sil
                db.SaveChanges();// değişiklikleri kaydet
            }
            // seferler silinince yolcularda silinsin
            using (var db = new Model.Context.yolcularDbContext())
            {
                int seferno = Convert.ToInt32(secilen_otobus_ListView.FocusedItem.SubItems[0].Text);
                var yolcularida_sil = from k in db.yolcular
                                      where k.Yolcu_seferno == seferno && k.Yolcu_plaka == ortak_degiskenler_classlar.secilen_oto_plaka
                                      select k;

                // secilen seferno ve plakaya göre listele
                foreach (var eleman in yolcularida_sil)
                {
                    
                    db.yolcular.Remove(db.yolcular.Find(Convert.ToInt32(eleman.Yolcu_id))); // idye göre sil
                    
                }
                db.SaveChanges();
            }
        }
    }
}
