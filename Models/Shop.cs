using System.ComponentModel.DataAnnotations;

namespace inventory_management.Models
{
    public class Shop
    {
        [Key]
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string ShopType { get; set; }
        public string ShopLocation { get; set; }

    }
}
