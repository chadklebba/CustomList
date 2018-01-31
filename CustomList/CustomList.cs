using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T>
    {
        public int count;
        public T[] array;
        public int capacity;
        public T[] newarray;
        public CustomList()
        {
            capacity = 1;
            count = 0;
            array = new T[capacity]; 
        }
        public void Add(T item)
        {
            capacity = capacity + 1;
            newarray = new T[capacity];
            count++;    
            for (int i = 0; i <= count-1; i++)
                {
                    newarray[i] = array[i];
                }
                array = newarray;
                array[count -1] = item;
                     
                
        }
        public int Count
        {
            get
            {
                return count;
            }
            
            
        }

        public bool Remove(T item)
        {
            bool removed = false;
            int index = 0;
            try
            {
                for(int i = 0; i < count; i++)
                {
                    if (array[i].Equals(item))
                    {
                        index = i;
                        removed = true;
                    }
                }
                
            }
            catch
            {
                removed = false;
                return removed;
            }
            capacity = capacity - 1;
            newarray = new T[capacity];
            count--;

            for(int i = index; i <= count; i++)
            {
                array[i] = array[i + 1];
            }          
            for (int j = 0; j < count; j++)
            {
                newarray[j] = array[j];
            }
            array = newarray;
            return removed;
        }
        public static CustomList<T> Zip(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> result = new CustomList<T>();
            result.array = new T[listOne.count + listTwo.count];
            int j = 0;
            for (int i = 0; i < listOne.count; i++)
            {
                result.array[j] = listOne.array[i];
                j++;
                result.array[j] = listTwo.array[i];
                j++;

            }
            
            return result;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            string endString = "";
            foreach(T item in this)
            {
                endString = endString + item;
            }
            return endString;
        }

        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> result = new CustomList<T>();
            result.array = new T[listOne.count + listTwo.count];
            for (int i = 0; i < listOne.count; i++)
            {
                result.Add(listOne.array[i]);
            }
            for (int i = 0; i < listTwo.count; i++)
            {
                result.Add(listTwo.array[i]);
            }

            return result;
        }

        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> result = new CustomList<T>();
            bool res = false;
            result.array = new T[listOne.count - listTwo.count];
            for(int i = 0; i < listOne.count; i++)
            {
                for(int j = 0; j <listTwo.count; j++)
                {
                    if (listOne.array[i].Equals(listTwo.array[j]))
                    {
                        res = false;
                        break;
                    }
                    else
                    {
                        res = true;
                    }
                    if (res == true)
                    {
                        result.Add(listOne.array[i]);
                    }
                }
                
            }
            return result;
        }
        }
    }

