using Command.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Invoker
{
    public class Waiter
    {
        private List<ICommand> orders = new();
        public void PlaceOrder(ICommand command)
        {
            orders.Add(command);
        }
        public void SaveOrders()
        {
            foreach(var order in orders)
            {
                order.Execute();
            }
            orders.Clear();
        }
    }
}
