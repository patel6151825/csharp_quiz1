using System;
using System.Collections.Generic;
using System.Text;

namespace payal_csharp_quiz1
{
    class MyGenericClass<G> where G:class
    {

        public static void PrintValue(G value)
        {
            Console.WriteLine(value);
        }
    }
}
