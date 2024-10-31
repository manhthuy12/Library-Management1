using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<OrderObject> GetOrders() => OrderDAO.Instance.GetOrders();
        public OrderObject GetOrderByOrderID(int orderID) => OrderDAO.Instance.GetOrderByOrderID(orderID);
        public IEnumerable<OrderObject> GetOrderByMemberID(int memberID) => OrderDAO.Instance.GetOrderByMemberID(memberID);
        public void CreateOrder(OrderObject order) => OrderDAO.Instance.CreateOrder(order);
        public void UpdateOrder(OrderObject order) => OrderDAO.Instance.UpdateOrder(order);
        public void DeleteOrder(int orderID)=> OrderDAO.Instance.DeleteOrder(orderID);
    }
}
