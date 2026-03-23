using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle r = new rectangle();

            r.Getdata();
            r.calculate();
            r.Display();

            area c = new area();

            c.Getdata1();
            c.calculate1();
            c.Display1();

        }
    }
}
