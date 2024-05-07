using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSkinExample.Model.Entitiy
{
    class kullanici
    {
        
        private int kullanici_id;

        [Key]
        public int Kullanici_id // id mutlaka kapsüllenmeli güvenlik açısından
        {
            get
            {
                return kullanici_id;
            }

            set
            {
                kullanici_id = value;
            }
        }

        private string kullanici_adi;
        public string Kullanici_adi
        {
            get
            {
                return kullanici_adi;
            }

            set
            {
                kullanici_adi = value;
            }
        }

        private string kullanici_sifre;
        public string Kullanici_sifre
        {
            get
            {
                return kullanici_sifre;
            }

            set
            {
                kullanici_sifre = value;
            }
        }
        private string kullanici_cinsiyet;
        public string Kullanici_cinsiyet
        {
            get
            {
                return kullanici_cinsiyet;
            }

            set
            {
                kullanici_cinsiyet = value;
            }
        }
        private string kullanici_medeni_durum;
        public string Kullanici_medeni_durum
        {
            get
            {
                return kullanici_medeni_durum;
            }

            set
            {
                kullanici_medeni_durum = value;
            }
        }
        private string kullanici_tckimlik;
        public string Kullanici_tckimlik
        {
            get
            {
                return kullanici_tckimlik;
            }

            set
            {
                kullanici_tckimlik = value;
            }
        }
        private string kullanici_dogum_tarihi;
        public string Kullanici_dogum_tarihi
        {
            get
            {
                return kullanici_dogum_tarihi;
            }

            set
            {
                kullanici_dogum_tarihi = value;
            }
        }
        private string kullanici_dogumyeri;
        public string Kullanici_dogumyeri
        {
            get
            {
                return kullanici_dogumyeri;
            }

            set
            {
                kullanici_dogumyeri = value;
            }
        }
        private string kullanici_telno;
        public string Kullanici_telno
        {
            get
            {
                return kullanici_telno;
            }

            set
            {
                kullanici_telno = value;
            }
        }


        private string kullanici_adres;
        public string Kullanici_adres
        {
            get
            {
                return kullanici_adres;
            }

            set
            {
                kullanici_adres = value;
            }
        }




        public void defaultVeriler() // Burda veritabanı olouşturulduğunda varsayılan olarak girilen veriler gösterilmekte
        {
            using (var db = new Model.Context.kullanicilarDbContext())
            {
                // kullanıcı bilgilerini listeler halinde tutuyoruz

                List<string> kullanici_adi_listesi = new List<string>();
                kullanici_adi_listesi.Add("Şakir PALAZ");
                kullanici_adi_listesi.Add("Osman KOCASAKAL");
                kullanici_adi_listesi.Add("KEMAL IŞIK");
                kullanici_adi_listesi.Add("Merve DURMAZ");
                kullanici_adi_listesi.Add("Nalan ÖZGÜR");
                kullanici_adi_listesi.Add("Pelin KINALI");
                kullanici_adi_listesi.Add("Cihan KALELİ");
                kullanici_adi_listesi.Add("Turgut KALE");
                kullanici_adi_listesi.Add("İsmail ÖZDEN");
                kullanici_adi_listesi.Add("Özlem KILIÇ");



                List<String> kullanici_sifre_listesi = new List<String>();
                kullanici_sifre_listesi.Add("sakir123");
                kullanici_sifre_listesi.Add("osman123");
                kullanici_sifre_listesi.Add("kemal123");
                kullanici_sifre_listesi.Add("merve123");
                kullanici_sifre_listesi.Add("nalan123");
                kullanici_sifre_listesi.Add("pelin123");
                kullanici_sifre_listesi.Add("cihan123");
                kullanici_sifre_listesi.Add("turgut123");
                kullanici_sifre_listesi.Add("ismail123");
                kullanici_sifre_listesi.Add("ozlem123");


                List<String> kullanici_medeni_durum_listesi = new List<String>();
                kullanici_medeni_durum_listesi.Add("Bekar");
                kullanici_medeni_durum_listesi.Add("Bekar");
                kullanici_medeni_durum_listesi.Add("Evli");
                kullanici_medeni_durum_listesi.Add("Bekar");
                kullanici_medeni_durum_listesi.Add("Evli");
                kullanici_medeni_durum_listesi.Add("Evli");
                kullanici_medeni_durum_listesi.Add("Bekar");
                kullanici_medeni_durum_listesi.Add("Bekar");
                kullanici_medeni_durum_listesi.Add("Bekar");
                kullanici_medeni_durum_listesi.Add("Evli");


                List<String> kullanici_cinsiyet_listesi = new List<String>();
                kullanici_cinsiyet_listesi.Add("Erkek");
                kullanici_cinsiyet_listesi.Add("Erkek");
                kullanici_cinsiyet_listesi.Add("Erkek");
                kullanici_cinsiyet_listesi.Add("Kadın");
                kullanici_cinsiyet_listesi.Add("Kadın");
                kullanici_cinsiyet_listesi.Add("Kadın");
                kullanici_cinsiyet_listesi.Add("Erkek");
                kullanici_cinsiyet_listesi.Add("Erkek");
                kullanici_cinsiyet_listesi.Add("Erkek");
                kullanici_cinsiyet_listesi.Add("Kadın");

                List<String> kullanici_tckimlik_listesi = new List<String>();
                kullanici_tckimlik_listesi.Add("16110031610");
                kullanici_tckimlik_listesi.Add("69488914315");
                kullanici_tckimlik_listesi.Add("16510310654");
                kullanici_tckimlik_listesi.Add("89749823136");
                kullanici_tckimlik_listesi.Add("19894948196");
                kullanici_tckimlik_listesi.Add("98749815613");
                kullanici_tckimlik_listesi.Add("56161961231");
                kullanici_tckimlik_listesi.Add("41984416561");
                kullanici_tckimlik_listesi.Add("18949981231");
                kullanici_tckimlik_listesi.Add("87987213616");
                kullanici_tckimlik_listesi.Add("49879481316");

                List<String> kullanici_dogum_tarihi_listesi = new List<String>();
                kullanici_dogum_tarihi_listesi.Add("05.05.1967");
                kullanici_dogum_tarihi_listesi.Add("13.10.1992");
                kullanici_dogum_tarihi_listesi.Add("06.11.1963");
                kullanici_dogum_tarihi_listesi.Add("02.07.1988");
                kullanici_dogum_tarihi_listesi.Add("03.10.1980");
                kullanici_dogum_tarihi_listesi.Add("12.03.1985");
                kullanici_dogum_tarihi_listesi.Add("09.10.1980");
                kullanici_dogum_tarihi_listesi.Add("25.10.1976");
                kullanici_dogum_tarihi_listesi.Add("10.05.1995");
                kullanici_dogum_tarihi_listesi.Add("07.09.1992");

                List<String> kullanici_dogum_yeri_listesi = new List<String>();
                kullanici_dogum_yeri_listesi.Add("Isparta");
                kullanici_dogum_yeri_listesi.Add("Denizli");
                kullanici_dogum_yeri_listesi.Add("Kırşehir");
                kullanici_dogum_yeri_listesi.Add("Bolu");
                kullanici_dogum_yeri_listesi.Add("Erzincan");
                kullanici_dogum_yeri_listesi.Add("Kırklareli");
                kullanici_dogum_yeri_listesi.Add("Eskişehir");
                kullanici_dogum_yeri_listesi.Add("Gaziantep");
                kullanici_dogum_yeri_listesi.Add("Bursa");
                kullanici_dogum_yeri_listesi.Add("Yalova");

                List<String> kullanici_telno_listesi = new List<String>();
                kullanici_telno_listesi.Add("5451561651");
                kullanici_telno_listesi.Add("5451132132");
                kullanici_telno_listesi.Add("5438949848");
                kullanici_telno_listesi.Add("5461894494");
                kullanici_telno_listesi.Add("5430948942");
                kullanici_telno_listesi.Add("5469789713");
                kullanici_telno_listesi.Add("5351691989");
                kullanici_telno_listesi.Add("5369874945");
                kullanici_telno_listesi.Add("5458798792");
                kullanici_telno_listesi.Add("5358949849");

                List<String> kullanici_adres_listesi = new List<String>();
                kullanici_adres_listesi.Add("Cihangir, Talatpaşa Cd. No:66, 34310 Avcılar/İstanbul");
                kullanici_adres_listesi.Add("Merkez Mahallesi, Büyükparmakkapı sokak no:3/A, İstiklal Cd., 34433 Beyoğlu/İstanbul");
                kullanici_adres_listesi.Add("Halaskargazi Mahallesi, Vali Konağı Cd. No:5, 34371 Şişli/İstanbul");
                kullanici_adres_listesi.Add("Cevatpaşa Mah, Eski Edirne Asf. No:371, 34045 Gazi̇osmanpaşa/Bayrampaşa/İstanbul");
                kullanici_adres_listesi.Add("Alemdar Mahallesi, Çatalçeşme sokak Gendaş işhanı no:19 kat:3 Cağaloğlu, 34110 Fatih/İstanbul");
                kullanici_adres_listesi.Add("Hürriyet Mahallesi, 19 Mayıs Cad. Golden Plaza No:1, 34210 Bağcılar/Istanbul - Europe");
                kullanici_adres_listesi.Add("Maltepe Mahallesi, Maltepe Mah. Eski Çırpıcı Yolu Sok. No:8 Parima Plaza Kat:7 Ofis:85 Cevizlibağ, 34010 Zeytinburnu/İstanbul");
                kullanici_adres_listesi.Add("Namık Kemal Mahallesi, Cengiz Topel Cad. No:30, 34762 Ümraniye/Istanbul - Asia");
                kullanici_adres_listesi.Add("İçerenköy Mahallesi, Kayışdağı Cad. Marriott Hotel Asia No:1, 34752 Ataşehir/İstanbul");
                kullanici_adres_listesi.Add("Hobyar Mahallesi, Ankara Cd. No:157, 34083 Fatih/İstanbul");


                var tablo_bosmu = (from k in db.kullanicilar
                                   select k).Count();

                if (tablo_bosmu == 0) // tablo boşsa
                {

                    for (int i = 0; i <= kullanici_adi_listesi.Count; i++)
                    {
                        // class çağırıyoruz ve atamalarını yapıyoruz
                        kullanici kullanici = new kullanici();
                        kullanici.Kullanici_adi = kullanici_adi_listesi[i];
                        kullanici.Kullanici_sifre = kullanici_sifre_listesi[i];
                        kullanici.Kullanici_cinsiyet = kullanici_cinsiyet_listesi[i];
                        kullanici.Kullanici_medeni_durum = kullanici_medeni_durum_listesi[i];
                        kullanici.Kullanici_tckimlik = kullanici_tckimlik_listesi[i];
                        kullanici.Kullanici_dogum_tarihi = kullanici_dogum_tarihi_listesi[i];
                        kullanici.Kullanici_dogumyeri = kullanici_dogum_yeri_listesi[i];
                        kullanici.Kullanici_telno = kullanici_telno_listesi[i];
                        kullanici.Kullanici_adres = kullanici_adres_listesi[i];

                        db.kullanicilar.Add(kullanici);// veritabanına bu classı aslında satırı veritabanına ekle diyoruz
                        db.SaveChanges();//yaptığımız değişiklikleri kaydet diyoruz
                    }
                }
            }
        }
    }
}
