using SOLIDPrinciplesDemo.SRP.Features.CarDetailsPrompt;
using SOLIDPrinciplesDemo.SRP.Features.ConvertCarYearToNumber;
using SOLIDPrinciplesDemo.SRP.Services.CarPromptService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {

                var service = new CarPromptService();
                service.PromptForCarDetails();
                service

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
                        if (numericCarYear < 99 && numericCarYear > 17)
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
                        if (numericCarYear < 1999)
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
                        if (numericCarYear >= 15 && numericCarYear <= 18)
                        {
                            Console.WriteLine("Your car is too new!");
                        }
                        else if (numericCarYear <= 95)
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
                        if (numericCarYear >= 2015)
                        {
                            Console.WriteLine("Your car is too new!");
                        }
                        else if (numericCarYear <= 1995)
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
