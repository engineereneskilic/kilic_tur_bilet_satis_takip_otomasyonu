﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSkinExample.Model.Context
{
    class kullanicilarDbContext:DbContext
    {
        public DbSet<Entitiy.kullanici> kullanicilar { get; set; }// veritabanı bağlantısı 
    }
}
