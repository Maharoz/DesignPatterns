using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Interface;

namespace Factory.AbstractFactory
{
    public abstract class ReportFactory
    {

        public abstract IReport CreateReport();

        public void GenerateAndDisplayReport()
        {
            IReport report = CreateReport();
            report.GenerateReport();
        }
    }
}
