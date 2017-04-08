using System;

namespace SOLIDPrinciplesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine(Environment.NewLine + "Please enter the make of the car:");
                string carMake = Console.ReadLine();

                Console.WriteLine("Please enter the year of the car:");
                string carYear = Console.ReadLine();

                int numericCarYear;

                if (!int.TryParse(carYear, out numericCarYear))
                {
                    Console.WriteLine("Year entered is not a number.");
                    continue;
                }
                if (carYear.Length != 2 && carYear.Length != 4)
                {
                    Console.WriteLine("Year of the car entered must be 2 or 4 digits.");
                    continue;
                }

                if (carMake.ToLower() == "mazda")
                {
                    if (carYear.Length == 2)
                    {
                        if (numericCarYear < 97 && numericCarYear > 17)
                        {
                            Console.WriteLine("Your car is too old!");
                        }
                        else
                        {
                            Console.WriteLine("Congratulations!  Your car has been accepted!");
                        }
                    }
                    else if (carYear.Length == 4)
                    {
                        if (numericCarYear < 1997)
                        {
                            Console.WriteLine("Your car is too old!");
                        }
                        else
                        {
                            Console.WriteLine("Congratulations!  Your car has been accepted!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Something has gone terribly wrong!");
                    }
                }
                else if (carMake.ToLower() == "toyota")
                {
                    if (carYear.Length == 2)
                    {
                        if (numericCarYear >= 6 && numericCarYear <= 18)
                        {
                            Console.WriteLine("Your car is too new!");
                        }
                        else if (numericCarYear <= 98)
                        {
                            Console.WriteLine("Your car is too old!");
                        }
                        else
                        {
                            Console.WriteLine("Congratulations!  Your car has been accepted!");
                        }
                    }
                    else if (carYear.Length == 4)
                    {
                        if (numericCarYear >= 2006)
                        {
                            Console.WriteLine("Your car is too new!");
                        }
                        else if (numericCarYear <= 1998)
                        {
                            Console.WriteLine("Your car is too old!");
                        }
                        else
                        {
                            Console.WriteLine("Congratulations!  Your car has been accepted!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Something has gone terribly wrong!");
                    }
                }
                else
                {
                    Console.WriteLine("The car make you enetered is not currently being accepted.");
                }
                Console.WriteLine("Would you like to try another car? (Y/N)");
                exitApp = (Console.ReadKey().Key != ConsoleKey.Y);
            }
        }
    }
}
