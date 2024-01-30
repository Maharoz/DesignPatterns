using Factory.AbstractFactory;
using Factory.ConcreteCreator;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReportFactory labreport = new LabReportGenerator();
            labreport.GenerateAndDisplayReport();
        }
    }
}
