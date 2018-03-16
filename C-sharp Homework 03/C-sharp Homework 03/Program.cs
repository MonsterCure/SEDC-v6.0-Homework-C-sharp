using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a homework number:");
            Console.WriteLine("1. Math.Ceiling implementation");
            Console.WriteLine("2. Input a string and print it");
            Console.WriteLine("3. Multiplication Table");
            Console.WriteLine("4. Sum of first 500 prime numbers");
            Console.WriteLine("5. All of them, one by one");
            int homeworkNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------");

            switch (homeworkNumber)
            {
                case 1:
                    HowManyBaskets();
                    break;
                case 2:
                    InputStringAndPrint();
                    break;
                case 3:
                    MultiplicationTable();
                    break;
                case 4:
                    SumOfFirst500PrimeNumbers();
                    break;
                case 5:
                    HowManyBaskets();
                    Console.WriteLine("---------------------------------------------------------------");
                    InputStringAndPrint();
                    Console.WriteLine("---------------------------------------------------------------");
                    MultiplicationTable();
                    Console.WriteLine("---------------------------------------------------------------");
                    SumOfFirst500PrimeNumbers();
                    Console.WriteLine("---------------------------------------------------------------");
                    break;
                default:
                    Console.WriteLine("Please input either 1, 2, 3, 4 or 5.");
                    break;
            }
        }

        static double HowManyBaskets()   // an implementation of the Math.Ceiling method
        {
            Console.WriteLine("How many apples are there on the tree?");
            int applesOnTree = int.Parse(Console.ReadLine());
            Console.WriteLine("How many apples can one basket hold?");
            int applesInBasket = int.Parse(Console.ReadLine());

            int numberOfBaskets = applesOnTree / applesInBasket;

            if (applesOnTree % applesInBasket > 0)
            {
                numberOfBaskets++;
            }

            Console.WriteLine($"It takes {numberOfBaskets} baskets to collect the apples from the tree.");
            return numberOfBaskets;
        }

        static void InputStringAndPrint()
        {
            Console.WriteLine("Tell me your favorite book...");
            string inputString = Console.ReadLine();

            Console.WriteLine($"Your favorite book is \"{inputString}\".");
        }

        static void MultiplicationTable()
        {
            Console.WriteLine("Input a number to get its multiplication table.");
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                int result = inputNumber * i;
                Console.WriteLine($"{inputNumber} * {i} = {result}");
            }
        }

        static int SumOfFirst500PrimeNumbers()
        {
            int anyNumber = 1;
            int counter = 0;
            int sum = 0;

            while (counter < 500)
            {
                if (IsPrime(anyNumber))
                {
                    sum += anyNumber;
                    counter++;
                }
                anyNumber++;
            }

            Console.WriteLine($"The sum of the first 500 prime numbers is {sum}.");
            return sum;
        }

        static bool IsPrime(int checkedNumber)
        {
            if (checkedNumber == 1)
            {
                return false;
            }
            else if (checkedNumber == 2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(checkedNumber); i++)
                {
                    if (checkedNumber % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}