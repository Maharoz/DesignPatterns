using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receiver
{
    public class KitchenStaff
    {
        public void PrepareDish(string dishName)
        {
            Console.WriteLine($"Preparing dish {dishName}");
        }
    }
}
