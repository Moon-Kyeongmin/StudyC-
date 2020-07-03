using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerType
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte a = sbyte.MinValue;
            //short c = short.MaxValue;
            //ushort d = ushort.MaxValue;

            //long l = long.MaxValue;
            //ulong L = ulong.MaxValue;

            //ulong LL = 2_000_000_000;
            //Console.WriteLine(LL);

            byte a = 240;
            Console.WriteLine($"a = {a}");
            byte b = 0b1111_0000;
            Console.WriteLine($"b = {b}");
        }
    }
}
