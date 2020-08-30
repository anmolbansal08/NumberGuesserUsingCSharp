using System;

namespace NumberGuesserusingCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            getappinfo();


            // greet and ask user name
            greetuser();

            while (true)
            {

                //int correctnumber = 3;

                //using random correctnumber

                //set correct number
                Random random = new Random();
                int correctnumber = random.Next(1, 4);

                // init guesswar
                int guess = 0;

                //ask user to guess a number

                Console.WriteLine($" Guess a Number between 1 to 10 ");

                while (guess != correctnumber)
                {
                    //Get users input
                    String anotherinput = Console.ReadLine();


                    if (!int.TryParse(anotherinput, out guess))
                    {

                        printcolormessage(ConsoleColor.Red,"Please use an actual number");

                        //continue used for direct jumnext itertion of while
                        continue;

                    }




                    //Cast to int and put into guess

                    guess = Int32.Parse(anotherinput);

                    //match guess to correct number

                    if (guess != correctnumber)
                    {
                        

                       printcolormessage(ConsoleColor.Yellow,"Oops Wrong Number entered");

                    
                    }


                }
                //output success message

               

        

                printcolormessage(ConsoleColor.Yellow,"You are correct");

                
               

                //Verify whether user wanna play again


                Console.WriteLine("You are Smart!! Do you wanna play again");


                string answer = Console.ReadLine();
                if (answer == "Yes" || answer == "y" || answer == "yes" || answer == "Y")
                {
                    continue;
                } else return;

            }
        }
        public static void getappinfo()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appversion = "0.1";
            string appAuthor = "AB";

            //change textcolor
            Console.ForegroundColor = ConsoleColor.Green;

            //write out appinfo

            Console.WriteLine($"{appAuthor}\t{appName}\t{appversion}");

            //reset color
            Console.ResetColor();
        }
        public static void greetuser()
        {
            Console.WriteLine("Holla user,please provide your name");
            String input = Console.ReadLine();
            Console.WriteLine($"Welcome {input}");

        }

        public static void printcolormessage(ConsoleColor color,String message)
        {
            Console.ForegroundColor = color;

            //write out appinfo

            Console.WriteLine(message);

            //reset color
            Console.ResetColor();

        }
        

        
    }
}
