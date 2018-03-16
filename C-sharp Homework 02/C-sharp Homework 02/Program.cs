using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Homework_02
{
    class Program
    {
        static void Man()
        {
            Console.WriteLine("    *");
            Console.WriteLine("  *   *");
            Console.WriteLine("    *");
            Console.WriteLine("    *");
            Console.WriteLine("  * * *");
            Console.WriteLine(" *  *  *");
            Console.WriteLine("    *");
            Console.WriteLine("    *");
            Console.WriteLine("   * *");
            Console.WriteLine("  *   *");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }

        static void JumpingMan()
        {
            Console.WriteLine("    *");
            Console.WriteLine("  *   *");
            Console.WriteLine("*   *   *");
            Console.WriteLine("  * * *");
            Console.WriteLine("    *");
            Console.WriteLine("    *");
            Console.WriteLine("    *");
            Console.WriteLine("    *");
            Console.WriteLine("   * *");
            Console.WriteLine("  *   *");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }

        static void Main(string[] args)
        {          
            do
            {
                Man();

                System.Threading.Thread.Sleep(500);
                Console.Clear();

                JumpingMan();

                System.Threading.Thread.Sleep(500);
                Console.Clear();

            } while (Console.KeyAvailable == false);
        }
    }
}
