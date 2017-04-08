using SOLIDPrinciplesDemo.Solution.Features.Common;
using SOLIDPrinciplesDemo.Solution.Features.Validation;
using System;
using System.Collections.Generic;

namespace SOLIDPrinciplesDemo.Solution.Application
{
    class SOLIDApplication : IApplication
    {
        private readonly ISOLIDApplicationOrchestrator _orchestrator;

        public SOLIDApplication(ISOLIDApplicationOrchestrator orchestrator)
        {
            _orchestrator = orchestrator;
        }
        public void Run()
        {
            bool exitApp = false;
            while (!exitApp)
            {
                IVehicle vehicle = new Vehicle
                {
                    VehicleMake = _orchestrator.GetVehicleMake(),
                    VehicleYear = _orchestrator.GetVehicleYear()
                };

                foreach (var item in validationRules)
                {
                    var result = item();
                    if (!result.Successful)
                    {
                        _orchestrator.PostMessage(result.ErrorMessage);
                        continue;
                    }
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
