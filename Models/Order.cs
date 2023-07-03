using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inventory_management.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Prodect Id")]
        [ForeignKey("Product")]
        public int ProdectId { get; set; }
        public Product Product { get; set; }

        [Display(Name = "Customer Id")]
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Display(Name = "Shop Id")]
        [ForeignKey("Shop")]
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
