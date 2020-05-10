using System;

namespace Test5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Number 1");

            int num1;
            bool flag = false;
            flag = int.TryParse(Console.ReadLine(), out num1);

            if (flag == false)
            {
                Console.WriteLine("Number 1  is a invalid number");
                return;

            }
            flag = false;
            int a = num1;

            int num2;
            Console.WriteLine("Please enter Number 2");
            flag = int.TryParse(Console.ReadLine(), out num2);

            if (flag == false)
            {
                Console.WriteLine("Number 2  is a invalid number");
                return;
            }
            int b = num2;

            if (num1 < num2)
            {
                a = num2;
                b = num1;
            }



            int result = 0;

            while (b != 0)
            {
                result = result + a;
                b--;

            }

            Console.WriteLine("multiplication of {0} and {1}  is  {2}", num1, num2, result);
        }

    }
}
