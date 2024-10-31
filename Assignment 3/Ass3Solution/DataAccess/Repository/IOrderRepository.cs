using BusinessObject.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetList();
        Order GetOrder(int id);
        void InsertOrder(Order prod);
        void UpdateOrder(Order prod);
        void DeleteOrder(int id);
    }
}
