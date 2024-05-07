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
    public partial class fatura_olustur : Form
    {
        public fatura_olustur()
        {
            InitializeComponent();
        }

        public int SatirSayisi = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ffff)
        {
            otobus_bilet_islemleri otobusbilet_formu = (otobus_bilet_islemleri)Application.OpenForms["otobus_bilet_islemleri"]; // otobus bilet islemleri elemanlarını değerleriyle almak için oluşturuyoruz


            //ÇİZİM BAŞLANGICI
            Font font = new Font("Calibri", 7); //font oluşturduk
            SolidBrush sbrush = new SolidBrush(Color.Black);//fırça oluşturduk
            Pen myPen = new Pen(Color.Black); //kalem oluşturduk

            ffff.Graphics.DrawString("Düzenlenme Tarihi: " + DateTime.Now.ToLongDateString() + "   " + DateTime.Now.ToLongTimeString(), font, sbrush, 50, 23);
            ffff.Graphics.DrawLine(myPen, 50, 43, 770, 43); // Çizgi çizdik... 1. Kalem, 2. X, 3. Y Koordinatı, 4. Uzunluk, 5. BitişX 

            // OTOBÜS LOGOSU
            Bitmap logo_bitmap = resimlerim.kucuk_logo;

            ffff.Graphics.DrawImage(logo_bitmap, 40, 45);


            font = new Font("Calibri", 15, FontStyle.Bold);//Fatura başlığı yazacağımız için fontu kalın yaptık ve puntoyu büyütüp 15 yaptık.
            /*
            görülduğü gibi her formda plakayı sefernosunu kullandığımız için ortak classımda tutuyorum. Bu benim formlar arası veri taşımama engel oluyor hangi formdan göndersem nası alsam gibi karmaşıklık 
            ortadan kalkıyor nerde olduğunu biliyorum 
            */
            ffff.Graphics.DrawString(ortak_degiskenler_classlar.secilen_oto_seferno+" Sefer Sayılı "+ortak_degiskenler_classlar.secilen_oto_plaka+" Yolcu Faturası", font, sbrush, 250, 120);
            ffff.Graphics.DrawLine(myPen, 50, 150, 770, 150); //çizgi çizdik.

            font = new Font("Calibri", 10, FontStyle.Bold); //Detay başlığını yazacağımız için fontu kalın yapıp puntoyu 10 yaptık.
            ffff.Graphics.DrawString("Koltuk No", font, sbrush, 50, 170); 
            ffff.Graphics.DrawString("Adı Soyadı", font, sbrush, 150, 170); 
            ffff.Graphics.DrawString("Cinsiyet", font, sbrush, 260, 170); 
            ffff.Graphics.DrawString("Nereden", font, sbrush, 370, 170); 
            ffff.Graphics.DrawString("Nereye", font, sbrush, 480, 170);
            ffff.Graphics.DrawString("Odeme Şekli", font, sbrush, 590, 170);
            ffff.Graphics.DrawString("Ücret", font, sbrush, 700, 170);
            ffff.Graphics.DrawLine(myPen, 50, 190, 770, 190); //Çizgi çizdik.




            int y = 195; //y koordinatının yerini belirledik.(Verilerin yazılmaya başlanacağı yer)

            font = new Font("Calibri", 10); //fontu 10 yaptık.


            int i = 0;//satır sayısı için değişken tanımladık.


            while (i < otobusbilet_formu.secilenplaka_yolcu_ListView.Items.Count)//döngüyü son satırda sonlandıracağız.
            {                           // text,font,fırça,x,y
                ffff.Graphics.DrawString(otobusbilet_formu.secilenplaka_yolcu_ListView.Items[i].SubItems[2].Text, font, sbrush, 70, y);//1.sütun
                ffff.Graphics.DrawString(otobusbilet_formu.secilenplaka_yolcu_ListView.Items[i].SubItems[3].Text, font, sbrush, 150, y);//2.sütun
                ffff.Graphics.DrawString(otobusbilet_formu.secilenplaka_yolcu_ListView.Items[i].SubItems[4].Text, font, sbrush, 260, y);//5.sütun
                ffff.Graphics.DrawString(otobusbilet_formu.secilenplaka_yolcu_ListView.Items[i].SubItems[5].Text, font, sbrush, 370, y);//6.sütun
                ffff.Graphics.DrawString(otobusbilet_formu.secilenplaka_yolcu_ListView.Items[i].SubItems[6].Text, font, sbrush, 480, y);//7.sütun
                ffff.Graphics.DrawString(otobusbilet_formu.secilenplaka_yolcu_ListView.Items[i].SubItems[7].Text, font, sbrush, 590, y);//8.sütun
                ffff.Graphics.DrawString(otobusbilet_formu.secilenplaka_yolcu_ListView.Items[i].SubItems[8].Text, font, sbrush, 700, y);//9.sütun
                y += 20; //y koordinatını arttırdık.
                i += 1; //satır sayısını arttırdık


                //yeni sayfaya geçme kontrolü
                if (y > 1000)
                {
                    ffff.Graphics.DrawString("(Devamı -->)", font, sbrush, 700, y + 50);
                    y = 50;
                    break; //burada yazdırma sınırına ulaştığımız için while döngüsünden çıkıyoruz
                           //çıktığımızda while baştan başlıyor i değişkeni değer almaya devam ediyor
                           //yazdırma yeni sayfada başlamış oluyor
                }

                if (i == otobusbilet_formu.secilenplaka_yolcu_ListView.Items.Count)
                {
                    font = new Font("Calibri", 11, FontStyle.Bold); //tekrardan kalın yaptık ve puntoyuda büyüttük

                    ffff.Graphics.DrawLine(myPen, 50, y, 770, y); //çizgi çizdik.
                    ffff.Graphics.DrawString("Nakit:", font, sbrush, 500, y+20);
                    ffff.Graphics.DrawString(otobusbilet_formu.nakit_label.Text, font, sbrush, 700, y+20);

                    ffff.Graphics.DrawString("Kredi Kartı:", font, sbrush, 500, y+40);
                    ffff.Graphics.DrawString(otobusbilet_formu.kredikarti_label.Text, font, sbrush, 700, y+40);

                    ffff.Graphics.DrawLine(myPen, 50, y, 770, y); //çizgi çizdik.
                    ffff.Graphics.DrawString("Genel Toplam Fiyat:", font, sbrush, 500, y+60);
                    ffff.Graphics.DrawString(otobusbilet_formu.toplam_label.Text, font, sbrush, 700, y+60);
                }
            }




            //çoklu sayfa kontrolü
            if (i < SatirSayisi)
            {
                ffff.HasMorePages = true;
            }
            else
            {
                ffff.HasMorePages = false;
                i = 0;
            }
            StringFormat myStringFormat = new StringFormat();
            myStringFormat.Alignment = StringAlignment.Far;


        }

        // yazdır iconlu buttona bastığımıza bildiğimiz yazdırma tetikleniyor
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
