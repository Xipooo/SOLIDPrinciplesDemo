namespace SOLIDPrinciplesDemo.Refactored.Services.Shared
{
    interface ValidationResult
    {
        string FailureReason { get; }
        bool Successful { get; }
    }
}
