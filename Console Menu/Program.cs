// Author: Ed French
// SID: EJF143
// Edited: 24/09/2019
using System;

namespace Console_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable declarations
            string userResponse;
            bool exitProgram = false;
            int incorrectResponseCount = 0;

            do
            {
                // Print a menu
                Console.WriteLine("Program Menu: Please select one of the folowing options");
                Console.WriteLine("1) Distance in miles");
                Console.WriteLine("2) Distance in kilometres");
                Console.WriteLine("3) Distance in astronomical units");
                Console.WriteLine("4) Exit Program");

                //userResponse = Console.ReadLine();

                userResponse = Console.ReadLine();

                // Process the user response a little to make it easer to match
                //userResponse = userResponse.ToUpper(); // Makes it all upper case
                //userResponse = userResponse.Trim(); // Take off any spare spaces


                // Process user input for menu
                switch (userResponse)
                {
                    case "1":
                        Console.WriteLine("We will work in miles");
                        break;
                    case "2":
                        Console.WriteLine("We will work in kilometres");
                        break;
                    case "3":
                        Console.WriteLine("We will work in AU");
                        break;
                    case "4":
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("You did not enter a valid response, please enter A, K or M");
                        incorrectResponseCount++;
                       if(incorrectResponseCount  == 2)
                        {
                            exitProgram = true;
                        }
                        break;
                }   
                
            } while (!exitProgram);

            // Wait at end of program
            Console.ReadLine();
        }
    }
}
