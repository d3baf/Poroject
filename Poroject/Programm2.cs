using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poroject
{
    static class Programm2
    {
        public static void main()
        {
            int[] arr = new int[15]
                    .Select(x => new Random().Next(-10, 10)).ToArray().Print();
            arr = arr.Select(x => x < 0 ? -x : x).ToArray();
            arr = arr.Where(x => x !=0).ToArray().Print();
            arr = arr.Where(x => x %2 == 0).ToArray().Print();
            


        } 
    }
}
