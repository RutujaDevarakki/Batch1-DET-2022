using Batch1_DET_2022;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_DET_2022
{
    internal class TestEmp
    {
        public static void Main()
        {
            Emp e = new Emp(5050, "Rutuja", new DateOnly(2020, 8, 1));
            Console.WriteLine($"Years of Experience{e.GetYearsofExp()}");
        }
    }
}
