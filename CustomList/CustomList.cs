using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
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

        public void Remove(T item)
        {

        }
    }
}
