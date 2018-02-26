using System;

namespace LessonPlan
{
    public class Lesson2
    {
        public static void main1()
        {
            int number = getNumberFromUser();
            Console.WriteLine("The number is: " + number);
        }

        public static void main2() {
            int num1 = getNumberFromUser();
            int num2 = getNumberFromUser();

            Console.WriteLine("The first number is: " + num1);
            Console.WriteLine("The second number is: " + num2);

            int sum = num1 + num2;

            Console.WriteLine("The sum is: " + sum);
        }

        public static void main3() {
            Random random = new Random();
            int firstNum = random.Next(-100, 100);
            int secondNum = random.Next(-100, 100);

            Console.WriteLine("The first number is: {0}", firstNum);
            Console.WriteLine("The second number is: {0}", secondNum);

            if (firstNum > secondNum) {
                Console.WriteLine("First is bigger.");
            }
            else if (secondNum > firstNum) {
                Console.WriteLine("Second is bigger.");
            }
            else {
                Console.WriteLine("They are equal.");
            }
        }

        public static void main4() {
            int num1 = getNumberFromUser();
            int num2 = getNumberFromUser();
            int num3 = getNumberFromUser();
            int num4 = getNumberFromUser();

            //Number tournament

        }

        public static int getNumberFromUser() {
            Console.WriteLine("Enter a number: ");
            string inputString = Console.ReadLine();
            int inputInt = Int32.Parse(inputString);
            return inputInt;
        }
    }
}
