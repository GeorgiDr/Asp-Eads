using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eads.Web.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public int ProductID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string ProductName { get; set; }

        public string Description { get; set; }

        public byte[] Image { get; set; }

        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }

        [Required, StringLength(100), Display(Name = "Seller")]
        public string Seller { get; set; }

        public DateTime Date { get; set; }

        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public int? SubcategoryID { get; set; }
        public virtual Subcategory Subcategory { get; set; }
    }
}
