using System;
using System.Net.Http.Headers;

namespace IterationStatements
{
    class Program
    {


        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void NumberRange()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine($"{i}");
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Triple()
        {
            for (int n = 3; n <= 999; n += 3)
            {
                Console.WriteLine(n);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool Equal(int a, int b)
        {
            var check = (a == b) ? true : false;

            return check;

        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOnly()
        {

            Console.WriteLine("What's your favorite number?");
            int y = int.Parse(Console.ReadLine());

            if (y % 2 == 0)
            {
                Console.WriteLine($"We're happy to join you to group A");
            }
            else
            {
                Console.WriteLine($"We're happy to join you to group B");
            }
            Console.WriteLine("-------------------------------------------");
        }

        //Write a method to check whether a given number is positive or negative
        public static void PositiveMaybe()
        {
            Console.WriteLine("What number are you thinking of?");
            int q = int.Parse(Console.ReadLine());

            if (q > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number is negative");
            }
            Console.WriteLine("-------------------------------------------");
        }
        //read the age of a candindate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void VoterAge()
        {
            Console.WriteLine("How old are you?");

            var age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Sorry. You're not old enough to vote");
            }
            else
            {
                Console.WriteLine("Welcome! You can begin your voter registration.");
            }
            Console.WriteLine("-------------------------------------------");
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void Range()
        {
            Console.WriteLine("What is your golf score?");
            int j = int.Parse(Console.ReadLine());

            if (j > 10)
            {
                Console.WriteLine("Your score is too high. Once your overall score is lower, then we can send an invitation.");
            }
            else if (j < -10)
            {
                Console.WriteLine("You're doing an amazing job! Unfortunately, this league is not for you. You should going Pro.");
            }
            else
            {
                Console.WriteLine("Great Score! We Welcome you to our league. Visit our front office to receive your membership.");
            }
            Console.WriteLine("-------------------------------------------");

        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void Multiply()
        {
            Console.WriteLine("Multiply the numbers ranging from '1-12'");
            

            int tableMax = 12;

            for(int u = 1;  u <= tableMax; u++)
            {
                for (int w = 1; w <= tableMax; w++)
                {
                    int content = u * w;

                    Console.Write(content.ToString());
                }
                    Console.ReadLine();
            }
        }


      //Call the methods to test them in the Main method below
      static void Main(string[] args)
      {
        NumberRange();
        Triple();
        Console.WriteLine(Equal(2, 8));
        EvenOnly();
        PositiveMaybe();
        VoterAge();
        Range();
        Multiply();
      }
    }
}
