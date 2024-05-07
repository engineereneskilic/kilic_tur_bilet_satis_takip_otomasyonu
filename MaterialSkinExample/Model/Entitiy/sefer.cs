using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSkinExample.Model.Entitiy
{
    class sefer
    {
       
        private int sefer_no;
        [Key]
        public int Sefer_no
        {
            get
            {
                return sefer_no;
            }

            set
            {
                sefer_no = value;
            }
        }
        private int sefer_varisperon_no;
        public int Sefer_varisperon_no
        {
            get
            {
                return sefer_varisperon_no;
            }

            set
            {
                sefer_varisperon_no = value;
            }
        }

        private DateTime sefer_kalkis_tarihi;
        public DateTime Sefer_kalkis_tarihi
        {
            get
            {
                return sefer_kalkis_tarihi;
            }

            set
            {
                sefer_kalkis_tarihi = value;
            }
        }


        
        private TimeSpan sefer_kalkis_saat;

        [Column(TypeName = "time")] // veritabani veritipi time sadece zaman
        public TimeSpan Sefer_kalkis_saat
        {
            get
            {
                return sefer_kalkis_saat;
            }

            set
            {
                sefer_kalkis_saat = value;
            }
        }

        private string sefer_guzergah;
        public string Sefer_guzergah
        {
            get
            {
                return sefer_guzergah;
            }

            set
            {
                sefer_guzergah = value;
            }
        }

        private string sefer_sofor;
        public string Sefer_sofor
        {
            get
            {
                return sefer_sofor;
            }

            set
            {
                sefer_sofor = value;
            }
        }


        private string sefer_plaka;
        public string Sefer_plaka
        {
            get
            {
                return sefer_plaka;
            }

            set
            {
                sefer_plaka = value;
            }
        }


    }
}
