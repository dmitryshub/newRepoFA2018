using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching_and_iteration_HW_demo_FA2018
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] definitions = new string[5];
            definitions[0] = "zero";
            definitions[1] = "one";
            definitions[2] = "two";
            definitions[3] = "three";
            definitions[4] = "four";

            string[] questions = new string[5];
            questions[0] = "0";
            questions[1] = "1";
            questions[2] = "2";
            questions[3] = "3";
            questions[4] = "4";

            //create int to hold randomNumber
            int indexPosition;

            Random myRandom1 = new Random();
            //indexPosition = myRandom1.Next(definitions.Length);

            //foreach (string i in definitions)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("What is the term referenced by the following definition?");
            //Console.WriteLine(definitions[indexPosition]);

            //create variable to store user input
            string userInput;

            //create a variable to track attempts
            int attempts = 0;

            //create a variable to track correct answers
            int correct = 0;

            //create variable to keep application open
            bool appRunning = true;

            while (appRunning)
            {

                Console.Clear();
                indexPosition = myRandom1.Next(definitions.Length);

                Console.WriteLine("Attempts: " + attempts);
                Console.WriteLine("Correct: " + correct);

                Console.WriteLine("\nWhat is the term referenced by the following definition?");
                Console.WriteLine(definitions[indexPosition]);

                userInput = Console.ReadLine();

                switch (indexPosition)
                {
                    case 0:
                        if (userInput == "0")
                        {
                            Console.Clear();
                            Console.WriteLine("Correct! It is 0!");
                            Console.WriteLine("Press Enter to continue...");
                            attempts++;
                            correct++;
                            Console.ReadLine();

                        }

                        else
                        {

                            Console.Clear();
                            Console.WriteLine("Try Again!");
                            Console.WriteLine("Press Enter to continue...");
                            attempts++;
                            Console.ReadLine();
                        }
                        break;

                    case 1:
                        if (userInput == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("Correct! It was 1.");
                            Console.WriteLine("Press Enter to continue...");
                            attempts++;
                            correct++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Try Again!");
                            Console.WriteLine("Press Enter to continue...");
                            attempts++;
                            Console.ReadLine();
                        }
                        break;

                    case 2:
                        if (userInput == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("Correct! It was 2.");
                            Console.WriteLine("Press Enter to continue...");
                            attempts++;
                            correct++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Try Again!");
                            Console.WriteLine("Press Enter to continue...");
                            attempts++;
                            Console.ReadLine();
                        }
                        break;

                    case 3:
                        if (userInput == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("Correct! It was 3.");
                            Console.WriteLine("Press Enter to continue...");
                            attempts++;
                            correct++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Try Again!");
                            Console.WriteLine("Press Enter to continue...");
                            attempts++;
                            Console.ReadLine();
                        }
                        break;

                    case 4:
                        if (userInput == "4")
                        {
                            Console.Clear();
                            Console.WriteLine("Correct! It was 4.");
                            Console.WriteLine("Press Enter to continue...");
                            attempts++;
                            correct++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Try Again!");
                            Console.WriteLine("Press Enter to continue...");
                            attempts++;
                            Console.ReadLine();
                        }
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Entry. Try Again!");
                        Console.WriteLine("Press Enter to continue...");
                        attempts++;
                        Console.ReadLine();
                        break;
                }

            }

            Console.ReadLine();

        }


    }
}
