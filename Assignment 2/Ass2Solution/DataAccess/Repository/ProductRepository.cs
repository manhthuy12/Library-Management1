using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<ProductObject> GetProducts() => ProductDAO.Instance.GetProducts();

        public ProductObject GetProductByID(int productID) => ProductDAO.Instance.GetProductByID(productID);

        public IEnumerable<ProductObject> GetProductByName(string name) => ProductDAO.Instance.GetProductByName(name);

        public IEnumerable<ProductObject> GetProductByUnitPrice(decimal unitPrice) => ProductDAO.Instance.GetProductByUnitPrice(unitPrice);

        public IEnumerable<ProductObject> GetProductByUnitInStock(int unitInStock) => ProductDAO.Instance.GetProductByUnitInStock(unitInStock);

        public void AddNewProduct(ProductObject product) => ProductDAO.Instance.AddNewProduct(product);

        public void UpdateProduct(ProductObject product) => ProductDAO.Instance.UpdateProduct(product);

        public void RemoveProduct(int productID) => ProductDAO.Instance.RemoveProduct(productID);
    }
}
