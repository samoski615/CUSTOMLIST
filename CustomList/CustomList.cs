﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {

        //member variables
        private T[] myArray;
        int count;
        int capacity;

        public T this[int i]
        {
            get
            {
                return myArray[i];
            }
            set
            {
                myArray[i] = value;
            }
        }

        //constructor
        public CustomList(){
            this.count = 0;
            this.capacity = 0;
            myArray = new T[capacity];
        } 


        //member methods
        public int Add(T itemsToAdd)
        {

            myArray[count] = itemsToAdd;
            return count;
        }

        public void Remove(T itemsToRemove)
        {

        }

        public void Zip(T itemsToZip)
        {

        }

        public void ToString(T itemsToString)
        {
            
        }

        public void IncreaseArrayCapacity()
        {
            if (count == capacity)
            {
                capacity *= capacity;
            }

            myArray = new T[capacity];

            count++;


        }


        public void Count()
        {

        }
     }

        
}
