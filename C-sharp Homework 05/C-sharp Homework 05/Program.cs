using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Homework_05
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateOfAdmissionHP = new DateTime(1991, 07, 31);
            Wizard harryPotter = new Wizard("Harry Potter", 90, 37, dateOfAdmissionHP, true);
            DateTime dateOfAdmissionRW = new DateTime(1991, 01, 01);
            Wizard ronWeasley = new Wizard("Ronald Weasley", 90, 37, dateOfAdmissionRW, true);
            DateTime dateOfAdmissionHG = new DateTime(1990, 09, 19);
            Wizard hermioneGranger = new Wizard("Hermione Granger", 90, 37, dateOfAdmissionHG, true);
            DateTime dateOfAdmissionMM = new DateTime(1946, 10, 04);
            Wizard minervaMcGonagall = new Wizard("Minerva McGonagall", 92, 82, dateOfAdmissionMM, true);
            DateTime dateOfAdmissionNS = new DateTime(1908, 02, 24);
            Wizard newtScamander = new Wizard("Newton Scamander", 93, 121, dateOfAdmissionNS, true);

            Creature dobby = new Creature("Dobby the Elf", 96, 245, true);
            Creature firenze = new Creature("Firenze the Centaur", 97, 357, false);
            Creature sirNicholas = new Creature("Sir Nicholas de Mimsy-Porpington", 46, 525, true);
            Creature peeves = new Creature("Peeves", 76, 1025, false);
            Creature norberta = new Creature("Norberta the Norwegian Ridgeback", 100, 25, false);

            Wizard[] wizards = new Wizard[5] { harryPotter, ronWeasley, hermioneGranger, minervaMcGonagall, newtScamander };
            Creature[] creatures = new Creature[5] { dobby, firenze, sirNicholas, peeves, norberta };
            Creature[] noTaming = new Creature[5];

            Console.WriteLine("It's time for a wizarding duel. Do you want to fight as a wizard or a creature, or do you want a duel war?");
            Console.WriteLine("Type W for wizard, C for creature or A for all.");
            string fightAs = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------------------------");

            switch (fightAs)
            {
                case "W":
                case "w":
                    Console.WriteLine("Choose the wizard you want to fight as by typing their number:\n1. Harry Potter\n2. Ron Weasley\n3. Hermione Granger\n4. Minerva McGonagall\n5. Newt Scamander");
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    string wizardInput1 = Console.ReadLine();
                    int wizardNumber1;
                    if (!Int32.TryParse(wizardInput1, out wizardNumber1))
                    {
                        Console.Clear();
                        Console.WriteLine("Please try again and input a number between 1 and 5");
                    } else
                    {
                        Console.WriteLine("Choose the creature you want to fight by typing their number:\n1. Dobby the Elf\n2. Firenze the Centaur\n3. Nearly Headless Nick\n4. Peeves\n5. Norberta the Dragon");
                        Console.WriteLine("----------------------------------------------------------------------------------");
                        string creatureInput1 = Console.ReadLine();
                        int creatureNumber1;
                        if (!Int32.TryParse(creatureInput1, out creatureNumber1))
                        {
                            Console.Clear();
                            Console.WriteLine("Please try again and input a number between 1 and 5");
                        }
                        else
                        {
                            System.Threading.Thread.Sleep(500);
                            if (wizardNumber1 > 0 && wizardNumber1 < 6 && creatureNumber1 > 0 && creatureNumber1 < 6 && wizards[wizardNumber1 - 1].powerLevel > creatures[creatureNumber1 - 1].powerLevel)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"You won the duel as {wizards[wizardNumber1 - 1].name} against {creatures[creatureNumber1 - 1].name}!!!");
                                Console.ResetColor();
                                if (creatures[creatureNumber1 - 1].isTamed == false)
                                {
                                    creatures[creatureNumber1 - 1].isTamed = true;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine($"{creatures[creatureNumber1 - 1].name} is now tame!!!");
                                    Console.ResetColor();
                                    creatures[creatureNumber1 - 1].isTamed = false;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"You lost as {wizards[wizardNumber1 - 1].name} against {creatures[creatureNumber1 - 1].name}. Try again.");
                                Console.ResetColor();
                            }
                        }
                    }                    
                    break;
                case "C":
                case "c":
                    Console.WriteLine("Choose the creature you want to fight as by typing their number:\n1. Dobby the Elf\n2. Firenze the Centaur\n3. Nearly Headless Nick\n4. Peeves\n5. Norberta the Dragon");
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    string creatureInput2 = Console.ReadLine();
                    int creatureNumber2;
                    if (!Int32.TryParse(creatureInput2, out creatureNumber2))
                    {
                        Console.Clear();
                        Console.WriteLine("Please try again and input a number between 1 and 5");
                    }
                    else
                    {
                        Console.WriteLine("Choose the wizard you want to fight by typing their number:\n1. Harry Potter\n2. Ron Weasley\n3. Hermione Granger\n4. Minerva McGonagall\n5. Newt Scamander");
                        Console.WriteLine("----------------------------------------------------------------------------------");
                        string wizardInput2 = Console.ReadLine();
                        int wizardNumber2;
                        if (!Int32.TryParse(wizardInput2, out wizardNumber2))
                        {
                            Console.Clear();
                            Console.WriteLine("Please try again and input a number between 1 and 5");
                        }
                        else
                        {
                            System.Threading.Thread.Sleep(500);
                            if (wizardNumber2 > 0 && wizardNumber2 < 6 && creatureNumber2 > 0 && creatureNumber2 < 6 && creatures[creatureNumber2 - 1].powerLevel > wizards[wizardNumber2 - 1].powerLevel)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"You won the duel as {creatures[creatureNumber2 - 1].name} against {wizards[wizardNumber2 - 1].name}!!!");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"You lost as {creatures[creatureNumber2 - 1].name} against {wizards[wizardNumber2 - 1].name}. Try again.");
                                Console.ResetColor();
                            }
                        }
                    }
                    break;
                case "A":
                case "a":
                    Console.WriteLine("Get ready for a massive duel fight between the wizards:\n1. Harry Potter\n2. Ron Weasley\n3. Hermione Granger\n4. Minerva McGonagall\n5. Newt Scamander\n\nand the creatures\n1. Dobby the Elf\n2. Firenze the Centaur\n3. Nearly Headless Nick\n4. Peeves\n5. Norberta the Dragon");
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    for (int i = 0; i < wizards.Length; i++)
                    {
                        for (int j = 0; j < creatures.Length; j++)
                        {
                            if (wizards[i].powerLevel > creatures[j].powerLevel)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{wizards[i].name} won against {creatures[j].name}!!!");
                                Console.ResetColor();
                                if (creatures[j].isTamed == false)
                                {
                                    creatures[j].isTamed = true;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine($"{creatures[j].name} is now tame!!!");
                                    Console.ResetColor();
                                    creatures[j].isTamed = false;
                                }
                                System.Threading.Thread.Sleep(500);
                            } else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{wizards[i].name} lost against {creatures[j].name}!!!");
                                Console.ResetColor();
                                if (creatures[j].isTamed == false)
                                {
                                    if (!noTaming.Contains(creatures[j]))
                                    {
                                        noTaming[i] = creatures[j];
                                    }
                                }
                                System.Threading.Thread.Sleep(500);
                            }
                        }
                        Console.WriteLine("\n----------------------------------------------------------------------------------");
                    }
                    Console.WriteLine("----------------------------------------------------------------------------------\n");
                    for (int i = 0; i < noTaming.Length && noTaming[i] != null; i++)
                    {
                        System.Threading.Thread.Sleep(500);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"The creature {noTaming[i].name} can't be tamed.");
                        Console.ResetColor();
                    }
                    Console.WriteLine("\n----------------------------------------------------------------------------------\n");
                    break;
                default:
                    Console.WriteLine("If you want to duel, please type W, C or A.");
                    Console.WriteLine("----------------------------------------------------------------------------------\n");
                    break;
            }
        }
    }
}
