using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;



namespace At_Yarisi.Models.siniflar
{
    public class CONTEXT : DbContext
    {
        public DbSet<Members> Members { get; set; }
        public DbSet<Rules> Rules { get; set; }

        public DbSet<PaymentMethod> PaymentMethod { get; set; }

        public DbSet<Bets> Bets { get; set; }
        public DbSet<Horse> Horse { get; set; }

        /*
        public CONTEXT():base("name=DbContext")
        {
                
        }
        */

    }
}