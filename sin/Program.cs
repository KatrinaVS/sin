using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sin
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 0, step = 0.1, x = -1; // ограничения функции

            while (x <= 1)
            {
                y = Math.Sin((x+2)*(x+2));
                Console.WriteLine("x: {0} \t y: {1}", x, y);
                x = x + step; //  прибавление шага
            }

            Console.ReadKey();
        }
    }
}
