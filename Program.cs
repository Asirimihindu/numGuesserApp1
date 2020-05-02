using System;
//C# is a type language 
//above lines are used to incldue other namespaces/ or external classes
//creat namespace below , it is a container of classes, namespace name is by default comes from application file name 

namespace numGuesserApp1
{
    //main class , class contains methods/functions and variables 
    class Program
    {
        //this is the entry point method
        //void means it method does not return and value 
        //static means method does not need to be in a instance of program class to be called , which means it can be called without creating a object of program class 
        //Main means it is main method 
        static void Main(string[] args)
        {
            GetAppInfo();// Run GetAppInfo Function 
            Console.Write("What is your Name?:");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}!, Let's play a game....!", inputName);

            while (true)
            {
                //Create random object 
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                // Init guess var 
                int guess = 0;

                // Ask user for a number 
                Console.Write("Guess a number between 1 & 10 :");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    //make sure it is a number 
                    if (!int.TryParse(input, out guess))
                    { 
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual Number :");
                        continue;
                    }
                    //Cast(Parse) into int type and put in guess variable 
                    guess = Int32.Parse(input);
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong Guess, Please try again");
                    }
                }
                //sucess message 
                PrintColorMessage(ConsoleColor.Yellow, "You are correct...!!!!");
               


                // ask to play again 
                Console.Write("Do you want to play again? [Y/N]:");

                string answer = Console.ReadLine().ToUpper(); 
                if (answer =="Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }


            }

            //add waiting line to stop consol app go away after executing code 
            //Console.ReadLine();
        }
        static void GetAppInfo()
        {

            string appName = "Number Guesser App";
            string appVersion = "1.0";
            string appAuthor = "Asiri Mihindukulasuriya";
            //start here , every line needs ; at the end 

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version -{1}  by {2}", appName, appVersion, appAuthor);
            //Change text colour 

            Console.ResetColor();

        }
        static void PrintColorMessage(ConsoleColor color , string msg)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);

            Console.ResetColor();



        }


    }
}

