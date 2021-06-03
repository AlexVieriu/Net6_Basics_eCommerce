using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using System.Collections.Generic;
using System.Linq;

namespace eShop.UseCases.SearchProductScreen
{
    public class SearchProduct : ISearchProduct
    {
        private readonly IProductRepository _productRepo;

        public SearchProduct(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public List<Product> Execute(string filter)
        {
            return _productRepo.GetProducts(filter).ToList();
        }
    }
}
