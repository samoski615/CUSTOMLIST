using System;
using System.Collections;
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
        int value;
        GenericComparer<int> comparer;

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
            this.capacity = 4;
            this.value = 0;
            myArray = new T[capacity];
            comparer = new GenericComparer<int>();
        }

       

        //member methods
        public void Add(T itemsToAdd)
        {
            myArray[count] = itemsToAdd;
            count++;
        }

        public T RemoveAndReplace(T itemsToReplace)
        {
            //GenericComparer<int> comparer = new GenericComparer<int>();
            for (int i = 0; i < myArray.Length; i++)
            {
                if (comparer.Compare(count, myArray.Length)) ;
            }
            return itemsToReplace;
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

       

       

       
        //public void Remove(T itemsToRemove)
        //{
        //    myArray[count - 1] = itemsToRemove;

        //}


    }


        
}
