namespace SOLIDPrinciplesDemo.Solution.Features.Validation
{
    class ValidationResult : IValidationResult
    {
        public bool Successful { get; set; }
        public string ErrorMessage { get; set; }
    }
}
