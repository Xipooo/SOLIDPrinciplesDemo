using Microsoft.Extensions.DependencyInjection;
using SOLIDPrinciplesDemo.Solution.Application;
using SOLIDPrinciplesDemo.Solution.Features.GetCarDetails;
using SOLIDPrinciplesDemo.Solution.Features.UserPrompt;
using SOLIDPrinciplesDemo.Solution.Features.Validation;
using System;

namespace SOLIDPrinciplesDemo.Solution.Startup
{
    static class Services
    {
        public static IServiceProvider ServiceProvider =>
            new ServiceCollection()
            .AddTransient<IApplication, SOLIDApplication>()
            .AddTransient<IGetCarDetailsOrchestrator, GetCarDetailsOrchestrator>()
            .AddTransient<IUserPromptService, UserPromptService>()
            .AddTransient<IValidationResult, ValidationResult>()
            .AddTransient<IValidationRuleService, ValidationRuleService>()
            .BuildServiceProvider();
    }
}
