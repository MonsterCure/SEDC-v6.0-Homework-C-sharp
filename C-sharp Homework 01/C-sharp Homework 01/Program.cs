using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of rows:");
            var NumberOfRows = Convert.ToInt32(Console.ReadLine());
            string StarLightsOn = "*";
            string StarLightsOff = "*";
            string Space = "";

            /*public string Repeat(string value, int count)
            {
                return new StringBuilder(value.Length * count).Insert(0, value, count).ToString();
            }*/

            do
            {
                for (int i = 0; i < NumberOfRows; i++)
                {
                    int NumberOfSpaces = NumberOfRows - i - 1;
                    /*Space = string.Concat(Enumerable.Repeat(" ", NumberOfSpaces));*/
                    Space = new String(' ', NumberOfSpaces);

                    Console.WriteLine(Space + StarLightsOn);
                    StarLightsOn = StarLightsOn + "0" + "*";
                }

                for (int i = 0; i < 3; i++)
                {
                    int NumberOfSpaces = NumberOfRows - 2;
                    Space = new String(' ', NumberOfSpaces);
                    Console.WriteLine(Space + "***");
                }

                System.Threading.Thread.Sleep(500);
                Console.Clear();

                for (int i = 0; i < NumberOfRows; i++)
                {
                    int NumberOfSpaces = NumberOfRows - i - 1;
                    /*Space = string.Concat(Enumerable.Repeat(" ", NumberOfSpaces));*/
                    Space = new String(' ', NumberOfSpaces);

                    Console.WriteLine(Space + StarLightsOff);
                    StarLightsOff = StarLightsOff + "|" + "*";
                }

                for (int i = 0; i < 3; i++)
                {
                    int NumberOfSpaces = NumberOfRows - 2;
                    Space = new String(' ', NumberOfSpaces);
                    Console.WriteLine(Space + "***");
                }

                System.Threading.Thread.Sleep(500);
                Console.Clear();

                StarLightsOn = "*";
                StarLightsOff = "*";
            } while (Console.KeyAvailable == false);
        }
    }
}
