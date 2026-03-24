using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4_22
{
    internal class Carcs:Vahicle
    {
        string model_type, company_name;
        public void get_car()
        {
            Console.WriteLine("Enter Model Type");
            model_type = Console.ReadLine();

            Console.WriteLine("Enter company Name ");
            company_name = Console.ReadLine();
        }
        public void show_car()
        {
            Console.WriteLine("Model Type " + model_type);
            Console.WriteLine("Company Name " + company_name);
        }
    }
}
