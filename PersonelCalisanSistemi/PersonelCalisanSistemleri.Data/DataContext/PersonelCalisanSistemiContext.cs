using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonelCalisanSistemleri.Data.DataModel;

namespace PersonelCalisanSistemleri.Data.DataContext
{
   public class PersonelCalisanSistemiContext:IdentityDbContext
    {
        public PersonelCalisanSistemiContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Employe> Employe { get; set; }
    }
}
