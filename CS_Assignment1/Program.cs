using System;

namespace CS_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Enter y or Y to continue");
            string input = Console.ReadLine();
            while (input == "y" || input == "Y")
            {
                Console.WriteLine("1. Find out last occurance of 'a', 'e', 'i', 'o', 'u' in the predefined string");
                Console.WriteLine("2. Find out count of 'and' in the predefined string");
                Console.WriteLine("3. Perform simple math operations");
                Console.WriteLine("4. Change type of input");
                Console.WriteLine("5. Check if input is positive, negative or 0");

                
                switch (Console.ReadLine())
                {
                    case "1":
                        string predefined = "Thor is a 2011 American superhero film based on the Marvel Comics character of the same name. Produced by Marvel Studios and distributed by Paramount Pictures,[N 1] it is the fourth film in the Marvel Cinematic Universe (MCU). It was directed by Kenneth Branagh, written by the writing team of Ashley Edward Miller and Zack Stentz along with Don Payne, and stars Chris Hemsworth as the title character alongside Natalie Portman, Tom Hiddleston, Stellan Skarsgård, Colm Feore, Ray Stevenson, Idris Elba, Kat Dennings, Rene Russo, and Anthony Hopkins. After reigniting a dormant war, Thor is banished from Asgard to Earth, stripped of his powers and his hammer Mjölnir. As his brother Loki (Hiddleston) plots to take the Asgardian throne, Thor must prove himself worthy.";
                        LastOccurance(predefined);
                        break;
                    case "2":
                        string same_predefined = "Thor is a 2011 American superhero film based on the Marvel Comics character of the same name. Produced by Marvel Studios and distributed by Paramount Pictures,[N 1] it is the fourth film in the Marvel Cinematic Universe (MCU). It was directed by Kenneth Branagh, written by the writing team of Ashley Edward Miller and Zack Stentz along with Don Payne, and stars Chris Hemsworth as the title character alongside Natalie Portman, Tom Hiddleston, Stellan Skarsgård, Colm Feore, Ray Stevenson, Idris Elba, Kat Dennings, Rene Russo, and Anthony Hopkins. After reigniting a dormant war, Thor is banished from Asgard to Earth, stripped of his powers and his hammer Mjölnir. As his brother Loki (Hiddleston) plots to take the Asgardian throne, Thor must prove himself worthy.";
                        Console.WriteLine("Number of occurances of 'and' are : " + Occurences(same_predefined, "and"));
                        break;
                    case "3":
                        SimpleMathOperation();
                        break;
                    case "4":
                        ChangeInputType();
                        break;
                    case "5":
                        GetInputRange();
                        break;
                }
                Console.WriteLine("Enter y or Y to continue");
                input = Console.ReadLine();
            }


        }

        static void LastOccurance(string str)
        {

            int idxOfA = str.LastIndexOf('a');
            Console.WriteLine("Index of last occuranceof a is " + idxOfA);
            int idxOfE = str.LastIndexOf('e');
            Console.WriteLine("Index of last occurance of e is " + idxOfE);
            int idxOfI = str.LastIndexOf('i');
            Console.WriteLine("Index of last occurance of i is " + idxOfI);
            int idxOfO = str.LastIndexOf('o');
            Console.WriteLine("Index of last occurance of o is " + idxOfO);
            int idxOfU = str.LastIndexOf('u');
            Console.WriteLine("Index of last occurance of u is " + idxOfU);

        }

        static int Occurences(string str, string word)
        {
            string[] arr = str.Split(' ');
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (word.Equals(arr[i]))
                    count++;
            }
            return count;
        }

        static void SimpleMathOperation()
        {
            Console.WriteLine("Enter x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y");
            int y = Convert.ToInt32(Console.ReadLine());

            int addRes = x + y;
            Console.WriteLine("Addition = " + addRes);
            int subRes = x - y;
            Console.WriteLine("Substraction = " + subRes);
            int multRes = x * y;
            Console.WriteLine("Multiplication = " + multRes);
            int divRes = x / y;
            Console.WriteLine("Division = " + divRes);
            int square = x * x;
            Console.WriteLine("Square = " + square);
            double sqroot = Math.Sqrt(x);
            Console.WriteLine("Square root of x = " + sqroot);
            Console.WriteLine("x raised to power y = " + Math.Pow(x, y));
            Console.WriteLine("sin of x = " + Math.Sin(x));
            Console.WriteLine("cos of x = " + Math.Cos(x));
            Console.WriteLine("tan of x = " + Math.Tan(x));
            Console.WriteLine("Absolute value of x = " + Math.Abs(x));
            Console.WriteLine("Average of x and y = " + ((x + y) / 2));
        }

        static void ChangeInputType()
        {
            Console.WriteLine("Enter input to change type");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input type is converted to int");
        }

        static void GetInputRange()
        {
            Console.WriteLine("Enter a number x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number y");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x < 0 || y < 0)
            {
                Console.WriteLine("Number is negative i.e. invalid input");
            }
            else if(x > 0 && y > 0)
            {
                Console.WriteLine("Number is positive, valid input");
            }
            else
            {
                Console.WriteLine("Number is zero i.e. invalid input");
            }
        }
    }
}
