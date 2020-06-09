using System;
using System.Collections.Generic;
using System.Text;

namespace web_app_2
{
    class stringRead
    {
        static void main()
        {
            string name, age;
            Console.WriteLine("Enter your name and age");
            name = Console.ReadLine();
            age = Console.ReadLine();
            Console.WriteLine("Hello My name is " + name + age);
            
        }
    }
}
