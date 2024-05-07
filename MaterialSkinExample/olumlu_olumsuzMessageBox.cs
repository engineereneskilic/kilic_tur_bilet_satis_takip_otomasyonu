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
    public partial class olumlu_olumsuzMessageBox : MaterialForm
    {
        public olumlu_olumsuzMessageBox()
        {
            InitializeComponent();
            // TEMA İLE İLGİLİ ÖZELLİKLER
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.Blue100, TextShade.WHITE);
        }
        public string gelen_mesaj; // gösterilcek mesaj
        public bool olumlumu; // gelcek olan mesaj olumlu olarak mı değerlendirilsin olumsuz olarak mı
        private void olumlu_olumsuzMessageBox_Load(object sender, EventArgs e)
        {
            gelen_mesaj_label.Text = gelen_mesaj;

            if (olumlumu) // olumlysa
            {
                gelen_mesaj_label.ForeColor = Color.FromArgb(0, 192, 0); // labelin yazı rengi yeşil tonu olsun
                uyari_pictureBox.Image = resimlerim.tick; // tick olsun resim
                tamam_button.Icon = resimlerim.tick; // tamam buttonun iconu değişsin
            }
            else
            {
                gelen_mesaj_label.ForeColor = Color.FromArgb(229, 40, 38); // labelin yazı rengi kırmızı tonlu olsun
                uyari_pictureBox.Image = resimlerim.cancel;// çarpı olsun resim
                tamam_button.Icon = resimlerim.cancel;// tamam buttonunun iconu değişsin
            }

        }

        private void tamam_button_Click(object sender, EventArgs e)
        {
            this.Close(); // formum kapansın
        }
    }
}
