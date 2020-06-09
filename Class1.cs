using System;
using System.Collections.Generic;
using System.Text;

namespace web_app_2
{
    class ReadExe
    {
        private static void Main()
        {
            
            int a, b, c, d, e=10;
            Console.WriteLine("Enter the three numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = a > b ? a > c ? a : c : b > c ? b : c;
            Console.WriteLine("highest value is " + d);
            Console.WriteLine(a>b);
            e += a;
            Console.WriteLine(e);
        }
        

    }
}
