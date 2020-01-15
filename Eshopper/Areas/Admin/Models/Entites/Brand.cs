using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Eshopper.Areas.Admin.Models.Entites
{
    public class Brand
    {
        [Key]
        public int brandId { get; set; }
        [Display(Name = "Marka Adı")]
        public string brandName { get; set; }

        // relation
        public  virtual ICollection<Product> Product { get; set; }
    }
}