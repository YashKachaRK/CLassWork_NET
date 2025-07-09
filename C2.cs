using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLassWork
{
    internal class C2
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int res = a++ + ++b + ++b + ++a + ++a;
            Console.WriteLine(res);
        }
    }
}
