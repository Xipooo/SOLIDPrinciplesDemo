namespace SOLIDPrinciplesDemo.Solution.Features.Validation
{
    public interface IValidationResult
    {
        bool Successful { get; set; }
        string ErrorMessage { get; set; }
    }
}
