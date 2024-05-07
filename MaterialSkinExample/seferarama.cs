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
    public partial class seferarama : MaterialForm
    {
        public seferarama()
        {
            InitializeComponent();
            // TEMA İLE İLGİLİ ÖZELLİKLER
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.Blue100, TextShade.WHITE);
        }

        private void seferarama_Load(object sender, EventArgs e)
        {
            
        }

        private void tarih_dateTimePicker_ValueChanged(object sender, EventArgs e) // datetimepicker değer değiştiğinde
        {
            guzergah_comboBox.Text = ""; // güzergah varsayılan değere dönsün
            sefer_sorgula("tarihe_gore");
        }

        private void sefer_sorgula(string secilen_text)
        {
            tum_seferler_ListView.Items.Clear(); // eski sorgulara ait listedeki itemler silinsin

            tarih_dateTimePicker.Format = DateTimePickerFormat.Custom; // formatı değiştirilebilir olarak ayarla
            tarih_dateTimePicker.CustomFormat = "dd-MM-yyyy"; // yıl-ay-gün olarak değiştiriyoruz


            using (var db = new Model.Context.seferlerDbContext())
            {
                
                if (secilen_text == "tarihe_gore")
                {
                    

                    string[] parcala = tarih_dateTimePicker.Text.Split('-');// yıl-ay-gün ayırıyoruz ve yeni bir datetimeye atıoyruz

                    int yil = Convert.ToInt32(parcala[2]);
                    int ay = Convert.ToInt32(parcala[1]);
                    int gün = Convert.ToInt32(parcala[0]);

                    var tarihe_gore = from k in db.seferler
                                      where k.Sefer_kalkis_tarihi == new DateTime(yil, ay, gün) // böyle yapmamısın sebebi datetimepickerdan gelen değer sefer kalkiş tarihi ile herşey aynı olmasına rağmen eşleşmiyor
                                    select k;

                    foreach (var eleman in tarihe_gore)
                    {
                       
                        // listwiev eklenmede kullancağım metot
                        listeEkle(eleman.Sefer_no,eleman.Sefer_varisperon_no,eleman.Sefer_kalkis_tarihi,eleman.Sefer_kalkis_saat,eleman.Sefer_guzergah,eleman.Sefer_plaka,eleman.Sefer_sofor); 
                    }
                }
                else
                {
                    
                    var guzergah_gore = from k in db.seferler
                                        where k.Sefer_guzergah == guzergah_comboBox.SelectedItem.ToString()
                                        select k; // güzergah combobaxta secilen iteme göre listele
                    foreach (var eleman in guzergah_gore)
                    {
                        // listwiev eklenmede kullancağım metot
                        listeEkle(eleman.Sefer_no, eleman.Sefer_varisperon_no, eleman.Sefer_kalkis_tarihi, eleman.Sefer_kalkis_saat, eleman.Sefer_guzergah, eleman.Sefer_plaka, eleman.Sefer_sofor);
                    }
                }
               
            }
        }

        private void listeEkle(int sefer_no,int varis_peron_no,DateTime sefer_kalkis_tarihi,TimeSpan sefer_kalkis_saat,string sefer_guzergah,string sefer_plaka,string sefer_sofor)
        {

            ListViewItem sefer_item = new ListViewItem(sefer_no.ToString()); // listview item oluştur ve ilk sırada sefernosunu ekle
            // alt itemlerini ekle
            sefer_item.SubItems.Add(varis_peron_no.ToString());
            sefer_item.SubItems.Add(sefer_kalkis_tarihi.ToString().Substring(0, 10));
            sefer_item.SubItems.Add(sefer_kalkis_saat.ToString());
            sefer_item.SubItems.Add(sefer_guzergah.ToString());
            sefer_item.SubItems.Add(sefer_plaka.ToString());
            sefer_item.SubItems.Add(sefer_sofor.ToString());
            tum_seferler_ListView.Items.Add(sefer_item);// bu itemi listeye ekle
        }

        private void guzergah_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tarih_dateTimePicker.Value = DateTime.Now; // guzergah değişirse tarih_datetimePicker Varsayılan değerine dönsün
            sefer_sorgula("guzergah_gore");
            
        }

        private void herseyi_temizleButton_Click(object sender, EventArgs e)
        {
            // eski sorguya ait itemler temizlensin
            tum_seferler_ListView.Items.Clear();
            // herseyi_temize buttona tıklandığı zaman herşey varsayılan değer dönsün

            tarih_dateTimePicker.Value = DateTime.Now;
            guzergah_comboBox.Text = "";

        }


        
        private void tum_seferler_ListView_Click_MouseClick(object sender, MouseEventArgs e) // menu listview elemanlarına tıklandığı zaman tetiklencek metot
        {

            if (e.Button == MouseButtons.Left) // sol tıklanırsa
            {
                if (tum_seferler_ListView.FocusedItem!= null) // ters tıklanan yer listwievde focuslanan bir yerse
                {
                    if (tum_seferler_ListView.FocusedItem.Bounds.Contains(e.Location) == true) // focuslanan item ile moouse lokasyonu çakışıyormu
                    {
                        // selectetItems yada focesed item aynı şey 0 elemanını alıyoruz yani sefersonusu ortak classımıza gönderiyoruz heryerden kullanalım diye
                        ortak_degiskenler_classlar.secilen_oto_seferno = Convert.ToInt32(tum_seferler_ListView.SelectedItems[0].SubItems[0].Text);
                        ortak_degiskenler_classlar.secilen_oto_plaka = tum_seferler_ListView.SelectedItems[0].SubItems[5].Text;// yine aynı şekilde 5. elemanı plaka yazan elemanı alyıyoruz ve gönderiyoruz

                        otobus_bilet_islemleri bilet_satis_formu = new otobus_bilet_islemleri();
                        bilet_satis_formu.Show();
                    }
                }

            }
            if(e.Button == MouseButtons.Right)//sağ tıklanırsa
            {
                if (tum_seferler_ListView.FocusedItem.Bounds.Contains(e.Location) == true) // focuslanan item ile moouse lokasyonu çakışıyormu
                {
                    cikar_ContextMenuStrip.Show(Cursor.Position);// çakışıyorsa tam bu çakışan noktada contextmenustripti yani normak ters tıkta açıldığı gibi menü gelsin

                }
            }
        }
        /*
         sefer silme işlemi
         ContextMenustritp bildiğimiz sağ tıklanınca kes kopyala yapıştır gibi çıkan menüler.Bu form elemanını liste üzerindeki itemlerden birine ters tıkladığınızda çıkar yazısı çıkacaktır
         onu aynı kesermiş gibi tıklayarak veritabanından silebiliriz.
         */
        private void cikarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new Model.Context.seferlerDbContext())
            {
                db.seferler.Remove(db.seferler.Find(Convert.ToInt32(tum_seferler_ListView.FocusedItem.SubItems[0].Text))); // 0. eleman yani sefer_no aynı zamanda sefer tablosunun idsi
                db.SaveChanges();
            }
            // seferler silinince yolcularda silinsin
            using (var db = new Model.Context.yolcularDbContext())
            {
                var yolcularida_sil = from k in db.yolcular
                                      where k.Yolcu_seferno == Convert.ToInt32(tum_seferler_ListView.FocusedItem.SubItems[0].Text) && k.Yolcu_plaka == tum_seferler_ListView.FocusedItem.SubItems[5].Text
                                      select k;
                foreach(var eleman in yolcularida_sil)
                {
                    db.yolcular.Remove(db.yolcular.Find(eleman.Yolcu_id));
                }
            }

        }
    }
}
