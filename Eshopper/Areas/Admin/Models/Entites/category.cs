using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Eshopper.Areas.Admin.Models.Entites
{
    public class category
    {
        public int Id { get; set; }
        [Display(Name ="Kategori Adı")]
        public string categoryName { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}