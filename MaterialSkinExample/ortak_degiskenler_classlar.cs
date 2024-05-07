using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; // ilk harf büyük için sınıf genelde uzantıların olduğu bir sınıf

namespace MaterialSkinExample
{
    class ortak_degiskenler_classlar // bütün ortak formlarda kullanılan verilerin metodların bulunduğu sınıf
    {
        public static string program_ismi = "KILIÇ TUR BİLET SATIŞ TAKİP PROGRAMI";
        private static string kullanici_ismi;
        private static string sifre;
        public static string secilen_oto_plaka; // seçilen otobüs plakam her formda sabit olcağı için static
        public static int secilen_oto_seferno;  // seçilen otobüsün sefernosu
        public static string secilen_oto_sofor_ismi;// seçinlen otobüsün şoför ismi
        public static string Kullanici_ismi // kapsülleme yapıyoruz güvenlik için
        {
            get { return kullanici_ismi; }
            set { kullanici_ismi = value; }
        }

        public static string Sifre // kapsülleme yapıyoruz güvenlik için
        {
            get { return sifre; }
            set { sifre = value; }
        }

       


        private string ucret;

        public string Ucret // kapsülleme yapıyoruz
        {
            get { return ucret; }
            set { ucret = Convert.ToDouble(value).ToString("C"); }// para birimine dönüştürdük

        }

        public bool TumBosKontrolü(GroupBox gelen_groupBox) // bu metod gelen groupboxdaki tüm form elemanlarının boş olup olmadğını konrol ediyor boşsa uyarı veriyor hangisinin boşta olduğununda name'sine göre söylüyor
        {
            bool hata = false;
            foreach (Control item in gelen_groupBox.Controls) // gropboxtaki elemanların her biri item değişkeni olarak al
            {
                if (item is ComboBox || item is MaterialSingleLineTextField) // tabi bütün itemler gelceği için mesela buttonda gelcek button olmaz mesela sadece o itemlerden combobox ve tek şeritli textbox ise 
                {
                    string[] temiz_name = item.Name.Split('_'); // ben name verirken genelde ismini _ türü şeklinde name veririm burda temiz dediğim türünü at bana temiz namesi kalsın

                    // item boş ve görünür ise boş uyarısı versin // açıklamak gerekirse ucret ve ödeme şekli kısımları satış tipinine göre görünür görünmez oluyolar görünmeyen bişeyin boş kontrolü olamaz gözüken itemlerin olur. item boşsa ve gözüküyorsa uyarı ver
                    if (item.Text == "" && item.Visible) 
                    {
                        // namelerini verirken ismini_türünü verdiğimi yazmıştım name verirken baş haflerini büyük vermem ama burda özel messageboxumda uyarı verdirtirken temiz namemin baş harfinin büyük olması görsel açıdan güzel.
                        olumlu_olumsuzMessageBox(false, IlkHarfleriBuyut(temiz_name[0]) + " kısmını boş bıraktınız !"); 
                        hata = true; //hata varsa hata var yani true
                    }

                }
                
            }
            return hata;
        }


   
        
        public void olumlu_olumsuzMessageBox(bool olumlumu, string gelen_mesaj) // özel oluşturduğum messageboxum olumlumu olumluysa true değilse false, gelelen mesaj şeklinde
        {
            olumlu_olumsuzMessageBox olumluMessageBox = new olumlu_olumsuzMessageBox(); // formumu çağırıyorum
            olumluMessageBox.olumlumu = olumlumu; // formuma veriyi göderiyorum
            olumluMessageBox.gelen_mesaj = gelen_mesaj;// formuma veriyi gönderiyorum
            olumluMessageBox.ShowDialog();// gösteriyorum
            
        }

        private string IlkHarfleriBuyut(string metin) // bir stringin bu bir kelime ve cümle olabilir baş harflerini büyütüyor
        {
            System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Globalization.TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(metin);
        }

        public bool IsNumeric(string value) // gelen string numaric mi değilmi kontrolü
        {
            double oReturn = 0;
            return double.TryParse(value, out oReturn);
        }

        public string trtoeng(string gelen_yazi) // türkçe karakterli ingilizceye çeviren metodum
        {
            gelen_yazi = gelen_yazi.ToLower();
            gelen_yazi = gelen_yazi.Replace('ç', 'c');
            gelen_yazi = gelen_yazi.Replace('ö', 'o');
            gelen_yazi = gelen_yazi.Replace('ü', 'u');
            gelen_yazi = gelen_yazi.Replace('ğ', 'g');
            gelen_yazi = gelen_yazi.Replace('ş', 's');
            gelen_yazi = gelen_yazi.Replace('ı', 'i');
            gelen_yazi = gelen_yazi.Replace(' ', '_');

            return gelen_yazi;
        }

        // Delegate-event Uyarıları
        public void yolcu_TelFormat_Uyarisi()
        {

            olumlu_olumsuzMessageBox(false,"Telefon numarasını Lütfen Doğru formatta Giriniz !");

        }

        public void yolcu_CinsiyetSecmediniz()
        {
            olumlu_olumsuzMessageBox(false, "Cinsiyet Seçmediniz !");

        }

        public void yolcu_ayniguzergahUyarisi()
        {
            olumlu_olumsuzMessageBox(false,"Nereden ve Nereye Kısmı Aynı Olamaz !");
        }


        public bool seferdemi(DateTime datetime, TimeSpan baslangic, TimeSpan son) //ilk değer start ve end değerin arasında bir zaman mı olup olmayacağını araştıracağımız zaman,baslangıc ise aralığımızın başlangıcı son ise sonu
        {
           
            TimeSpan simdi = datetime.TimeOfDay; // şimdki zamanı saat dakika saniye  olarak alıyoruz
             // son zaman başlangıc zamanından büyükse
            if (baslangic < son)
                return baslangic <= simdi && simdi <= son; // simdi başlangıctan küçük eşittir ise ve son başlangıctan büyük eşiitrse 
            // başangıc sondan sonra ise ters çevir
            return !(son < simdi && simdi < baslangic);

            //return ederkenki kısmı if içine yazmıslar düşünün if geri dönüş değeri eğer ya olmuştur yada olmamıştır boolean değer alır örneğin ya if(a>=1) yada if(a<=1) başka olasılık yoktur ya true ya false
        }

    }

}

