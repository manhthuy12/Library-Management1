using BussinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class OrderDAO : BaseDAL
    {
        private static OrderDAO instance = null!;
        private static readonly object instanceLock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        //---------------
        public IEnumerable<OrderObject> GetOrders()
        {
            IDataReader dataReader = null!;
            string SQLSelect = "Select OrderID, MemberID, OrderDate, RequiredDate, ShippedDate, Freight from [Order]";
            var orders = new List<OrderObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    orders.Add(new OrderObject
                    {
                        OrderID = dataReader.GetInt32(0),
                        MemberID = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetDecimal(5)
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
            return orders;
        }
        //-----------
        public OrderObject GetOrderByOrderID(int orderID)
        {
            OrderObject order = null!;
            IDataReader dataReader = null!;
            string SQLSelect = "Select OrderID, MemberID, OrderDate, RequiredDate, ShippedDate, Freight " + "from [Order] where OrderID = @OrderID";
            try
            {
                var param = dataProvider.CreateParameter("@OrderID", 4, orderID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    order = new OrderObject
                    {
                        OrderID = dataReader.GetInt32(0),
                        MemberID = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetDecimal(5)
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
            return order;
        }
        //-----------------
        public IEnumerable<OrderObject> GetOrderByMemberID(int memberID)
        {
            IDataReader dataReader = null!;
            string SQLSelect = "Select OrderID, MemberID, OrderDate, RequiredDate, ShippedDate, Freight " + "from [Order] where MemberID = @MemberID";
            var orders = new List<OrderObject>();
            try
            {
                var param = dataProvider.CreateParameter("@MemberID", 4, memberID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    orders.Add(new OrderObject
                    {
                        OrderID = dataReader.GetInt32(0),
                        MemberID = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetDecimal(5)
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
            return orders;
        }
        //--------------------
        public void CreateOrder(OrderObject order)
        {
            try
            {
                OrderObject pro = GetOrderByOrderID(order.OrderID);
                if (pro == null)
                {
                    string SQLInsert = "Insert [Order] values(@OrderID, @MemberID, @OrderDate, @RequiredDate, @ShippedDate, @Freight)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderID", 4, order.OrderID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberID", 4, order.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@OrderDate", 50, order.OrderDate!, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@RequiredDate", 50, order.RequiredDate!, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@ShippedDate", 50, order.ShippedDate!, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@Freight", 10, order.Freight!, DbType.Decimal));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order is already exist.");
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
        //-----------------
        public void UpdateOrder(OrderObject order)
        {
            try
            {
                OrderObject pro = GetOrderByOrderID(order.OrderID);
                if (pro != null)
                {
                    string SQLUpdate = "Update [Order] set MemberID = @MemberID, OrderDate = @OrderDate, RequiredDate = @RequiredDate, ShippedDate =@ShippedDate, Freight = @Freight where OrderID = @OrderID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderID", 4, order.OrderID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberID", 4, order.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@OrderDate", 50, order.OrderDate!, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@RequiredDate", 50, order.RequiredDate!, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@ShippedDate", 50, order.ShippedDate!, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@Freight", 10, order.Freight!, DbType.Decimal));
                    dataProvider.Insert(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order does not already exist.");
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
        //---------------
        public void DeleteOrder(int orderID)
        {
            try
            {
                OrderObject pro = GetOrderByOrderID(orderID);
                if (pro != null)
                {
                    string SQLDelete = "Delete [Order] where OrderID = @OrderID";
                    var param = dataProvider.CreateParameter("@OrderID", 4, orderID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The order does not already exist.");
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
