using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Start:
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Choose a shape:\n1. Circle\n2. Diamond\n3. Rectangle\n4. Triangle");
            Console.WriteLine("---------------------------------------------------------------");

            string shapeInput = Console.ReadLine();
            int shapeNumber;

            if (!Int32.TryParse(shapeInput, out shapeNumber))
            {
                Console.Clear();
                Console.WriteLine("Please try again and input a number between 1 and 4");
                Console.WriteLine("---------------------------------------------------------------");
                goto Start;
            }
            else
            {
                switch (shapeNumber)
                {
                    case 1:
                        Console.WriteLine("What would you like the radius of the circle to be?");
                        string radiusString = Console.ReadLine();
                        double radius;
                        if (Double.TryParse(radiusString, out radius) && radius > 0)
                        {
                            Circle circle = new Circle(radius);
                            shapes.Add(circle);
                            goto Decision;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a positive value for the radius.");
                            goto case 1;
                        }
                        break;
                    case 2:
                        Console.WriteLine("What would you like the diagonals of the diamond to be?\nFirst enter the first diagonal:");
                        string diagonal1String = Console.ReadLine();
                        double diagonal1;
                        Console.WriteLine("Now enter the second diagonal:");
                        string diagonal2String = Console.ReadLine();
                        double diagonal2;
                        if (Double.TryParse(diagonal1String, out diagonal1) && Double.TryParse(diagonal2String, out diagonal2) && diagonal1 > 0 && diagonal2 > 0)
                        {
                            Diamond diamond = new Diamond(diagonal1, diagonal2);
                            shapes.Add(diamond);
                            goto Decision;
                        }
                        else
                        {
                            Console.WriteLine("Please enter positive values for the diagonals.");
                            goto case 2;
                        }
                        break;
                    case 3:
                        Console.WriteLine("What would you like the sides of the rectangle to be?\nFirst enter the width:");
                        string widthString = Console.ReadLine();
                        double width;
                        Console.WriteLine("Now enter the length:");
                        string lengthString = Console.ReadLine();
                        double length;

                        if (Double.TryParse(widthString, out width) && Double.TryParse(lengthString, out length) && width > 0 && length > 0)
                        {
                            Rectangle rectangle = new Rectangle(width, length);
                            shapes.Add(rectangle);
                            goto Decision;
                        }
                        else
                        {
                            Console.WriteLine("Please enter positive values for the sides of the rectangle.");
                            goto case 3;
                        }
                        break;
                    case 4:
                        Console.WriteLine("What would you like the sides of the triangle to be?\nFirst enter the base:");
                        string baseLengthString = Console.ReadLine();
                        double baseLength;
                        Console.WriteLine("Now enter the first side:");
                        string side1String = Console.ReadLine();
                        double side1;
                        Console.WriteLine("Now enter the second side:");
                        string side2String = Console.ReadLine();
                        double side2;

                        if (Double.TryParse(baseLengthString, out baseLength) && Double.TryParse(side1String, out side1) && Double.TryParse(side2String, out side2) && baseLength > 0 && side1 > 0 && side2 > 0 && baseLength < side1 + side2)
                        {
                            Triangle triangle = new Triangle(baseLength, side1, side2);
                            shapes.Add(triangle);
                            goto Decision;
                        }
                        else
                        {
                            Console.WriteLine("Please enter positive and suitable values for the sides of the triangle\n(the sum of the sides should be larger than the base).");
                            goto case 4;
                        }
                        break;
                    default:
                        Console.WriteLine("Please input either 1, 2, 3 or 4.");
                        break;
                }

                Decision:
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("Do you want to continue entering shapes or do you want to see their areas and perimeters?\nY to continue N for areas and perimeters");
                string decision = Console.ReadLine().ToUpper();
                if (decision == "Y")
                {
                    goto Start;
                }
                else if (decision == "N")
                {
                    Console.WriteLine("---------------------------------------------------------------");
                    foreach (var item in shapes)
                    {
                        item.Perimeter();
                        item.Area();
                        Console.WriteLine("---------------------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter Y or N.");
                    goto Start;
                }
            }
        }
    }
}
