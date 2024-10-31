using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<OrderObject> GetOrders();
        OrderObject GetOrderByOrderID(int orderID);
        IEnumerable<OrderObject> GetOrderByMemberID(int memberID);
        void CreateOrder(OrderObject order);
        void UpdateOrder(OrderObject order);
        void DeleteOrder(int orderID);
    }
}
