using System.ComponentModel.DataAnnotations.Schema;

namespace inventory_management.Models
{
    public class Order
    {
        public DateTime OrderDate { get; set; }

        [ForeignKey("Product")]
        public int ProdectId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Shop")]
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
