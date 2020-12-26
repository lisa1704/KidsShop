using KidsShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsShop.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProductList();
        void AddProduct(Product Product);
        void RemoveProduct(Guid Product);
        void UpdateProduct(Product Product);//
        void Save();
    }
}
