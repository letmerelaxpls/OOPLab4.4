using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab_4._4
{
    class ApplicationLicense
    {
        public static void AllowTrial()
        {
            Console.WriteLine("Trial version");
        }

        public static void AllowCommon()
        {
            Console.WriteLine("Free version");
        }

        public static void AllowPro()
        {
            Console.WriteLine("Paid version");
        }
    }


    internal class Program
    {
        private static int n;

        static void Main(string[] args)
        {
            int keyNumber;

            Console.WriteLine("Would you like to enter key number?");
            Console.WriteLine("1 - yes");
            Console.WriteLine("2 - no");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
                {
                case 1:
                    Console.WriteLine("Please, enter key number: ");
                    keyNumber = int.Parse(Console.ReadLine());
                    if (keyNumber != 174836)
                    { 
                        Console.WriteLine("Your key number is incorrect, would you like to use trial version?");
                        Console.WriteLine("1 - yes");
                        Console.WriteLine("2 - no");
                        int answer2 = int.Parse(Console.ReadLine());
                        switch (answer2)
                        {
                            case 1:
                                Console.Write("You chose ");
                                ApplicationLicense.AllowTrial();

                                break;
                            case 2:
                                 n = 15;
                                break;
                        }
                        if (n == 15)
                        {
                            goto case 1;
                        }
                        break;
                    }
                    else if (keyNumber == 174836)
                    {
                        Console.WriteLine("Your key number is correct");
                        Console.Write("You activated ");
                        ApplicationLicense.AllowPro();
                    }
                        

                    break;
                case 2:
                    Console.WriteLine("You refused to enter key number");
                    Console.WriteLine("You can currently use only:");
                    ApplicationLicense.AllowCommon();

                    break;
                }

        }
    }
}
