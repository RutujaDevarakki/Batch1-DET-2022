using Batch1_DET_2022;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestCircle
    {
        public static void Main()
        {
            //classname objectname = new classname()
            Circle c = new Circle(8);
            //objectname.methodname()
            double result = c.area();
            Console.WriteLine($"Area of the circle{result}");
        }

    }
}
