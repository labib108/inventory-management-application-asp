using System.ComponentModel.DataAnnotations;

namespace inventory_management.Models
{
    public class Shop
    {
        [Key]
        public int ShopId { get; set; }

        [Display(Name = "Shop Name")]
        public string ShopName { get; set; }

        [Display(Name = "Shop Type")]
        public string ShopType { get; set; }

        [Display(Name = "Shop Location")]
        public string ShopLocation { get; set; }

    }
}
