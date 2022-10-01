using Shops.Entities;

namespace Shops.Services
{
    public interface IMarketplaceService
    {
        void AddBuyer(string name, decimal money);

        void AddShop(string name, string address, List<ProductTuple> ProductTuples);

        Order MakeOrder(Buyer buyer, Shop shop, Product product, int amount);

        Order MakeOrder(Buyer buyer, Shop shop, Cart cart);
    }
}
