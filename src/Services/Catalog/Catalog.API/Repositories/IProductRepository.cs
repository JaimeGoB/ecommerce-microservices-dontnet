using Catalog.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Repositories
{
    public interface IProductRepository
    {
        /*GET*/
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(string id);
        Task<IEnumerable<Product>> GetProductByName(string name);
        Task<IEnumerable<Product>> GetProductByCategory(string categoryName);
        
        /*POST*/
        Task CreateProduct(Product product);
        
        /*PUT*/
        Task<bool> UpdateProduct(Product product);

        /*DELETE */
        Task<bool> DeleteProduct(string id);
    }
}