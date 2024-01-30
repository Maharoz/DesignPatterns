using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Interface;

namespace Factory.ConcreteProduct
{
    public class RadiologyReport : IReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generatng Radiology Report");
        }
    }
}
