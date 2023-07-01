using System.Reflection.Metadata;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void DoSomething()
        {
            Console.WriteLine("Below is a list of numbers from -1000 - 1000");
            
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("My List");
            Console.WriteLine("------------------------------------------------------------");
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ThreeIsTheNumber() 
        {
            Console.WriteLine("A list of three's");

            for (int b = 3; b <= 999; b += 3)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("------------------------------------------------------------");
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool Parameters(int c, int d)
        {
            
            Console.WriteLine("Are these numbers equal?");

            if (c == d)
            {
                return true;
            }
            else
            {
                return false;
            }
            Console.WriteLine("------------------------------------------------------------");
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOdd()
        {
            Console.WriteLine("Is your number even?");
            int e = int.Parse(Console.ReadLine());

            if (e % 2 == 0)
            {
                Console.WriteLine($"The number {e} is even");
            }
            else
            {
                Console.WriteLine($"The number {e} is odd");
            }
            Console.WriteLine("------------------------------------------------------------");
        }
        //Write a method to check whether a given number is positive or negative
        public static void PositiveMaybe()
        {
            Console.WriteLine("What was your score?");
            int f = int.Parse(Console.ReadLine());

            if (f >= 0)
            {
                Console.WriteLine("Great! Your number was positive.");
            }
            else
            {
                Console.WriteLine("Your number was negative.");
            }
            Console.WriteLine("------------------------------------------------------------");
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void VoterAge()
        {
            Console.WriteLine("What is your age?");
            int g = int.Parse(Console.ReadLine());

            if (g >= 18)
            {
                Console.WriteLine("You can legally vote. Fill out the registration card online");
            }
            else
            {
                Console.WriteLine("You're too young to vote. Sorry but you can't be granted entry");
            }
            Console.WriteLine("------------------------------------------------------------");
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void Ranger()
        {
            Console.WriteLine("What's your golf score");
            int h = int.Parse(Console.ReadLine());

            if (h < -10)
            {
                Console.WriteLine("Amazing Score! You are overqualified though.");
            }
            else if (h > 10)
            {
                Console.WriteLine("Your score is too high. You did not qualify this year");
            }
            else
            {
                Console.WriteLine("Congrats! We welcome you to our league!");
            }
            Console.WriteLine("------------------------------------------------------------");
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void Mulitply()
        {
            Console.WriteLine("Multiply two numbers.");
            int l = 12;

            for (int j = 1; j <= l; j++)
            {
                for (int k = 1;  k <= l; k++)
                {
                    int content = j * k;
                    Console.Write(content.ToString());
                }
                Console.ReadLine();
            }
            Console.WriteLine("------------------------------------------------------------");
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            DoSomething();
            ThreeIsTheNumber();
            Console.WriteLine(Parameters(2, 8));
            EvenOdd();
            PositiveMaybe();
            VoterAge();
            Ranger();
            Mulitply();
        }
    }
}
