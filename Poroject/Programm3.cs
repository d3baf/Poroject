using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poroject
{
    static class Programm3
    {
        public static void main()
        {
            int[] arr = new int[10]
                    .Select(x => new Random().Next(100)).ToArray().Print();
            arr[0..3].Concat(new int[] { 0 }).Concat(arr[3..^0]).ToArray().Print();
            arr[0..5].Concat(new int[] { 1,2,3 }).Concat(arr[5..^0]).ToArray().Print();
        }
    }
}
