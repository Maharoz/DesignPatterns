using Command.Interface;
using Command.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command
{
    public class OrderCommand:ICommand
    {

        private KitchenStaff kitchenStaff;
        private string dishName;

        public OrderCommand(KitchenStaff kitchen, string dish)
        {
            kitchenStaff=kitchen;
            dishName=dish;
        }
        public void Execute()
        {
            kitchenStaff.PrepareDish(dishName);
        }

    }
}
