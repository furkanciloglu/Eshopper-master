using Eshopper.Areas.Admin.Models.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Eshopper.Areas.Admin.Models.AppDbContext
{
    public class Context:DbContext
    {
        public Context():base("name=EshopperDB")
        {

        }
        //  adaya classları tablo olarak işaretle
        public DbSet<category> Category { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}