namespace SOLIDPrinciplesDemo.Common
{
    public interface ValidationResult
    {
        string FailureReason { get; }
        bool Successful { get; }
    }
}
