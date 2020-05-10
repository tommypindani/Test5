using System;

namespace Test5
{
    class add
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter 1st num= ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd num= ");
            b = int.Parse(Console.ReadLine());

            int result = a - b;

           if (a < 5)

            {
                Console.WriteLine(" 1st num is invalid");
            }
           if (b != 5)
            {
                Console.WriteLine("2nd num is invalid");
            }
            Console.WriteLine("Subtraction is: " + result);
            Console.ReadKey();
        }
    }
}
