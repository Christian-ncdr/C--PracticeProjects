using System;

namespace CSharpDoAndDoWhileLoop {
    class Program {

        static void Main(string[] args) {

            //// this is while loop 

            //// ito ay ang initial value 
            //int i = 0;

            //// setting up condition using while loop
            //while (i < 10) { 

            //    Console.WriteLine(i);
            //    // iteration so that it wont become infinite ang loop
            //    i++;
            //}

            //// this is do while loop

            //int a = 0;

            //// ang do while loop naman ay nag displaying ng at lease one result right after i-check if na-meet na ang condition
            //do
            //{
            //    Console.WriteLine(a);
            //} while (a < 10);

            int lives = 5;

            Console.WriteLine("S T A R T I N G P R O G R A M");
            string Answers = "Seven days" ;
            string answer;

            Console.WriteLine("Solve This questions: ");
            Console.WriteLine("\n Q U E S T I O N S...........................................................");
            Console.WriteLine();
           
            Console.WriteLine("");

            while (lives > 0) {
                Console.WriteLine("1. Before the laws were changed in 2000, how long was a French president’s term?");
                answer = Console.ReadLine();

                if (answer.Equals(Answers, StringComparison.OrdinalIgnoreCase) )
                {
                    Console.WriteLine("You're correct!");
                    break;
                }
                else {
                    Console.WriteLine("you're wrong");
                    lives--;
                } if (lives == 0) Console.WriteLine("Sorry, you're already out of lives");
              
                
            }


        
        }
    
    }
}
