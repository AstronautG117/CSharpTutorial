using System;

namespace FirstSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }


        static void function1()
        {
            int number = 2;

            Console.WriteLine("The number is: " + number);

            Console.WriteLine("Enter a number:");

            string input = Console.ReadLine();

            int inputInt = Int32.Parse(input);

            int answer = (number + inputInt);

            Console.WriteLine("The answer is" + " " + answer);
            Console.ReadLine();
        }

        static void function2()
        {
            string input1;
            string input2;
            
            Console.WriteLine("Pick a number");
            input1 = Console.ReadLine();

            Console.WriteLine("Pick another number");
            input2 = Console.ReadLine();

            int input1int = Int32.Parse(input1);
            int input2int = Int32.Parse(input2);

            Console.WriteLine("The sum is..." + (input1int + input2int));
            Console.ReadLine();
        }
    }
}
