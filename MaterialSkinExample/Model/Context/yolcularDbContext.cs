using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSkinExample.Model.Context
{
    class yolcularDbContext:DbContext
    {
        public DbSet<Entitiy.yolcu> yolcular { get; set; }// veritabanı bağlantısı 

    }
}
