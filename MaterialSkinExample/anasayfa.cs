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
    public partial class anasayfa : MaterialForm // materialform benim temam var ordaki yeni form elemanlarına ulaşmam lazım bunun için kalıtım yapıyorum
    {
        public anasayfa()
        {
            InitializeComponent();
            // TEMA İLE İLGİLİ ÖZELLİKLER
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // theme şekli bir beyaz bir de siyah olarak iki kısımdan olşuyor
                                                                          
            // burdada sırayla formun baştan aşağıya renklerini sırası ile ayarlıyor örneğin en boş en koyu bir aşağısa daha açık ve yazı rengi beyaz gibi
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.Blue100, TextShade.WHITE);
        }
        ortak_degiskenler_classlar ortak_class = new ortak_degiskenler_classlar(); // oluşturduğum yerde açıklaması var
        private void anasayfa_Load(object sender, EventArgs e)
        {
            this.Text = ortak_degiskenler_classlar.program_ismi;
            kullaniciadi_label.Text = ortak_degiskenler_classlar.Kullanici_ismi;

            // otobüs resimleri şuan seferde ise sepya olsun değilse normal renginde olsun
            using (var db = new Model.Context.seferlerDbContext())
            {
                TimeSpan sefer_suresi= new TimeSpan(0,0,0);//saat,dakika,saniye
                foreach (var eleman in db.seferler)
                {
                  


                    // gelen güzergaha göre tahmini varış saat ve dakika bilgileri değişkenlere atanıyor.

                    if (eleman.Sefer_guzergah == "İstanbul-Tekirdağ") { sefer_suresi = new TimeSpan(1, 30, 0); } // 1 saat 30 dakika 0 saniye
                    else
                    if (eleman.Sefer_guzergah == "İstanbul-Tekirdağ-Kırklareli") { sefer_suresi = new TimeSpan(2, 30, 0); } // 2 saat 30 dakika 0 saniye
                    else
                    if (eleman.Sefer_guzergah == "İstanbul-Demirköy-İğneada") { sefer_suresi = new TimeSpan(3,30,0); }// 3 saat 30 dakika 0 saniye
                    else
                    if (eleman.Sefer_guzergah == "İstanbul-Çerkezköy-Kapaklı-Saray") { sefer_suresi = new TimeSpan(1, 30, 0); } // 1 saat 30 dakika 0 saniye
                    else
                    if (eleman.Sefer_guzergah == "İstanbul-Lüleburgaz-Pınarhisar") { sefer_suresi = new TimeSpan(2, 30, 0); } // 2 saat 30 dakika 0 saniye

                    if (eleman.Sefer_kalkis_tarihi.ToShortDateString() == DateTime.Now.ToShortDateString()) // kalkış tarihi bugün ise (Not: ToShortDateString kısa tarihtir)
                    {
                        TimeSpan kalkis_saati = eleman.Sefer_kalkis_saat; 
                        TimeSpan varis_saati = kalkis_saati.Add(sefer_suresi);// varış saati kalkış saati + sefer süresidir
                        // ilk zaman;diğer iki zamanın arasında olup olmadığını sorgulayacağımız zaman,ikinci zaman;başlangıç zamanı,ucuncu zaman;bitiş zamanı; yani ikinci ve ücüncü zaman aralık oluyor
                        bool seferdemis = ortak_class.seferdemi(DateTime.Now, kalkis_saati, varis_saati); 
                        if (seferdemis) // seferdeyse
                        {
                            // namesine göre pictureboxu bul getir ve Picturebox olarak ata (Not: trtoeng yazıların hepisini küçültüp türkçe karakterleri inglizceler ile deiştir yani tam name uygun hale getirir )
                            PictureBox seferdeki_otolar_picturebox = this.Controls.Find("bus_"+ ortak_class.trtoeng(eleman.Sefer_plaka)+"pictureBox", true).FirstOrDefault() as PictureBox; 
                            seferdeki_otolar_picturebox.Image = resimlerim.only_bus_sepya; // kaynaktan sepya otobüs resmini seferdeki otobüsümüsün resmine atıyoruz
                        }
                       
                    }
                   

                }
            }
            
        }
        // tum plakası yazan buttonların hepsine tıklandığında bu metod çalışır
        // bu metodun amacı secilen plakayı sefer işlemlerine göstermek ve onu açmak
        private void tum_otobusler_Button_Click(object sender, EventArgs e)
        {
            Button tiklanan_otobüs = (Button)sender; // tıklanan otobüs gelsin
            ortak_degiskenler_classlar.secilen_oto_plaka = tiklanan_otobüs.Text;


            otobus_sefer_islemleri otobüs_sefer_islemleri_formu = new otobus_sefer_islemleri();
            otobüs_sefer_islemleri_formu.Show();
        }

        // tüm seferlerinin sorgulamasını yapcağımız sayfayı açan metot
        private void tum_seferler_Button_Click(object sender, EventArgs e)
        {
            seferarama seferarama_formu = new seferarama();
            seferarama_formu.ShowDialog();
        }
    }
}
