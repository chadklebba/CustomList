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
            bool removed;
            int index;
            try
            {
                index = Array.IndexOf(array, item);
                removed = true;
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

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
