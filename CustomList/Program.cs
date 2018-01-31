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
            CustomList<int> foo = new CustomList<int>();
            foo.Add(5);
            foo.Add(6);
            foo.Add(7);
            foreach(var number in foo)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();

        }
    }
}
