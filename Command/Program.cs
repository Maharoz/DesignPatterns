using Command.Command;
using Command.Interface;
using Command.Invoker;
using Command.Receiver;


namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KitchenStaff kitchenStaff = new KitchenStaff();
            Waiter waiter = new Waiter();
            ICommand order1 = new OrderCommand(kitchenStaff, "test");
            waiter.PlaceOrder(order1);

        }
    }
}
