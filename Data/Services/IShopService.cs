using inventory_management.Models;

namespace inventory_management.Data.Services
{
    public interface IShopService
    {
        IEnumerable<Shop> GetAll();
        Shop GetById(int id);
        void Add (Shop shop);
        void Delete (int id);
    }
}
