using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSkinExample.Model.Entitiy
{
    delegate void TelformatEventHandler(); // Telformat eventinde kullancağımız delegate
    delegate void CinsiyetEventHandler(); // CinsiyetSecmediniz eventinde kullancağımız delegate
    delegate void AyniguzergahEventHandler();// AyniGüzergah eventinde kullancağımız event
    class yolcu
    {
        
        public event TelformatEventHandler TelFormat; // telefon formatındaki bozulma sırasında oluşacak işlemlerin tutulduğu event
        public event CinsiyetEventHandler CinsiyetSecmediniz; // cinsiyeti seçmediğimiz zaman oluşacak işlemlerin tutulduğu event
        public event AyniguzergahEventHandler ayniGuzergahUyarisi; // nereden ve nereye kısımları aynı olduğu zaman oluşacak işlemlerin tutulduğu event

        private int yolcu_id;
        [Key]
        public int Yolcu_id // güvenlik için idler kesinlikle kapsüllenmeli !
        {
           
            get
            {
                return yolcu_id;
            }

            set
            {
                yolcu_id = value;
            }
        }

        private string yolcu_durum;
        public string Yolcu_durum
        {
            get
            {
                return yolcu_durum;
            }
            set
            {
                yolcu_durum = value;

            }
        }
       
        private string yolcu_plaka;
        public string Yolcu_plaka
        {
            get
            {
                return yolcu_plaka;
            }
            set
            {
                    yolcu_plaka = value;
            }
        }

        private int yolcu_seferno;
        public int Yolcu_seferno
        {
            get
            {
                return yolcu_seferno;
            }
            set
            {
                    yolcu_seferno = value;
            }
        }

        private string yolcu_isimsoyisim;
        public string Yolcu_isimsoyisim
        {
            get
            {
                return yolcu_isimsoyisim;
            }

            set
            {
                yolcu_isimsoyisim = value;
            }
        }

        private string yolcu_telno;
        public string Yolcu_telno
        {
            get
            {
                return yolcu_telno;
            }

            set
            {
                yolcu_telno = value;
              
                        if (value.Length<10 || value.Substring(0,1)!="5") // telefon no 10 dan az veya ilk karakteri 5 değilse
                        {
                            //event
                            TelFormat?.Invoke();  // ınvoke herhangi oluşabilcek aksilikte çok işe yarıyor bunsuz hep hata veriyor bunu bulmak için çok uğraştım :)
                        }
               
               
                
            }
        }

        private string yolcu_nereden;
        public string Yolcu_nereden
        {
            get
            {
                return yolcu_nereden;
            }

            set
            {
                yolcu_nereden = value;

                                                    //event                         
                if (yolcu_nereden == yolcu_nereye) ayniGuzergahUyarisi?.Invoke();  // ınvoke herhangi oluşabilcek aksilikte çok işe yarıyor bunsuz hep hata veriyor bunu bulmak için çok uğraştım :)
            }
        }

        private int yolcu_koltukno;
        public int Yolcu_koltukno
        {
            get
            {
                return yolcu_koltukno;
            }

            set
            {
                yolcu_koltukno = value;
            }
        }

        private string yolcu_nereye;
        public string Yolcu_nereye
        {
            get
            {
                return yolcu_nereye;
            }

            set
            {
                yolcu_nereye = value;
                                                    //event
                if (yolcu_nereden == yolcu_nereye) ayniGuzergahUyarisi?.Invoke(); // ınvoke herhangi oluşabilcek aksilikte çok işe yarıyor bunsuz hep hata veriyor bunu bulmak için çok uğraştım :)
            }
        }

        private string yolcu_cinsiyet;
        public string Yolcu_cinsiyet
        {
            get
            {
                return yolcu_cinsiyet;
            }

            set
            {
                yolcu_cinsiyet = value;
                                //event
               if (value=="") CinsiyetSecmediniz?.Invoke(); // ınvoke herhangi oluşabilcek aksilikte çok işe yarıyor bunsuz hep hata veriyor bunu bulmak için çok uğraştım :)
            }
        }

        private string yolcu_odemesekli;
        public string Yolcu_odemesekli
        {
            get
            {
                return yolcu_odemesekli;
            }

            set
            {
                yolcu_odemesekli = value;
            }
        }

        private double yolcu_ucret;
        public double Yolcu_ucret
        {
            get
            {
                return yolcu_ucret;
            }

            set
            {
                yolcu_ucret = value;
            }
        }

        // yapıcı metot kullanılınca entitiy bozuluyor burayı bu şekil bırakmak istedim
        /*
        public yolcu(string gelen_yolcu_durum,string gelen_seferno,string gelen_yolcu_isimsoyisim,string gelen_yolcu_telno,string gelen_yolcu_nereden,int gelen_yolcu_koltukno,string gelen_yolcu_nereye, string gelen_yolcu_cinsiyet,string gelen_yolcu_odemesekli,double gelen_yolcu_ucret)
        {
            
                
                // id veritabanı tarafından otomatik atanıyor
                Yolcu_durum = gelen_yolcu_durum;
                Yolcu_seferno=gelen_seferno
                Yolcu_isimsoyisim = gelen_yolcu_isimsoyisim;
                Yolcu_telno = gelen_yolcu_telno;
                Yolcu_nereden = gelen_yolcu_nereden;
                Yolcu_koltukno = gelen_yolcu_koltukno;
                Yolcu_plaka = ortak_degiskenler_classlar.secilen_oto_plaka;
                Yolcu_nereye = gelen_yolcu_nereye;
                Yolcu_cinsiyet = gelen_yolcu_cinsiyet;
                Yolcu_odemesekli = gelen_yolcu_odemesekli;
                Yolcu_ucret = gelen_yolcu_ucret;
           
        }
        */
    }

}
