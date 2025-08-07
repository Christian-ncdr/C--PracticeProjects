using System;

namespace CSharpPracticeProject
{
    class Program
    {
        static void Main(string[] args)
        {

            // ito ay implicit conversion which means cinoconvert natin ang maliit na data type sa mas malaking data type
            // char -> int -> float -> double
            /*   int number = 14;
               double myDouble = number;

               char myChar = 'b';
               int aciiCode = myChar;

               Console.WriteLine(myChar);
               Console.WriteLine(aciiCode);
            */

            // ito naman ay explicit conversion which means cinoconvert natin ang malaking data type sa mas maliit na data type
            //  double -> float -> int -> char

            /*
            int aciiCode = 53;
            char myChar = (char) aciiCode; // explicit conversion from int to char

            Console.WriteLine(aciiCode);
            Console.WriteLine(myChar);

            float myFloat = 3.14f;
            int myInt = (int)myFloat;

            Console.WriteLine(myFloat);
            Console.WriteLine(myInt);
            */

            // ito naman ay conversion sa pagitan ng string at int
            // isama narin natin ang ilang math/ arithmetic operations gamit naman ang user input


            // declaration of variables and data types
            string x; 
            string y;
            double sum, difference, product, quotient, modulo ;

            // for start up
            Console.WriteLine("Welcome Users, Let's do some arithmetic operations:>  ");
            Console.WriteLine("===================================================");
            Console.ReadKey();


            //kinukuha na natin ang user input
            Console.Write("\nPlease enter the first number               : ");
            x =  Console.ReadLine();

            Console.Write("Please enter the second number              : ");
            y = Console.ReadLine();


            // converting string to double for arithmetic operations
            double num1 = Convert.ToDouble(x);
            double num2 =Convert.ToDouble(y);

            // performing arithmetic operations
            sum = num1 + num2;
            difference = num1 - num2;
            product = num1 * num2;
            quotient = num1 / num2; 
            modulo = num1 % num2;

            Console.WriteLine("\nPROCESSING...............................");
            Console.ReadKey();

            // displaying the results
            Console.WriteLine("\nThe sum of two number you entered is       : " + sum);
            Console.ReadKey();
            Console.WriteLine("The difference of two number you entered is : " + difference);
            Console.ReadKey();
            Console.WriteLine("The product of two number you entered is    : " + product);
            Console.ReadKey();
            Console.WriteLine("The quotient of two number you entered is   : " + quotient);
            Console.ReadKey();
            Console.WriteLine("The modulo of two number you entered is     : " + modulo);
            Console.ReadKey();


            //end of the program
            Console.WriteLine("\nThank you for using this program.........");
            Console.WriteLine("===========================================");
            Console.ReadKey();

            // to shortcut the process of converting string to int or double
            // do this
            // int x = Convert.ToInt32(Console.ReadLine());
            // double y = Convert.ToDouble(Console.ReadLine());


        }
    }
}
