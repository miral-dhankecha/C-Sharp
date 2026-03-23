using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4_1
{
    internal class rectangle
    {
        int l, w, area;

        public void Getdata()
        {
            Console.Write("enter length:  ");
            l = int.Parse(Console.ReadLine());

            Console.Write("enter widhth:  ");
            w = int.Parse(Console.ReadLine());
        }

        public void calculate()
        {
            area = l * w;


        }

        public void Display()
        {
            Console.WriteLine("area:  " + area);
        }
    }
}
