using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> numbers = new CustomList<int>();


            numbers.Add(5);

            //hover over variables/objects while debugging to check out their values
            Console.ReadLine();
        }

    }
}
