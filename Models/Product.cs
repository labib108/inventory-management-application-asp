using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inventory_management.Models
{
    public class Product
    {
        [Key]
        public int ProdectId { get; set; }

        [Display(Name = "Prodect Name")]
        public string ProductName { get; set; }

        [Display(Name = "Prodect Description")]
        public string ProductDescription { get; set; }

        [Display(Name = "Prodect Price")]
        public double Price { get; set; }

        [Display(Name = "Prodect Image")]
        public string Image { get; set; }

    }
}
