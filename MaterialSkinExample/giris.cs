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
    public partial class giris : MaterialForm// materialform benim temam var ordaki yeni form elemanlarına ulaşmam lazım bunun için kalıtım yapıyorum
    {
        public giris()
        {
            InitializeComponent();
            // TEMA İLE İLGİLİ ÖZELLİKLER
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;// theme şekli bir beyaz bir de siyah olarak iki kısımdan olşuyor
            // burdada sırayla formun baştan aşağıya renklerini sırası ile ayarlıyor örneğin en boş en koyu bir aşağısa daha açık ve yazı rengi beyaz gibi
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.Blue100, TextShade.WHITE);
        }
        ortak_degiskenler_classlar ortak_class = new ortak_degiskenler_classlar(); // oluşturulduğu yerde açıkladım
        private void giris_Load(object sender, EventArgs e)
        {
            this.Text = ortak_degiskenler_classlar.program_ismi;
            guvenlik_label.Text = rasgeleUret(); // güvenlik labelimize rasgele 8 haneli güvenlik kodu üretiyoruz
        }

        private void giris_button_Click(object sender, EventArgs e)
        {
            using (var db = new Model.Context.kullanicilarDbContext())
            {
                Model.Entitiy.kullanici kullanici = new Model.Entitiy.kullanici();
                kullanici.defaultVeriler();// varsayılan kullanıcıları veritabanına ekleyen metod çalışsın

                bool bilgiler_dogrumu = false;
                bool robot_testi = false;
                foreach (var eleman in db.kullanicilar)
                {
                    if (kullanici_adi_textbox.Text.Trim() == eleman.Kullanici_adi && sifre_textbox.Text.Trim() == eleman.Kullanici_sifre) // eğer kullanıcı adı ve şifreyi textboxlarla eşit ise 
                    {
                        bilgiler_dogrumu = true; ortak_degiskenler_classlar.Kullanici_ismi = eleman.Kullanici_adi;// ortak classımıza kullanıcı adını gönderiyoruz

                    }

                    if (guvenlik_label.Text == guvenlik_textbox.Text.Trim()) robot_testi = true; // eğer güvenlik label ile guvenlik textbox eşitse robot testinden de geçmiş oluyoruz


                }

                // Hata mesajlarımız
                if (!bilgiler_dogrumu) ortak_class.olumlu_olumsuzMessageBox(false, "Kullanıcı Adı veya Şifre Yanlış !");
                if (!robot_testi) ortak_class.olumlu_olumsuzMessageBox(false, "Güvenlik kodunu lütfen doğru giriniz !");

                if (bilgiler_dogrumu && robot_testi) // herşey doğruysa
                {

                    // programa giriş kayıdı ekliyoruz programa hangi kullanıcı hangi tarih ve saatte girmiş bu bilgi başka yerdede işimize yarıycak
                    Model.Entitiy.programGirisi programgirisi = new Model.Entitiy.programGirisi();
                    programgirisi.programGirisiEkle(); // direk metodumuzu çalıştırarak program girişimizi kaytdetmiş oluyoruz

                


                    anasayfa anasayfa = new anasayfa();
                    anasayfa.Show(); // anasayfaya git..

                    this.Hide(); // bu formu kapat
                }
            }


        }
        private static string rasgeleUret()
        {
            // rasgele harfler üretelim 8 haneli
            Random rastgele = new Random();
            string karakterler = ""; // boş değer atamamız gerekiyor çünkü program hata veriyor.
            for (int i = 1; i <= 4; i++)
            {

                int ascii = rastgele.Next(10, 99); // 10 99 arası rastgele sayı seçiyor
                karakterler += Convert.ToString(ascii);
            }
            return karakterler;
        }
    }
}
