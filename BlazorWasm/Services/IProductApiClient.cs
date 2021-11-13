using AppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasm.Services
{
   public interface IProductApiClient
    {
        Task<List<Product>> GetProducts(string search = null);
        Task<List<Category>> GetCategories();
        Task<Product> GetProduct(int Id);
        Task<bool> AddProduct(Product Product);
        Task<bool> UpdateProduct(Product Product);
        Task<bool> DeleteProduct(int Id);
        Task<List<Product>> GetProductsByCategoryId(int categoryId);
        Task<Category> GetCategoryById(int Id);

    }
}
