using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSkinExample.Model.Entitiy
{
    class sofor
    {
       
        private int sofor_id;
        [Key] // id mutlaka kapsüllenmeli güvenlik açısından
        public int Sofor_id
        {
            get
            {
                return sofor_id;
            }

            set
            {
                sofor_id = value;
            }
        }
        private string sofor_adi;
        public string Sofor_adi
        {
            get
            {
                return sofor_adi;
            }

            set
            {
                sofor_adi = value;
            }
        }
        private string sofor_cinsiyet;
        public string Sofor_cinsiyet
        {
            get
            {
                return sofor_cinsiyet;
            }

            set
            {
                sofor_cinsiyet = value;
            }
        }
        private string sofor_medeni_durum;
        public string Sofor_medeni_durum
        {
            get
            {
                return sofor_medeni_durum;
            }

            set
            {
                sofor_medeni_durum = value;
            }
        }
        private string sofor_tckimlik;
        public string Sofor_tckimlik
        {
            get
            {
                return sofor_tckimlik;
            }

            set
            {
                sofor_tckimlik = value;
            }
        }
        private string sofor_dogum_tarihi;
        public string Sofor_dogum_tarihi
        {
            get
            {
                return sofor_dogum_tarihi;
            }

            set
            {
                sofor_dogum_tarihi = value;
            }
        }
        private string sofor_dogumyeri;
        public string Sofor_dogumyeri
        {
            get
            {
                return sofor_dogumyeri;
            }

            set
            {
                sofor_dogumyeri = value;
            }
        }
        private string sofor_telno;
         public string Sofor_telno
        {
            get
            {
                return sofor_telno;
            }

            set
            {
                sofor_telno = value;
            }
        }

        private string sofor_adres;
        public string Sofor_adres
        {
            get
            {
                return sofor_adres;
            }

            set
            {
                sofor_adres = value;
            }
        }



        public void defaultVeriler() // Burda veritabanı olouşturulduğunda varsayılan olarak girilen veriler gösterilmekte
        {
            using (var db = new Model.Context.soforlerDbContext())
            {


                // kullanıcı bilgilerini listeler halinde tutuyoruz


                List<string> sofor_adi_listesi = new List<string>();
                sofor_adi_listesi.Add("Abdullah BAKIR");
                sofor_adi_listesi.Add("Fatih KOCATÜRK");
                sofor_adi_listesi.Add("Kemal TAŞ");
                sofor_adi_listesi.Add("Faruk GEYİK");
                sofor_adi_listesi.Add("Rasim KOCABIYIK");
                sofor_adi_listesi.Add("Yasemin KALAMIŞ");
                sofor_adi_listesi.Add("Nazlı ARI");
                sofor_adi_listesi.Add("Ayşe TEKYUREK");
                sofor_adi_listesi.Add("Şakir UZUN");
                sofor_adi_listesi.Add("Emre KILIÇ");


                List<String> sofor_medeni_durum_listesi = new List<String>();
                sofor_medeni_durum_listesi.Add("Bekar");
                sofor_medeni_durum_listesi.Add("Evli");
                sofor_medeni_durum_listesi.Add("Bekar");
                sofor_medeni_durum_listesi.Add("Evli");
                sofor_medeni_durum_listesi.Add("Evli");
                sofor_medeni_durum_listesi.Add("Bekar");
                sofor_medeni_durum_listesi.Add("Evli");
                sofor_medeni_durum_listesi.Add("Bekar");
                sofor_medeni_durum_listesi.Add("Bekar");
                sofor_medeni_durum_listesi.Add("Evli");


                List<String> sofor_cinsiyet_listesi = new List<String>();
                sofor_cinsiyet_listesi.Add("Erkek");
                sofor_cinsiyet_listesi.Add("Erkek");
                sofor_cinsiyet_listesi.Add("Erkek");
                sofor_cinsiyet_listesi.Add("Erkek");
                sofor_cinsiyet_listesi.Add("Erkek");
                sofor_cinsiyet_listesi.Add("Kadın");
                sofor_cinsiyet_listesi.Add("Kadın");
                sofor_cinsiyet_listesi.Add("Kadın");
                sofor_cinsiyet_listesi.Add("Erkek");
                sofor_cinsiyet_listesi.Add("Erkek");

                List<String> sofor_tckimlik_listesi = new List<String>();
                sofor_tckimlik_listesi.Add("75325468923");
                sofor_tckimlik_listesi.Add("56546545612");
                sofor_tckimlik_listesi.Add("12303649156");
                sofor_tckimlik_listesi.Add("46549813216");
                sofor_tckimlik_listesi.Add("10655156464");
                sofor_tckimlik_listesi.Add("65469498135");
                sofor_tckimlik_listesi.Add("46948910056");
                sofor_tckimlik_listesi.Add("16510656516");
                sofor_tckimlik_listesi.Add("49841321649");
                sofor_tckimlik_listesi.Add("98987943132");
                sofor_tckimlik_listesi.Add("71691111313");

                List<String> sofor_dogum_tarihi_listesi = new List<String>();
                sofor_dogum_tarihi_listesi.Add("25.05.1966");
                sofor_dogum_tarihi_listesi.Add("10.12.1995");
                sofor_dogum_tarihi_listesi.Add("05.10.1966");
                sofor_dogum_tarihi_listesi.Add("10.07.1980");
                sofor_dogum_tarihi_listesi.Add("09.04.1984");
                sofor_dogum_tarihi_listesi.Add("05.10.1989");
                sofor_dogum_tarihi_listesi.Add("07.05.1982");
                sofor_dogum_tarihi_listesi.Add("25.10.1976");
                sofor_dogum_tarihi_listesi.Add("22.11.1965");
                sofor_dogum_tarihi_listesi.Add("29.06.1992");

                List<String> sofor_dogum_yeri_listesi = new List<String>();
                sofor_dogum_yeri_listesi.Add("İstanbul");
                sofor_dogum_yeri_listesi.Add("Ankara");
                sofor_dogum_yeri_listesi.Add("Uşak");
                sofor_dogum_yeri_listesi.Add("İzmir");
                sofor_dogum_yeri_listesi.Add("Kırklareli");
                sofor_dogum_yeri_listesi.Add("Edirne");
                sofor_dogum_yeri_listesi.Add("Trabzon");
                sofor_dogum_yeri_listesi.Add("Antalya");
                sofor_dogum_yeri_listesi.Add("Rize");
                sofor_dogum_yeri_listesi.Add("Eskişehir");

                List<String> sofor_telno_listesi = new List<String>();
                sofor_telno_listesi.Add("5467806870");
                sofor_telno_listesi.Add("5361464165");
                sofor_telno_listesi.Add("5469894949");
                sofor_telno_listesi.Add("5461651561");
                sofor_telno_listesi.Add("5432113213");
                sofor_telno_listesi.Add("5351635165");
                sofor_telno_listesi.Add("5361601465");
                sofor_telno_listesi.Add("5358949423");
                sofor_telno_listesi.Add("5365616516");
                sofor_telno_listesi.Add("5352013161");

                List<String> sofor_adres_listesi = new List<String>();
                sofor_adres_listesi.Add("Muratpaşa Mahallesi, 34040 Bayrampaşa/İstanbul");
                sofor_adres_listesi.Add("Bayrampaşa, Vatan Mallesi Bağlar Caddesi, No : 57 / 3, 34035 İstanbul");
                sofor_adres_listesi.Add("Eyüp, Yıldıztabya Cad. No:23/A-B, 34065 İstanbul");
                sofor_adres_listesi.Add("Cevatpaşa Mah, Eski Edirne Asf. No:371, 34045 Gazi̇osmanpaşa/Bayrampaşa/İstanbul");
                sofor_adres_listesi.Add("Akşemsettin Mah., Cengiz Topel Cad. 8/A, 34070 Eyüp/İstanbul");
                sofor_adres_listesi.Add("Küçükbakkalköy Mah., Dudullu Cd. Brandium AVM No:29, 34750 Ataşehir/İstanbul");
                sofor_adres_listesi.Add("Aziz Mahmut Hüdayi Mahallesi, Hakimiyeti Milliye Cd., 34672 Üsküdar/İstanbul");
                sofor_adres_listesi.Add("Kaptanpaşa Mahallesi Piyalepaşa Bulvarı No 73, Ortadoğu plaza Kat 7 Okmeydanı Şişli, 34384");
                sofor_adres_listesi.Add("İbrahimağa Mh. Dinlenç Cd. No: 13/11 Koşuyolu – Kadıköy / İst., 34718");
                sofor_adres_listesi.Add("Kuloğlu Mh., Turnacıbaşı Sokak No:6, 34433 Beyoğlu/İstanbul");

                var tablo_bosmu = (from k in db.soforler
                                   select k).Count();

                if (tablo_bosmu == 0) // tablo boşsa
                {

                    for (int i = 0; i <= sofor_adi_listesi.Count; i++)
                    {
                        sofor sofor = new sofor();
                        sofor.Sofor_adi = sofor_adi_listesi[i];
                        sofor.Sofor_cinsiyet = sofor_cinsiyet_listesi[i];
                        sofor.Sofor_medeni_durum = sofor_medeni_durum_listesi[i];
                        sofor.Sofor_tckimlik = sofor_tckimlik_listesi[i];
                        sofor.Sofor_dogum_tarihi = sofor_dogum_tarihi_listesi[i];
                        sofor.Sofor_dogumyeri = sofor_dogum_yeri_listesi[i];
                        sofor.Sofor_telno = sofor_telno_listesi[i];
                        sofor.Sofor_adres = sofor_adres_listesi[i];

                        db.soforler.Add(sofor);
                        db.SaveChanges();
                    }
                }

               
            }
        }
    }
}
