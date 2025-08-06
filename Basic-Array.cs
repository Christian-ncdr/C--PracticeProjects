using System;

namespace CSharpPracticeProgramArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // ITO ANG EXAMPLE NG ARRAY NA DECLARED NA AGAD ANG VALUES NG MGA INDEX
            //string[] names = { "james", "cameron", "andrei", "clark", "steve" };
            //Console.WriteLine(names[2]);

            // ITO ANG EXAMPLE NG ARRAY NA HINDI PA DECLARED ANG MGA VALUES NG MGA INDEX
            //string[] names = new string[5];
            //names[0] = "swetra";

            //Console.WriteLine(names[0]);

            //int[] numbers = new int[5];
            //Console.Write("please enter a number: ");
            //numbers[2] = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(numbers[2]);

            //float[] grades = new float[3];
            //Console.WriteLine("Please enter your grade: ");
            //grades[2] = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("Your grade is: " + grades[2]);

            // CHALLENGE

            Console.WriteLine("S T A R T I N G P R O G R A M");

            int index;

            string[] email = { "olanochristian1@gmail.com", "olanojohncena@gmail.com", "olanojohnchristoper@gmail.com", "olanoprecious@gmail.com"};
            string[] username = { "christian", "cena", "naruto", "babyliit" };
            string[] password = { "olano1234", "cena123", "naruto12345", "babyliit12345"};

            Console.Write("Please enter your code: ");
            index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("P R O C E S S I N G ..................................................");
            Console.ReadKey();

            Console.WriteLine("\nV I E W R E S U L T");
            Console.ReadKey();

            Console.WriteLine("\nR E S U L T............................................................");
            Console.Write("HELLO THERE, " + username[index]);
            Console.ReadLine();
            Console.Write("\nYour Code is     : " + index);
            Console.ReadLine();
            Console.Write("Your Email is    : " + email[index]);
            Console.ReadLine();
            Console.Write("Your Username is : " + username[index]);
            Console.ReadLine();
            Console.Write("Your Password is : " + password[index]);
            Console.ReadLine();

            Console.WriteLine("\nD A T A C O M P L E T E D !");



            Console.ReadLine();
        }

    }
}
                

        
    
    
    
            

        

    
        
    
    
    
    
    

