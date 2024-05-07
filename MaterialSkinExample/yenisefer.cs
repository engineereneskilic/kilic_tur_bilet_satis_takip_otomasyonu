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
    public partial class yenisefer : MaterialForm
    {
        public yenisefer()
        {
            InitializeComponent();
            // TEMA İLE İLGİLİ ÖZELLİKLER
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.Blue100, TextShade.WHITE);
        }
        ortak_degiskenler_classlar ortak_class = new ortak_degiskenler_classlar();

        private void yenisefer_Load(object sender, EventArgs e)
        {
            this.Text =  ortak_degiskenler_classlar.secilen_oto_plaka;
            gelen_otobus_plaka_label.Text = ortak_degiskenler_classlar.secilen_oto_plaka;
            

            Model.Entitiy.sofor sofor = new Model.Entitiy.sofor();
            sofor.defaultVeriler(); // varsayılan veriler veritabanına eklesin

            gelen_otobus_plaka_label.Text = ortak_degiskenler_classlar.secilen_oto_plaka;

            string iki_basamak = "";
            // Combobaxlarımıza değerlerini verelim..

            for (int i = 0; i <= 23; i++)
            {
                // i tek basamklı olduğunda yanına 0 koyarsak daha güzel gözükür Ör:05

                if (Convert.ToString(i).Length == 1) iki_basamak = "0" + i; else iki_basamak = i.ToString();
                saat_comboBox.Items.Add(iki_basamak);
            }
            iki_basamak = "";
            for (int k = 0; k <= 59; k++)
            {
                if (Convert.ToString(k).Length == 1) iki_basamak = "0" + k; else iki_basamak = k.ToString();
                dakika_comboBox.Items.Add(iki_basamak);
            }

            iki_basamak = "";
            for (int t = 1; t <= 10; t++)
            {
                if (Convert.ToString(t).Length == 1) iki_basamak = "0" + t; else iki_basamak = t.ToString();
                peron_comboBox.Items.Add(iki_basamak);
            }

            using (var db = new Model.Context.soforlerDbContext())
            {
                foreach (var eleman in db.soforler)
                {
                    sofor_comboBox.Items.Add(eleman.Sofor_adi); // şoförlerimi combobaxa atadık
                }
            }


        }

        private void kaydet_Button_Click(object sender, EventArgs e)
        {
            // iki groupboxdaki değerlerimizi ayrı ayrı boş konrolünden geçiriyoruz eğer bir eleman bile boşsa metodtan return değeri true olcaktır buda boş var demek
            bool zaman_bilgileri_grubu = ortak_class.TumBosKontrolü(zaman_bilgileri_groupBox); 
            bool sefer_bilgiler_grubu = ortak_class.TumBosKontrolü(sefer_bilgileri_groupBox);

            // boş değer iki groupboxda da yoksa (Not: hangi form elemanın boş olduğunu namesine göre messagabox olarak uyarısını veriyor metot oluşturduğum yerde de belirttim.)
            if (!zaman_bilgileri_grubu && !sefer_bilgiler_grubu ) // iki groupboxda da false ise
            {
                using (var db = new Model.Context.seferlerDbContext())
                {
                    Model.Entitiy.sefer sefer = new Model.Entitiy.sefer();
                    sefer.Sefer_varisperon_no = Convert.ToInt32(peron_comboBox.Items[peron_comboBox.SelectedIndex].ToString()); // comboboxta seçilen itemi sayıya çevirerek ata
                    tarih_dateTimePicker.Format = DateTimePickerFormat.Custom;// formatı değiştirilmesi serbest yap
                    tarih_dateTimePicker.CustomFormat = "yyyy-MM-dd"; // yıl-ay-gün olarak değiştiriyoruz

                    sefer.Sefer_kalkis_tarihi = Convert.ToDateTime(tarih_dateTimePicker.Text); // kalkış tarihindeki texti datetime yaparak ata

                    //saat/dakika/saniye(00) şeklinde saat comboboxundan secilen item,dakika comboboxundan seçilen item,0 saniye
                    TimeSpan zaman = new TimeSpan(Convert.ToInt32(saat_comboBox.Items[saat_comboBox.SelectedIndex].ToString()), Convert.ToInt32(dakika_comboBox.Items[dakika_comboBox.SelectedIndex].ToString()), 0);

                    sefer.Sefer_kalkis_saat = zaman;
                    sefer.Sefer_guzergah = guzergah_comboBox.Items[guzergah_comboBox.SelectedIndex].ToString();
                    sefer.Sefer_sofor = sofor_comboBox.Items[sofor_comboBox.SelectedIndex].ToString();
                    sefer.Sefer_plaka = ortak_degiskenler_classlar.secilen_oto_plaka;

                    db.seferler.Add(sefer);// sefer classımıza eklediğimiz değişkenlerimiz ile beraber veritabanına ekle
                    db.SaveChanges();// değişiklikleri kaydet
                    ortak_class.olumlu_olumsuzMessageBox(true, "Sefer Başarıyla Kaydedildi.."); // true olumlu olduğunu , gösterilcek mesaj
                    this.Close();
                }
            }
        }


    }
}
