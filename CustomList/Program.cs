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

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            
            numbers.IncreaseArrayCapacity();
            numbers.Add(5);
            numbers.RemoveAndReplace(7);
            //numbers.Remove(7);

        }

    }
}
