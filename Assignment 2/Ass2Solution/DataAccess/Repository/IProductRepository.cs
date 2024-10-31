using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<ProductObject> GetProducts();
        IEnumerable<ProductObject> GetProductByName(string name);
        IEnumerable<ProductObject> GetProductByUnitPrice(decimal unitPrice);
        IEnumerable<ProductObject> GetProductByUnitInStock(int unitInStock);
        ProductObject GetProductByID(int productID);
        void AddNewProduct(ProductObject product);
        void RemoveProduct(int productID);
        void UpdateProduct(ProductObject product);
    }
}
