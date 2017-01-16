using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethod_ProjectTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //part one of my program will ask a user a series of questions

            Console.WriteLine("Hello, Welcome to Fortune Teller!\n");

            Console.WriteLine("**If you wish to quit the program at any point please type \"quit\".\n**If you wish to restart at any time just type \"restart\".");
            Console.WriteLine("\nPlease enter your first name to get started:");
            //tells user they can quit and restart at any point 

            string quitProgram = "quit";
            string restartProgram = "restart";
            string firstName = Console.ReadLine();

            if (firstName.Equals(quitProgram, StringComparison.CurrentCultureIgnoreCase))
            {
                Environment.Exit(0);
            }
            else if (firstName.Equals(restartProgram, StringComparison.CurrentCultureIgnoreCase))
            {
                Main(args);
                Environment.Exit(0);
            }

            Console.WriteLine("Now please enter your last name.");
            string lastName = Console.ReadLine();
            //just got users first and last name enter
             
            if (lastName.Equals(quitProgram, StringComparison.CurrentCultureIgnoreCase))
            {
                Environment.Exit(0);
            }
            else if (lastName.Equals(restartProgram, StringComparison.CurrentCultureIgnoreCase))
            {
                Main(args);
                Environment.Exit(0);
            }

            Console.WriteLine(Greetings(firstName, lastName));
            //this is my greetings method writes "Greetings, firstname lastname. I will tell you your fortune."

            Console.WriteLine("\nNow please enter your age.");
            string usersAgeStr = Console.ReadLine();
            //users age inputed as string 

            if (usersAgeStr.Equals(quitProgram, StringComparison.CurrentCultureIgnoreCase))
                {
                    Environment.Exit(0);
                }
                else if (usersAgeStr.Equals(restartProgram, StringComparison.CurrentCultureIgnoreCase))
                {
                    Main(args);
                    Environment.Exit(0);
                }

            int usersAge = int.Parse(usersAgeStr);

            //loop to test for a reasonable age entered 
            while (true)
            {
                if (usersAge < 1 || usersAge > 120)
                {
                    Console.WriteLine("I believe you entered an impossible age, please re-enter your age now:");
                    usersAge = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
           
          Console.WriteLine(firstName + ", what number month were you born? For example: enter 12 for December.");
            string birthMonthStr = Console.ReadLine();

            if (birthMonthStr.Equals(quitProgram, StringComparison.CurrentCultureIgnoreCase))
            {
                Environment.Exit(0);
            }
            else if (birthMonthStr.Equals(restartProgram, StringComparison.CurrentCultureIgnoreCase))
            {
                Main(args);
                Environment.Exit(0);
            }

            int birthMonth = int.Parse(birthMonthStr);
            //users birthMonth converted to int

            //loop to test for a reasonable age entered 
            while (true)
            {
                if (birthMonth < 1 || birthMonth > 12)
                {
                    Console.WriteLine("I believe you entered an impossible birth month, please re-enter your birth month now:");
                    birthMonth = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Okay " + firstName + " " + lastName + ". You are " + usersAge + " and were born in month number " + birthMonth
                + ". \n\nNow, please enter your favorite ROYGBIV color (spell it out).\nIf you do not know what ROYGBIV is, then enter \"Help.\"");

            string favoriteColor = Console.ReadLine();
            string[] ROYGBIV = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };

            while(true)
       { 
                if(favoriteColor.Equals("red", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }
                else if (favoriteColor.Equals("orange", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }
                else if (favoriteColor.Equals("yellow", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }
               else if (favoriteColor.Equals("green", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }
                else if (favoriteColor.Equals("blue", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }
                else if (favoriteColor.Equals("indigo", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }
                else if (favoriteColor.Equals("violet", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }
                else if (favoriteColor.Equals("Help", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("ROYGBIV stands for: Red, Orange, Yellow, Green, Blue, Indigo, Violet.\nNow enter which color is your favorite (spell it out).");
                    favoriteColor = Console.ReadLine();
                }
                else if (favoriteColor.Equals(quitProgram, StringComparison.CurrentCultureIgnoreCase))
                {
                    Environment.Exit(0);
                }
                else if (favoriteColor.Equals(restartProgram, StringComparison.CurrentCultureIgnoreCase))
                {
                    Main(args);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please enter a color that is part of ROYGBIV.");
                    favoriteColor = Console.ReadLine();
                }
            }

         Console.WriteLine("You have enter " + favoriteColor + " as your favorite color");

            //if else statement used to determine users favorite ROYGBIV color

            Console.WriteLine("Finally, please enter the number of siblings you have (as digit).");
           string number_of_siblingsStr = Console.ReadLine();

            if (number_of_siblingsStr.Equals(quitProgram, StringComparison.CurrentCultureIgnoreCase))
            {
                Environment.Exit(0);
            }
            else if (number_of_siblingsStr.Equals(restartProgram, StringComparison.CurrentCultureIgnoreCase))
            {
                Main(args);
                Environment.Exit(0);
            }
           int number_of_siblings=  int.Parse(number_of_siblingsStr);
            //converted number of siblings to int

            Console.WriteLine("You have entered " + number_of_siblings + " as the number of siblings you have.");

            //Part Three: Fortune: [First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation].
            Console.WriteLine("\nHere is your Fortune:\n" + firstName + " " + lastName + " will retire in " + YearsBeforeRetire(usersAge) + " years with $" + BankAccountWhenRetire(birthMonth) + " in the bank,\na vacation home in " + UsersVacationHome(number_of_siblings) + " and a " + ModeOfTransportation(favoriteColor) + ".\n");
            Console.WriteLine("The judgement on your fortune is: ");
            JudgeFortune();
        }    
    
        //**********************************************
        //*************This is where I will build my methods!!!!!

        static string Greetings (string firstname, string lastname)
        {
           string greeting = "Greetings, " + firstname + " " + lastname + ". I will tell you your fortune!";
            return greeting;
        }
        //this method greets the user

        static int YearsBeforeRetire(int usersAge)
        {
            int retireYears = 0;
                if (usersAge % 2 == 0)
                {
                    retireYears = 50; //even number
                }
                else
                {
                    retireYears = 100;
                }
                return retireYears;
        }
        //this method calculates the number of years before the user retires based on the age they enter

        static double BankAccountWhenRetire (int birthMonth)
        {
            double bankAccount;

            if (birthMonth < 01)
            {
                bankAccount = 0.00d;
            }
            else if (birthMonth >= 1 && birthMonth <= 4)
            {
                bankAccount = 4000d;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                bankAccount = 1.50d;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                bankAccount = 100000d;
            }
            else
            {
                bankAccount = 0.00d;
            }
            return bankAccount;
        }

        //this method is used to determine how much money a person will have in their bank account based on their birth month

        static string UsersVacationHome (int number_of_siblings)
        {
            string vacationHome;
            if (number_of_siblings < 0)
            {
                vacationHome = "The inlaws house";
            }
            else if (number_of_siblings == 0)
            {
                vacationHome = "Germany";
            }
            else if (number_of_siblings == 1)
            {
                vacationHome = "Cap Code";
            }
            else if (number_of_siblings == 2)
            {
                vacationHome = "Disney World";
            }
            else if (number_of_siblings == 3)
            {
                vacationHome = "Las Vegas";
            }
            else
            {
                vacationHome = "Thailand";
            }
            return vacationHome;
        }

        //this method determines the vacation home based on number of siblings

        static string ModeOfTransportation(string favoriteColor)
        {
            string transportation;
            if (favoriteColor.Equals("Red", StringComparison.CurrentCultureIgnoreCase))
            {
                transportation = "Car";
            }
            else if (favoriteColor.Equals("Orange", StringComparison.CurrentCultureIgnoreCase))
            {
                transportation = "Boat";
            }
            else if (favoriteColor.Equals("Yellow", StringComparison.CurrentCultureIgnoreCase))
            {
                transportation = "Plane";
            }
            else if (favoriteColor.Equals("Green", StringComparison.CurrentCultureIgnoreCase))
            {
                transportation = "Train";
            }
            else if (favoriteColor.Equals("Blue", StringComparison.CurrentCultureIgnoreCase))
            {
                transportation = "Motorcycle";
            }
            else if (favoriteColor.Equals("Indigo", StringComparison.CurrentCultureIgnoreCase))
            {
                transportation = "Bicycle";
            }
            else if (favoriteColor.Equals("Violet", StringComparison.CurrentCultureIgnoreCase))
            {
                transportation = "Horse";
            }
            else
            {
                transportation = "Squeaky shopping cart";
            }
            return transportation;
        }
        //this method determines mode of transportation based on favorite color

        static void JudgeFortune ()
        {
            string judge = "Your Fortune is great!";
            Console.WriteLine(judge);
        }

        //Method that judges how good the fortune is
      
        }
      }
