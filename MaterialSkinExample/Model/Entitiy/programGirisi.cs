using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSkinExample.Model.Entitiy
{
    class programGirisi
    {
        
        private int giris_id;

        [Key] // Veritabanımızın primary keyi
        public int Giris_id
        {
            get
            {
                return giris_id;
            }

            set
            {
                giris_id = value;
            }
        }
        private string giris_tarih;
        public string Giris_tarih
        {
            get
            {
                return giris_tarih;
            }

            set
            {
                giris_tarih = value;
            }
        }

        private string giris_zaman;
        public string Giris_zaman
        {
            get
            {
                return giris_zaman;
            }

            set
            {
                giris_zaman = value;
            }
        }



        private string giris_kullanici;
        public string Giris_kullanici
        {
            get
            {
                return giris_kullanici;
            }

            set
            {
                giris_kullanici = value;
            }
        }


        // program girişi her program açıldığında veritabanına tarih ve saati dakikası kaydediliyor güvenlik açısından işe yarar bişey.
        public void programGirisiEkle()
        {
            using (var db = new Model.Context.programGirisleriDbContext()) // veritabanı bağlantısı
            {
                DateTime simdiki_zaman = DateTime.Now; // şimdikı zamanı al
                programGirisi programgirisi = new programGirisi();
                programgirisi.Giris_tarih = simdiki_zaman.ToShortDateString();// sadece tarih
                programgirisi.Giris_zaman = simdiki_zaman.ToLongTimeString();// sadece saat (saniyesi ile birlikte)
                programgirisi.Giris_kullanici = ortak_degiskenler_classlar.Kullanici_ismi;// kullanıcı ismi

                db.programGirisleri.Add(programgirisi); // classı veritabanına ekle bunu satır olarak düşünebilirsiniz
                db.SaveChanges(); // değişiklikleri kaydet

            }
        }
    }
}
