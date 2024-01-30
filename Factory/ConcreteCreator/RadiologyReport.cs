using Factory.AbstractFactory;
using Factory.ConcreteProduct;
using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.ConcreteCreator
{
    public class RadiologyReportGenerator:ReportFactory
    {
        public override IReport CreateReport()
        {
            return new RadiologyReport();
        }
    }
}
