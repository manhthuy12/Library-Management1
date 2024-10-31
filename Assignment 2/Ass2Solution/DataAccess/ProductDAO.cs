using BussinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO : BaseDAL
    {
        private static ProductDAO instance = null!;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        //---------------
        public IEnumerable<ProductObject> GetProducts()
        {
            IDataReader dataReader = null!;
            string SQLSelect = "Select ProductID, CategoryID, ProductName, Weight, UnitPrice, UnitInStock from Product";
            var products = new List<ProductObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductID= dataReader.GetInt32(0),
                        CategoryID = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitInStock = dataReader.GetInt32(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return products;
        }
        //-----------------
        public IEnumerable<ProductObject> GetProductByName(string productName)
        {
            IDataReader dataReader = null!;
            string SQLSelect = "Select ProductID, CategoryID, ProductName, Weight, UnitPrice, UnitInStock " + "from Product where ProductName like @ProductName";
            var products = new List<ProductObject>();
            try
            {
                var param = dataProvider.CreateParameter("@ProductName", 40, "%" + productName + "%", DbType.String);
                //var param = new SqlParameter("@ProductName", SqlDbType.VarChar) { Value = "%" + name + "%" };
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductID = dataReader.GetInt32(0),
                        CategoryID = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitInStock = dataReader.GetInt32(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return products;
        }
        //--------------
        public IEnumerable<ProductObject> GetProductByUnitPrice(decimal unitPrice)
        {
            IDataReader dataReader = null!;
            string SQLSelect = "Select ProductID, CategoryID, ProductName, Weight, UnitPrice, UnitInStock " + "from Product where UnitPrice =  @UnitPrice";
            var products = new List<ProductObject>();
            try
            {
                var param = dataProvider.CreateParameter("@UnitPrice", 10, unitPrice, DbType.Decimal);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductID = dataReader.GetInt32(0),
                        CategoryID = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitInStock = dataReader.GetInt32(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return products;
        }
        //--------------
        public IEnumerable<ProductObject> GetProductByUnitInStock(int unitInStock)
        {
            IDataReader dataReader = null!;
            var products = new List<ProductObject>();
            string SQLSelect = "Select ProductID, CategoryID, ProductName, Weight, UnitPrice, UnitInStock " + "from Product where UnitInStock =  @UnitInStock";
            
            try
            {
                var param = dataProvider.CreateParameter("@UnitInStock", 10, unitInStock, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductID = dataReader.GetInt32(0),
                        CategoryID = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitInStock = dataReader.GetInt32(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return products;
        }
        //-----------------
        public ProductObject GetProductByID(int productID)
        {
            ProductObject product = null!;
            IDataReader dataReader = null!;
            string SQLSelect = "Select ProductID, CategoryID, ProductName, Weight, UnitPrice, UnitInStock " + "from Product where ProductID = @ProductID";
            try
            {
                var param = dataProvider.CreateParameter("@ProductID", 4, productID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    product = new ProductObject
                    {
                        ProductID = dataReader.GetInt32(0),
                        CategoryID = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitInStock = dataReader.GetInt32(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader?.Close();
                CloseConnection();
            }
            return product;
        }
        //-------------
        public void AddNewProduct(ProductObject product)
        {
            try
            {
                ProductObject pro = GetProductByID(product.ProductID);
                if (pro == null)
                {
                    string SQLInsert = "Insert Product values(@ProductID, @CategoryID, @ProductName, @Weight, @UnitPrice, @UnitInStock)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@ProductID", 4, product.ProductID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CategoryID", 4, product.CategoryID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductName", 40, product.ProductName!, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Weight", 20, product.Weight!, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 10, product.UnitPrice, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@UnitInStock", 10, product.UnitInStock, DbType.Int32));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The product is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        //----------------------
        public void UpdateProduct(ProductObject product)
        {
            try
            {
                ProductObject pro = GetProductByID(product.ProductID);
                if (pro != null)
                {
                    string SQLUpdate = "Update Product set CategoryID = @CategoryID, ProductName = @ProductName, Weight =@Weight, UnitPrice = @UnitPrice, UnitInStock = @UnitInStock where ProductID = @ProductID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@ProductID", 4, product.ProductID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CategoryID", 4, product.CategoryID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductName", 40, product.ProductName!, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Weight", 20, product.Weight!, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 10, product.UnitPrice, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@UnitInStock", 10, product.UnitInStock, DbType.Int32));
                    dataProvider.Insert(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The product does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        //---------
        public void RemoveProduct(int productID)
        {
            try
            {
                ProductObject pro = GetProductByID(productID);
                if (pro != null)
                {
                    string SQLDelete = "Delete Product where ProductID = @ProductID";
                    var param = dataProvider.CreateParameter("@ProductID", 4, productID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The product does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }//End Remove f
    }
}
