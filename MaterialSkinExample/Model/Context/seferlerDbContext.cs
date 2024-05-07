using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSkinExample.Model.Context
{
    class seferlerDbContext:DbContext
    {
        public DbSet<Entitiy.sefer> seferler { get; set; }// veritabanı bağlantısı 
    }
}
