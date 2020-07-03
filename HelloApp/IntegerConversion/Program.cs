using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = sbyte.MaxValue;
            Console.WriteLine(a);//128
            int b = a;
            Console.WriteLine(b);//128
            int x = 128;
            Console.WriteLine(x);//128
            sbyte y = (sbyte)x;
            Console.WriteLine(y);//-128
        }
    }
}
