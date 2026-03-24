using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4_22
{
    internal class Vahicle
    {
        string vahicle_type;
        public void get_data()
        {
            Console.WriteLine(" Enter Vahicale Type :  ");
            vahicle_type = Console.ReadLine();
        }
        public void show_vahicle()
        {
            Console.WriteLine("WriteLine Type" + vahicle_type);
        }
    }
}
