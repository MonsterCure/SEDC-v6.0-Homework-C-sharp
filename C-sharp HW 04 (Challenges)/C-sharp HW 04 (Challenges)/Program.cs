using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_HW_04__Challenges_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a challenge number:");
            Console.WriteLine("1. Bike ride");
            Console.WriteLine("2. Call prices");
            Console.WriteLine("3. Century from year");
            Console.WriteLine("4. Escaping the theater");
            Console.WriteLine("5. Metro card");
            Console.WriteLine("6. Missing operator");
            Console.WriteLine("7. n-interesting polygon");
            Console.WriteLine("8. All of them, one by one");
            int challengeNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------------------------");

            switch (challengeNumber)
            {
                case 1:
                    BikeRide();
                    break;
                case 2:
                    PhoneCallInfo();
                    break;
                case 3:
                    CenturyFromYearInfo();
                    break;
                case 4:
                    SeatsInTheaterInfo();
                    break;
                case 5:
                    MetroCardInfo();
                    break;
                case 6:
                    ArithmeticExpressionInfo();
                    break;
                case 7:
                    ShapeAreaInfo();
                    break;
                case 8:
                    BikeRide();
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    PhoneCallInfo();
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    CenturyFromYearInfo();
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    SeatsInTheaterInfo();
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    MetroCardInfo();
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    ArithmeticExpressionInfo();
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    ShapeAreaInfo();
                    break;
                default:
                    Console.WriteLine("Please input either 1, 2, 3, 4 or 5.");
                    break;
            }
        }

        static int BikeRide()
        {
            Console.WriteLine("For how many minutes have you been riding your bike?");
            int numberOfMinutes = int.Parse(Console.ReadLine());

            int hours = 0,
                minutes = 0,
                sum = 0;

            if (numberOfMinutes / 60 >= 1)
            {
                hours = (int) numberOfMinutes / 60;
            }

            if (numberOfMinutes % 60 > 0)
            {
                minutes = numberOfMinutes % 60;
            }

            while (hours > 0)
            {
                sum += hours % 10;
                hours /= 10;
            }

            while (minutes > 0)
            {
                sum += minutes % 10;
                minutes /= 10;
            }

            Console.WriteLine($"The sum of digits on the digital timer is {sum}");
            return sum;
        }

        static void PhoneCallInfo()
        {
            Console.WriteLine("Find out how long you can talk on the phone:");
            Console.WriteLine("How many cents does the first minute cost?");
            int min1 = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cents do the minutes between 2 and 10 cost?");
            int min2_10 = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cents do the minutes after the tenth minute cost?");
            int min11 = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cents do you have?");
            int cents = int.Parse(Console.ReadLine());

            PhoneCall(min1, min2_10, min11, cents);
        }

        static int PhoneCall(int min1, int min2_10, int min11, int cents)
        {
            int numberOfMinutes = 0;

            if (cents >= min1)
            {
                numberOfMinutes += 1;
                cents = cents - min1;
            }

            if (cents >= min2_10)
            {
                decimal minutes2_10 = cents / min2_10;
                int minutes2_10A = (int) Math.Floor(minutes2_10);

                if(minutes2_10A > 0 && minutes2_10A <= 9)
                {
                    numberOfMinutes += minutes2_10A;
                    cents = cents - (minutes2_10A * min2_10);
                } else if(minutes2_10A > 9)
                {
                    numberOfMinutes += 9;
                    cents = cents - (9 * min2_10);
                }
            }

            if (cents >= min11)
            {
                decimal minutes11 = cents / min11;
                int minutes11A = (int) Math.Floor(minutes11);
                numberOfMinutes += minutes11A;
            }

            if (numberOfMinutes == 1)
            {
                Console.WriteLine($"Your longest call can last {numberOfMinutes} minute.");
            } else if (numberOfMinutes > 1)
            {
                Console.WriteLine($"Your longest call can last {numberOfMinutes} minutes.");
            }

            return numberOfMinutes;
        }

        static void CenturyFromYearInfo()
        {
            Console.WriteLine("Please input an AD year to find out its century.");
            int year = int.Parse(Console.ReadLine());
            CenturyFromYear(year);
        }

        static int CenturyFromYear(int year)
        {
            int century = year / 100;
            int remainingYears = year % 100;

            if (year <= 0)
            {
                Console.WriteLine("Please input an AD year, a number greater than 0.");
            }
            if (year > 0)
            {
                if (remainingYears == 0)
                {
                    century += 0;
                } else if (remainingYears > 0)
                {
                    century++;
                }

                if (century.ToString().EndsWith("1") && !century.ToString().EndsWith("11"))
                {
                    Console.WriteLine($"The year is part of the {century}st century.");
                } else if (century.ToString().EndsWith("2") && !century.ToString().EndsWith("12"))
                {
                    Console.WriteLine($"The year is part of the {century}nd century.");
                } else if (century.ToString().EndsWith("3") && !century.ToString().EndsWith("13"))
                {
                    Console.WriteLine($"The year is part of the {century}rd century.");
                } else
                {
                    Console.WriteLine($"The year is part of the {century}th century.");
                }
            }
            
            return century;
        }

        static void SeatsInTheaterInfo()
        {
            Console.WriteLine("Find out how many people you'd disturb if you left your seat:");
            Console.WriteLine("How many rows are there in the theater?");
            int nRows = int.Parse(Console.ReadLine());
            Console.WriteLine("How many seats are there in one row?");
            int nCols = int.Parse(Console.ReadLine());
            Console.WriteLine("Which row do you sit in?");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("What's the number of your seat?");
            int col = int.Parse(Console.ReadLine());
            SeatsInTheater(nCols, nRows, col, row);
        }

        static int SeatsInTheater(int nCols, int nRows, int col, int row)
        {
            int people = (nCols - col + 1) * (nRows - row);
            if (people <= 10)
            {
                Console.WriteLine($"Go for it, you would potentially disturb only {people} people.");
            } else
            {
                Console.WriteLine($"You would potentially disturb {people} people. You'd better stay in your seat.");
            }
            
            return people;
        }

        static void MetroCardInfo()
        {
            Console.WriteLine("How many days were you able to ride the Metro during this most recent month?");
            int lastNumberOfDays = int.Parse(Console.ReadLine());
            MetroCard(lastNumberOfDays);
        }

        static int[] MetroCard(int lastNumberOfDays)
        {
            int[] nextDays = new int[1];
            if (lastNumberOfDays == 30 || lastNumberOfDays == 28)
            {
                nextDays = new int[] { 31 };
                Console.WriteLine($"Your pass will now be extended for {nextDays[0]} days.");
            } else if (lastNumberOfDays == 31)
            {
                nextDays = new int[] { 28, 30, 31 };
                Console.WriteLine($"Your pass will now be extended for {nextDays[0]}|{nextDays[1]}|{nextDays[2]} days.");
            } else
            {
                Console.WriteLine("Please input one of the following numbers: 28, 30 or 31.");
            }

            return nextDays;
        }

        static void ArithmeticExpressionInfo()
        {
            Console.WriteLine("Please input three numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            ArithmeticExpression(a, b, c);
        }

        static bool ArithmeticExpression(int a, int b, int c)
        {
            bool boolValue = false;

            if (a + b == c)
            {
                Console.WriteLine($"Possible arithmetic expression: {a} + {b} = {c}.");
                boolValue = true;
            }
            if (a - b == c)
            {
                Console.WriteLine($"Possible arithmetic expression: {a} - {b} = {c}.");
                boolValue = true;
            }
            if (a * b == c)
            {
                Console.WriteLine($"Possible arithmetic expression: {a} * {b} = {c}.");
                boolValue = true;
            }
            if (1.0d * a / b == c)
            {
                Console.WriteLine($"Possible arithmetic expression: {a} / {b} = {c}.");
                boolValue = true;
            }

            if (boolValue)
            {
                return boolValue;
            } else
            {
                Console.WriteLine($"No simple arithmetic expression is possible with {a}, {b} and {c}.");
            }

            return boolValue;
        }

        static void ShapeAreaInfo()
        {
            Console.WriteLine("How many sides would you like your interesting polygon to have?");
            int n = int.Parse(Console.ReadLine());
            ShapeArea(n);
        }
        
        static int ShapeArea(int n)
        {
            int area = 1;
            int sides = n;

            while ((sides - 1) > 0)
            {
                area = area + sides * 2 + (sides - 2) * 2;
                sides--;
            }

            Console.WriteLine($"The area of the {n}-interesting polygon is {area}.");
            return area;
        }

    }
}
