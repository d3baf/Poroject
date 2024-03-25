using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poroject
{
    static class Extension
    {
        public static T[] Print <T>(this T[] array)
        {
            foreach(var item in array)
                Console.WriteLine(item + "\t");
            Console.WriteLine();
            return array;
        }
        public static T Print<T>(this T item)
        {
            Console.WriteLine(item);
            return item;
        }
    }
}
