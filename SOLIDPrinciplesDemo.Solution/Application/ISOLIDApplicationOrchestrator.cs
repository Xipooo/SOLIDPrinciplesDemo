namespace SOLIDPrinciplesDemo.Solution.Application
{
    public interface ISOLIDApplicationOrchestrator
    {
        string GetVehicleMake();
        string GetVehicleYear();
        void PostMessage(string MessageText);
    }
}
