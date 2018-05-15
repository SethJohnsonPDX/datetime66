using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter a number: ");
            double input = Convert.ToDouble(Console.ReadLine());

            DateTime hoursFromEntry = DateTime.Now.AddHours(input);
            Console.WriteLine(hoursFromEntry);
            Console.ReadLine();

        }
    }
}
