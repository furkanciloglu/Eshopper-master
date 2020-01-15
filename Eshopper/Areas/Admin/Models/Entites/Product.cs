using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Eshopper.Areas.Admin.Models.Entites
{
    public class Product
    {
        [Key]
        public int productId { get; set; }
        [Display(Name ="Ürün Adı")]
        public string productName { get; set; }
        [Display(Name = "Ürün fiyatı")]
        public decimal Price { get; set; }
        [Display(Name = "Ürün ebatı")]
        public ESize Size { get; set; }
        [Display(Name = "Ürün Rengi")]
        public EColor Color { get; set; }
        [Display(Name = "Ürün açıklaması")]
        public string Description { get; set; }
        [Display(Name = "Ürün Tarihi")]
        public DateTime created { get; set; }
        [Display(Name = "Ürün Resmi")]
        public byte[] img { get; set; }

        [Display(Name = "Kategori")]
        public int categoryId { get; set; }
        [Display(Name = "Marka")]
        public int brandId { get; set; }

        // relation

        public virtual category Category { get; set; }
        public virtual Brand Brand { get; set; }

    }
}