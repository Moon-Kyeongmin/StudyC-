using System;

namespace StringNumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12345;
            string b = a.ToString();
            Console.WriteLine($"b = {b}");
            float c = 3.141592f;
            string d = c.ToString();
            Console.WriteLine(d);

            string e = "123456*";
            int f; 
            
            if(int.TryParse(e, out f))
            {
                Console.WriteLine(f);
            }
            else
            {
                Console.WriteLine("에러남");
            }
        }
    }
}
