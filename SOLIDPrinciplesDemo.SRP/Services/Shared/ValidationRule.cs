namespace SOLIDPrinciplesDemo.SRP.Services.Shared
{
    public interface ValidationRule
    {
        bool Success { get; }
        string FailureReason { get; }
    }
}
