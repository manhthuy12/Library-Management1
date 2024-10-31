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
    public class OrderDetailDAO : BaseDAL
    {
        private static OrderDetailDAO instance = null!;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }
        //---------------
        public OrderDetailObject GetOrderDetailByOIDAndPID(int orderID, int productID)
        {
            OrderDetailObject orderDetail = null!;
            IDataReader dataReader = null!;
            string SQLSelect = "Select OrderID, ProductID, UnitPrice, Quantity, Discount " + "from [OrderDetail] where OrderID = @OrderID and ProductID = @ProductID";
            try
            {
                var param1 = dataProvider.CreateParameter("@OrderID", 4, orderID, DbType.Int32);
                var param2 = dataProvider.CreateParameter("@ProductID", 4, productID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection,param1,param2);
                if (dataReader.Read())
                {
                    orderDetail = new OrderDetailObject
                    {
                        OrderID = dataReader.GetInt32(0),
                        ProductID = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetDecimal(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = (float)dataReader.GetDouble(4)
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
            return orderDetail;
        }
        //----------------
        public IEnumerable<OrderDetailObject> GetOrderDetailByOrderID(int orderID)
        {
            IDataReader dataReader = null!;
            string SQLSelect = "Select OrderID, ProductID, UnitPrice, Quantity, Discount " + "from OrderDetail where OrderID = @OrderID";
            var orderdetails = new List<OrderDetailObject>();
            try
            {
                var param = dataProvider.CreateParameter("@OrderID", 4, orderID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    orderdetails.Add(new OrderDetailObject
                    {
                        OrderID = dataReader.GetInt32(0),
                        ProductID = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetDecimal(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = (float)dataReader.GetDouble(4)
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
            return orderdetails;
        }
        //--------------
        public void AddOrderDetails(OrderDetailObject orderDetail)
        {
            try
            {
                OrderDetailObject pro = GetOrderDetailByOIDAndPID(orderDetail.OrderID, orderDetail.ProductID);
                if (pro == null)
                {
                    string SQLInsert = "Insert OrderDetail values(@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderID", 4, orderDetail.OrderID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductID", 4, orderDetail.ProductID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 50, orderDetail.UnitPrice!, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@Quantity", 50, orderDetail.Quantity!, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Discount", 50, orderDetail.Discount!, DbType.Double));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order detail is already exist.");
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
        //-------------------
        public void UpdateOrderDetails(OrderDetailObject orderDetail)
        {
            try
            {
                OrderDetailObject pro = GetOrderDetailByOIDAndPID(orderDetail.OrderID, orderDetail.ProductID);
                if (pro != null)
                {
                    string SQLInsert = "Update OrderDetail set UnitPrice = @UnitPrice, Quantity = @Quantity, Discount = @Discount where OrderID = @OrderID and ProductID = @ProductID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderID", 4, orderDetail.OrderID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductID", 4, orderDetail.ProductID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 10, orderDetail.UnitPrice!, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@Quantity", 6, orderDetail.Quantity!, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Discount", 6, orderDetail.Discount!, DbType.Double));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order detail does not already exist.");
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
        public void DeleteOrderDetailsByOrderID(int orderID)
        {
            try
            {
                IEnumerable<OrderDetailObject> pro = GetOrderDetailByOrderID(orderID);
                if (pro.Any())
                {
                    string SQLDelete = "Delete OrderDetail where OrderID = @OrderID";
                    var param = dataProvider.CreateParameter("@OrderID", 4, orderID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    //throw new Exception("The order does not have any details.");
                    return;
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
        public void DeleteOrderDetailsByOIDAndPID(int oID, int pID)
        {
            try
            {
                OrderDetailObject pro = GetOrderDetailByOIDAndPID(oID, pID);
                if (pro != null)
                {
                    string SQLDelete = "Delete OrderDetail where OrderID = @OrderID and ProductID = @ProductID";
                    var param1 = dataProvider.CreateParameter("@OrderID", 4, oID, DbType.Int32);
                    var param2 = dataProvider.CreateParameter("@ProductID", 4, pID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param1, param2);
                }
                else
                {
                    throw new Exception("The order detail not found.");
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
    }
}
