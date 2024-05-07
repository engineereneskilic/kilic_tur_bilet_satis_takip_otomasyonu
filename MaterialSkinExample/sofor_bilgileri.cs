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
    public partial class sofor_bilgileri : MaterialForm
    {
        public sofor_bilgileri()
        {
            InitializeComponent();
            // TEMA İLE İLGİLİ ÖZELLİKLER
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.Blue100, TextShade.WHITE);

        }
        ortak_degiskenler_classlar ortak_class = new ortak_degiskenler_classlar();
        private void sofor_bilgileri_Load(object sender, EventArgs e)
        {
            sofor_baslik_label.Text = ortak_degiskenler_classlar.secilen_oto_sofor_ismi; // daha önceden ortak classa göderdiğimiz şoför ismini labelime atıyoruz

            Bitmap goruntulenen_resim = soforler.ResourceManager.GetObject( ortak_class.trtoeng(ortak_degiskenler_classlar.secilen_oto_sofor_ismi)) as Bitmap; /* kaynaktan sofor ismine ait resmimizi alıyoruz alırken
                                                                                                                                                                ingilizceye ceviriyoruz ki resmin ismindeki türkçe karakterler 
                                                                                                                                                                sorun yaratmasın*/

            secilen_sofor_pictureBox.Image = goruntulenen_resim;// resmi formda pictureboxumuza atayalım

            using (var db= new Model.Context.soforlerDbContext())
            {
                var secilen_sofor = from k in db.soforler
                                    where k.Sofor_adi == ortak_degiskenler_classlar.secilen_oto_sofor_ismi
                                    select k; // şoför ismine göre veritabanından bilgilerini al
                foreach (var eleman in secilen_sofor)
                {
                   // form elemanlarımıza veritabanımızdaki bilgileri atıyoruz
                    isimsoyisim_label.Text = eleman.Sofor_adi;
                    cinsiyet_label.Text = eleman.Sofor_cinsiyet;
                    medenidurum_label.Text = eleman.Sofor_medeni_durum;
                    tickimlik_label.Text = eleman.Sofor_tckimlik;
                    dogumyeri_label.Text = eleman.Sofor_dogumyeri;
                    telno_label.Text = eleman.Sofor_telno;
                    adres_label.Text = eleman.Sofor_adres;
                }
                
            }
        }

        private void tamam_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
