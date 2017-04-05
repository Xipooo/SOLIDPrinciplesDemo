using SOLIDPrinciplesDemo.Refactored.Features.MainAction;
using SOLIDPrinciplesDemo.Refactored.Services.UserPrompt;
using SOLIDPrinciplesDemo.Refactored.Services.VehicleValidation;
using SOLIDPrinciplesDemo.UserPromptService;
using SOLIDPrinciplesDemo.VehicleValidationService;
using System;

namespace SOLIDPrinciplesDemo
{
    public static class DependencyResolver
    {
        public static ConsolePromptService<ConsoleKey> NewReadKeyPromptService => new ReadKeyPromptService();
        public static ConsolePromptService<string> NewReadLinePromptService => new ReadLinePromptService();
        public static ConsolePostService NewWriteLinePromptService => new WriteLinePromptService();
        public static VehicleValidationService.VehicleValidationService NewVehicleValidationService => new ThreadSafeVehicleValidationService();

        public static ConsolePromptServiceProxy NewConsolePromptProxy => new SOLIDConsolePromptServiceProxy(NewReadKeyPromptService, NewReadLinePromptService, NewWriteLinePromptService);
        public static VehicleValidationServiceProxy NewSOLIDVehicleValidationServiceProxy => new SOLIDVehicleValidationServiceProxy(NewVehicleValidationService);
        public static MainOrchestrator Orchestrator = new SOLIDMainOrchestrator(NewConsolePromptProxy, NewSOLIDVehicleValidationServiceProxy);

    }
}
