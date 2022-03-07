using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10956029
{
    class Program
    {
        static void Main(string[] args)
        {

            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;
            int toto;


            toto = (int)(meal_cost + tip_percent + tax_percent);

            Console.WriteLine("總額:"+toto);
        }
    }
}
