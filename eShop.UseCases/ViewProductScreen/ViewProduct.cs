using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;

namespace eShop.UseCases.ViewProductScreen
{
    public class ViewProduct : IViewProduct
    {
        private readonly IProductRepository _productRepo;

        public ViewProduct(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public Product Execute(int id)
        {
            return _productRepo.GetProductbyId(id);
        }
    }
}
