using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Poroject
{
    static class String1
    {
        public static void main()
        {
            string word = "Hello world";
            word.Print();
            word.ToUpper().Print();
            word.ToLower().Print();
            if (word.ToUpper() == "hello world".ToUpper())
                true.Print();
            else
            false.Print();
            string word1 = "!!!";
            int x = 5;
            string word2 = $"{word} {word1} = {x}";
            word2.Print();
            int index = word.IndexOf("!!!")+3;
            word.Insert(index, "everyone");

        }
    }
}
