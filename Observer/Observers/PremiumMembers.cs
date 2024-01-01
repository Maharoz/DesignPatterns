using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class PremiumMembers: IObserver
    {
        private string memberName;

        public PremiumMembers(string name)
        {
            memberName = name;
        }

        public void Update(string update)
        {
            Console.WriteLine($"Premium Member '{memberName}' received protion update: {update}");
        }
    }
}
