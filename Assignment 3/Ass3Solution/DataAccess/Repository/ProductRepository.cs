using BusinessObject.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetList() => ProductDAO.GetInstance.GetAll();
        public Product GetProduct(int id) => ProductDAO.GetInstance.GetById(id);
        public void InsertProduct(Product prod) => ProductDAO.GetInstance.Insert(prod);
        public void UpdateProduct(Product prod) => ProductDAO.GetInstance.Update(prod);
        public void DeleteProduct(int id) => ProductDAO.GetInstance.Delete(id);
        public IEnumerable<Product> GetByName(string name) => ProductDAO.GetInstance.GetByName(name);
    }
}
