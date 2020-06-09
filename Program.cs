using System;

namespace web_app_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Web-app!");
            Console.WriteLine("Here is change!");
            int a, b;
            Console.WriteLine("enter two values");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the total {2} and {0} is {1} ", a, b, (a+b));
            Console.Read();
        } 

    }
}
