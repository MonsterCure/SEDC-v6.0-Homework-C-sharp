using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            new Book("Harry Potter and the Philosopher's Stone", "J.K. Rowling", 320, "9780439554930", true, new DateTime(2018, 02, 12));
            new Book("Harry Potter and the Chamber of Secrets", "J.K. Rowling", 341, "9780439064866", false);
            new Book("Lincoln in the Bardo", "George Saunders", 343, "9780812995343", true, new DateTime(2018, 03, 10));
            new Book("Nutshell", "Ian McEwan", 208, "9780385542074", true, new DateTime(2017, 12, 23));
            new Book("Waking Gods", "Sylvain Neuvel", 325, "9781101886724", true, new DateTime(2018, 03, 08));
            new Book("Artemis", "Andy Weir", 305, "9780553448122", false);
            new Book("Norse Mythology", "Neil Gaiman", 299, "9780393609097", true, new DateTime(2018, 02, 28));
            new Book("Orlando", "Virginia Woolf", 228, "9780141184272", false);
            new Book("A Conjuring of Light", " V.E. Schwab", 624, "9780765387462", true, new DateTime(2018, 03, 02));
            new Book("The Bear and the Nightingale", "Katherine Arden", 323, "9781101885932", false);

            Start:
            Console.WriteLine("Welcome to The Library of Books\n\nChoose what you want to do:\n1. Get a list of the available books and maybe borrow one\n2. Get a list of the currently checked out books\n3. Get a list of the overdue books\n4. Return a book");
            Console.WriteLine("=================================================================");

            string libraryInput = Console.ReadLine();
            int libraryInpuNumber;

            if (!Int32.TryParse(libraryInput, out libraryInpuNumber))
            {
                Console.Clear();
                Console.WriteLine("Please try again and input a number between 1 and 4");
                Console.WriteLine("=================================================================");
                goto Start;
            }
            else
            {
                Switch:
                switch (libraryInpuNumber)
                {
                    case 1:
                        Console.WriteLine("---------------------------------------------------------------");
                        Console.WriteLine($"These books are currently available:");
                        foreach (var item in Book.books)
                        {
                            if (!item.isCheckedOut)
                            {
                                Console.WriteLine($"{item.Id}: {item.bookTitle} by {item.bookAuthor}");
                            }
                        }
                        Console.WriteLine("=================================================================");
                        Console.WriteLine("Would you like to borrow a book (Y) or go back to the main menu (M)?");
                        string decision = Console.ReadLine().ToUpper();
                        Console.WriteLine("---------------------------------------------------------------");
                        string message = "Please enter a correct book number.";
                        if (decision == "M")
                        {
                            goto Start;
                        }
                        else if (decision == "Y")
                        {
                            Console.WriteLine("If you would like to borrow a book, please type in the number of the book.");
                            Console.WriteLine("---------------------------------------------------------------");
                            string bookNumberString = Console.ReadLine();
                            double bookNumber;
                            if (Double.TryParse(bookNumberString, out bookNumber) && bookNumber > 0)
                            {
                                foreach (var item in Book.books)
                                {
                                    if (bookNumber == item.Id && !item.isCheckedOut)
                                    {
                                        item.ChangeStatus();
                                        item.checkedOut = DateTime.Today;
                                        Console.WriteLine("---------------------------------------------------------------");
                                        Console.WriteLine("Thank you for borrowing a book. We hope you will enjoy reading it.");
                                        Console.WriteLine("=================================================================");
                                    }
                                    else if(bookNumber == item.Id && item.isCheckedOut)
                                    {
                                        Console.WriteLine(message);
                                        message = "";
                                    }
                                }
                                goto Start;
                            }
                            else
                            {
                                Console.WriteLine("---------------------------------------------------------------");
                                Console.WriteLine("Please enter a correct book number.");
                                goto Switch;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter Y or M.");
                            goto case 1;
                        }
                        break;
                    case 2:
                        Console.WriteLine("---------------------------------------------------------------");
                        Console.WriteLine($"These books are currently checked out:");
                        foreach (var item in Book.books)
                        {
                            if (item.isCheckedOut)
                            {
                                Console.WriteLine($"{item.bookTitle} by {item.bookAuthor}");
                            }
                        }
                        Console.WriteLine("=================================================================");
                        goto Start;
                        break;
                    case 3:
                        Console.WriteLine("---------------------------------------------------------------");
                        Console.WriteLine($"These books are overdue:");
                        foreach (var item in Book.books)
                        {
                            item.CalculateFees();
                            //Console.WriteLine($"{item.CalculateFees()}");
                            if (item.isCheckedOut && item.isOverdue)
                            {
                                Console.WriteLine($"{item.bookTitle} by {item.bookAuthor}\nThe fees due are {item.CalculateFees()}");
                            }
                        }
                        Console.WriteLine("=================================================================");
                        goto Start;
                        break;
                    case 4:
                        Console.WriteLine("---------------------------------------------------------------");
                        Console.WriteLine("Please type in the title of the book you wish to return");
                        string bookTitle = Console.ReadLine().ToLower();
                        Console.WriteLine("---------------------------------------------------------------");
                        foreach (var item in Book.books)
                        {
                            if(bookTitle == item.bookTitle.ToLower() && item.isCheckedOut== true)
                            {
                                if(item.CalculateFees() == 0)
                                {
                                    item.ChangeStatus();
                                    item.checkedOut = default(DateTime);
                                    Console.WriteLine($"Thank you for returning the book {item.bookTitle}. We hope you enjoyed reading it.");
                                }
                                else
                                {
                                    Console.WriteLine("It seems that the book is overdue and you need to pay the penalty fee. Please come to the library to return the book.");
                                }
                            }else if(bookTitle == item.bookTitle.ToLower() && item.isCheckedOut == false)
                            {
                                Console.WriteLine("It seems that the book has not been checked out. You can borrow it if you want.");
                            }
                        }
                        Console.WriteLine("=================================================================");
                        goto Start;
                        break;
                    default:
                        Console.WriteLine("Please input either 1, 2, 3 or 4.");
                        goto Start;
                        break;
                }
            }
        }
    }
}
