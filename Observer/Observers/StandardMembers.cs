using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class StandardMembers:IObserver
    {
        private string memberName;

        public StandardMembers(string name)
        {
            memberName = name;
        }

        public void Update(string update)
        {
            Console.WriteLine($"Standard Member '{memberName}' received protion update: {update}");
        }
    }
}
