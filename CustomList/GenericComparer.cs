using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class GenericComparer<T>
    {
        //member variables
        T value;

        //constructor

        //member methods
        public bool Compare(T value1, T value2)
        {
            if (value1.Equals(value2))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
