using System;
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
            this.capacity = 4;
            myArray = new T[capacity];
        
        } 


        //member methods
        public void Add(T itemsToAdd)
        {
            myArray[count] = itemsToAdd;
            count++;
        }

        public void RemoveAndReplace(T itemsToReplace)
        {
            for (int i = 0; i < count; i++)
            {
                                      
                if (Compare(count, itemsToReplace))
                {
                    myArray[count] = itemsToReplace;
                }

            }

        }

        private bool Compare(int count, T itemsToReplace)
        {
            throw new NotImplementedException();
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
            //need to add a step to add lists together so to not replace populated array with empty one
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
