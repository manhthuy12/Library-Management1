using BusinessObject.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetList();
        Product GetProduct(int id);
        IEnumerable<Product> GetByName(string name);
        void InsertProduct(Product prod);
        void UpdateProduct(Product prod);
        void DeleteProduct(int id);
    }
}
