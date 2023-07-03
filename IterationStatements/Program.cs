using System.ComponentModel.Design;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void RangeThousand()
        {
            Console.WriteLine("Print 1000 through -1000");

            for(int a = 1000; a >= -1000;  a--)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("______________________________________________________________");
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ThreeForDays()
        {
            Console.WriteLine("--------------------------------------------------------------");
            for(int b = 3; b <= 999; b += 3)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("______________________________________________________________");
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void EqualParameters(int c, int d)
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("What is 10 * 2?");
            var p = int.Parse(Console.ReadLine());

            if (p == c * d)
            {
                Console.WriteLine("Your guess is correct!");
            }

            else
            {
                Console.WriteLine("Your guess is incorrect!");
            }
            Console.WriteLine("______________________________________________________________");
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOdd()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Is your number completely divisible by 2?");
            int d = int.Parse(Console.ReadLine());

            if (d % 2 == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }
            Console.WriteLine("______________________________________________________________");
        }
        //Write a method to check whether a given number is positive or negative
        public static void PositiveNum()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Is your number negative or positive?");
            int g = int.Parse(Console.ReadLine());

            if(g > 0)
            {
                Console.WriteLine("Your number is positive!");
            } 
            else
            {
                Console.WriteLine("Your number is negative!");
            }
            Console.WriteLine("______________________________________________________________");

        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void Voter()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("What is your age?");

            int voterAge = int.Parse(Console.ReadLine());

            if (voterAge > 18)
            {
                Console.WriteLine("Take your registration card and head to the front dest!");
            } 
            else
            {
                Console.WriteLine("Sorry! You're not the legal age to vote.");
            }
            Console.WriteLine("______________________________________________________________");
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void IsNumberInRange()
        {
           Console.WriteLine("--------------------------------------------------------------");
           Console.WriteLine("How did you score on your game?");

            bool value = true;
            var num = int.Parse(Console.ReadLine());

           if (num >= -10 && num <= 10)
           {
                Console.WriteLine("Welcome to our league!"); 
           }
           else
           {
                Console.WriteLine("Your score doesn't cut it!");
           }
           
            Console.WriteLine("______________________________________________________________");

        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void Table()
        {
           Console.WriteLine("--------------------------------------------------------------");
           Console.WriteLine("My multiplication table.");
            int tableMax = 12;

           for (int q = 1; q <= tableMax; q++)
            {
                for (int r = 1; r <= tableMax; r++)
                {
                    int content = q * r;
                    Console.Write(content.ToString());
                }
                Console.ReadLine();
            }

        }

    //Call the methods to test them in the Main method below
    static void Main(string[] args)
        {
            RangeThousand();
            ThreeForDays();
            EqualParameters(10, 2);
            EvenOdd();
            PositiveNum();
            Voter();
            IsNumberInRange();
            Table();
        }
    }
}
