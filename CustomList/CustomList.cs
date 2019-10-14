using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T>
    {

        //member variables
        private T[] myArray;
        int count;
        int capacity;
        int value;
        GenericComparer<int> comparer;

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }



        public T this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else if (i >= count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    return myArray[i];
                }

            }
            set
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else if (i >= count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    myArray[i] = value;
                }
            }
        }

        //constructor
        public CustomList() {
            this.count = 0;
            this.capacity = 4;
            this.value = 0;
            myArray = new T[capacity];
            comparer = new GenericComparer<int>();
        }



        //member methods
        public void Add(T itemsToAdd)
        {
            if (count == capacity)
            {
                IncreaseArrayCapacity();
            }
            myArray[count] = itemsToAdd;
            count++;
        }

        public void IncreaseArrayCapacity()
        {
            T[] addToArray = new T[capacity * 2];
            for (int i = 0; i < count; i++)
            {
                addToArray[i] = myArray[i];
            }
            capacity *= 2;
            myArray = addToArray;
        }

        public T RemoveAndReplace(T itemsToReplace)
        {
            for (int i = 0; i < count; i++)
            {
                bool compare = Equals(myArray[i], itemsToReplace);
                if (compare)
                {
                    for (int j = i; j < count; j++)
                    {
                        if (j == count - 1)
                        {
                            myArray[j] = default;
                            break;
                        }
                        myArray[j] = myArray[j + 1];
                    }
                    count--;
                    break;
                }
            }
            return itemsToReplace;
        }


        public override string ToString()
        {
            CustomList<T> results = new CustomList<T>();
            return String.Format(results, );
        }

        public CustomList<T> Zip(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> results = new CustomList<T>();
            if (listOne.Count >= listTwo.Count)
            {
                for (int i = 0; i < listOne.Count; i++)
                {
                    results.Add(listOne[i]);
                    for (int j = 0; j < listTwo.Count; j++)
                    {
                        results.Add(listTwo[j]);
                        break;
                    }
                }
                return results;
            }
            else
            {
                for (int i = 0; i < listTwo.Count; i++)
                {
                    results.Add(listTwo[i]);
                    for (int j = 0; j < listOne.Count; j++)
                    {
                        results.Add(listOne[j]);
                        break;
                    }
                }
            }
            return results;
        }


        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> results = new CustomList<T>();
            for (int i = 0; i < listOne.count; i++)
            {
                results.Add(listOne[i]);
            }
            for (int j = 0; j < listTwo.count; j++)
            {
                results.Add(listTwo[j]);
            }
            return results;
        }

        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> results = new CustomList<T>();
            for (int i = 0; i < listOne.count; i++)
            {
                for (int j = 0; j < listTwo.count; j++)
                {
                    if (Comparer.Equals(listOne[i], listTwo[j]))
                    {
                        break;
                    }
                    else if (j == listTwo.count - 1)
                    {
                        results.Add(listOne[i]);
                    }
                }
            }
            return results;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return myArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}


   
