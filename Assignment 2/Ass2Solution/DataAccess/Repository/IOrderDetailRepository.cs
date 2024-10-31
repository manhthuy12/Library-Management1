using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetailObject> GetOrderDetailByOrderID(int id);
        void AddOrderDetails(OrderDetailObject orderDetail);
        void UpdateOrderDetails(OrderDetailObject orderDetail);
        void DeleteOrderDetailsByOrderID(int orderID);
        OrderDetailObject GetOrderDetailByOIDAndPID(int oid, int pid);
        void DeleteOrderDetailsByOIDAndPID(int oid, int pid);
    }
}
