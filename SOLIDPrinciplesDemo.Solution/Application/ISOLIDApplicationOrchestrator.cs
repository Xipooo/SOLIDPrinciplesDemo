using SOLIDPrinciplesDemo.Solution.Features.Common;
using SOLIDPrinciplesDemo.Solution.Features.Validation;

namespace SOLIDPrinciplesDemo.Solution.Application
{
    public interface ISOLIDApplicationOrchestrator
    {
        string GetVehicleMake();
        string GetVehicleYear();
        void PostMessage(string MessageText);
        IValidationResult ValidateVehicle(IVehicle vehicle);
    }
}
