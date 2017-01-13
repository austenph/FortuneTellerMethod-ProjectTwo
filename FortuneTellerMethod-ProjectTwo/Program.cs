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

            Console.WriteLine("Hello, Welcome to Fortune Teller.\nPlease enter your first name to get started.");
            string firstName = Console.ReadLine();

            Console.WriteLine("Now please enter your last name.");
            string lastName = Console.ReadLine();
            //just got users first and last name enter 

           Console.WriteLine(Greetings(firstName, lastName));
            //this is my greetings method writes "Greetings, firstname lastname. I will tell you your fortune."

            Console.WriteLine("\nNow please enter your age.");
            int usersAge = int.Parse(Console.ReadLine());
            //users age inputed

            Console.WriteLine(firstName + ", what number month were you born? For example: enter 12 for December.");
            int birthMonth = int.Parse(Console.ReadLine());
            //users birth month as an integer

            Console.WriteLine("Okay " + firstName + " " + lastName + ". You are " + usersAge + " and were born in month number " + birthMonth
                + ". \nNow, please enter your favorite ROYGBIV color (spell it out).\nIf you do not know what ROYGBIV is, then enter \"Help.\"");

            string favoriteColor = Console.ReadLine();

            if (favoriteColor.Equals("Help", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("ROYGBIV stands for: Red, Orange, Yellow, Green, Blue, Indigo, Violet.\nNow enter which color is your favorite (spell it out).");
                favoriteColor = Console.ReadLine();
                Console.WriteLine(favoriteColor + " is your favorite color.");
            }
            else
            {
                Console.WriteLine("You have enter " + favoriteColor + " as your favorite color");
            }
            //if else statement used to determine users favorite ROYGBIV color

            Console.WriteLine("Finally, please enter the number of siblings you have (as digit).");
            int number_of_siblings = int.Parse(Console.ReadLine());
            Console.WriteLine("You have entered " + number_of_siblings + " as the number of siblings you have.");
            //user enters the number of siblings they have. Part One complete


            //Part Three: Fortune: [First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation].
            Console.WriteLine("Here is your Fortune:\n\n" + firstName + " " + lastName + " will retire in " + YearsBeforeRetire(usersAge) + " years with $" + BankAccountWhenRetire(birthMonth) + " in the bank,\na vacation home in " + UsersVacationHome(number_of_siblings) + " and a " + ModeOfTransportation(favoriteColor) + ".");
        }


        //**********************************************
        //*************This is where I will build my methods!!!!!
        static string Greetings (string firstname, string lastname)
        {
           string greeting = "Greetings, " + firstname + " " + lastname + ". I will tell you your fortune!";
            return greeting;
        }
        //this method greets the user

        static int YearsBeforeRetire (int usersAge)
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
