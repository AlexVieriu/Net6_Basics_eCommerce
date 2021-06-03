using eShop.CoreBusiness.Models;
using System.Collections.Generic;

namespace eShop.UseCases.SearchProductScreen
{
    public interface ISearchProduct
    {
        List<Product> Execute(string filter = null);
    }
}