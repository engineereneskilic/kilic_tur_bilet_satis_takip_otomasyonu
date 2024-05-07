using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSkinExample.Model.Context
{
    class soforlerDbContext:DbContext
    {
        public DbSet<Entitiy.sofor> soforler { get; set; }// veritabanı bağlantısı 
    }
}

