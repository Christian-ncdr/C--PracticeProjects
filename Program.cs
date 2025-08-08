using System;

namespace CSharpSwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // B A S I C S W I T C H S T A T E M E N T 
            Console.WriteLine("S T A R T I N G P R O G R A M");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("\n\n C U R R E N T_D A T E_F O R M A T T E R\n");
            // USER INPUT
            Console.Write("Enter current month : ");

            // INTEGER CONVERTION
            int month = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Enter current day   : ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter current year  : ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nP R O C E S S I N G __________________________________________________\n\n");

            Console.WriteLine("USER INPUTED  month   : " + month);
            Console.WriteLine("USER INPUTED  day     : " + day);
            Console.WriteLine("USER INPUTED  year    : " + year);
            Console.ReadLine();

            Console.WriteLine("Result_____________________________________________________________________\n\n");

            if (day >= 1 && day  <= 31 && year >= 1 && year <= 2025) {
                switch (month)
                {
                    case 0:
                        Console.WriteLine("January " + day + ", " + year);
                        break;
                    case 1:
                        if (day <= 28)
                        {
                            Console.WriteLine("February " + day + ", " + year);
                        }
                        else
                        {
                            Console.WriteLine("Invalid date");
                        }
                        break;
                    case 2:
                        Console.WriteLine("March " + day + ", " + year);
                        break;
                    case 3:
                        if (day <= 30)
                        {
                            Console.WriteLine("April " + day + ", " + year);
                        }
                        else { Console.WriteLine("Invalid date"); 
                        } break;
                    case 4:
                        Console.WriteLine("May " + day + ", " + year);
                        break;
                    case 5:
                        Console.WriteLine("June " + day + ", " + year);
                        break;
                    case 6:
                        Console.WriteLine("July " + day + ", " + year);
                        break;
                    case 7:
                        Console.WriteLine("August " + day + ", " + year);
                        break;
                    case 8:
                        if (day <= 30)
                        {
                            Console.WriteLine("September " + day + ", " + year);
                        }
                        else
                        {
                            Console.WriteLine("Invalid date");
                        }
                            break;
                    case 9:
                        Console.WriteLine("October " + day + ", " + year);
                        break;
                    case 10:
                        if (day <= 30)
                        {
                            Console.WriteLine("November " + day + ", " + year);
                        } else
                        {
                            Console.WriteLine("Invalid Date");
                        }
                            break;
                    case 11:
                        Console.WriteLine("December " + day + ", " + year);
                        break;

                }

                }else
                {
                    Console.WriteLine("invalid input");
                }

                    Console.ReadLine();

            }
     }
}