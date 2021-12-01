using System;
using Microsoft.AspNetCore.Identity;

namespace PersonelCalisanSistemleri.Data.DataModel
{
   public class Employe:IdentityUser
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string VergiNo { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
}
