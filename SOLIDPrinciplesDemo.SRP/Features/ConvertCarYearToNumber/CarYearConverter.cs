namespace SOLIDPrinciplesDemo.SRP.Features.ConvertCarYearToNumber
{
    public class CarYearConverter
    {
        private int _numericYear;
        public bool Successful { get; }
        public int NumericYear { get { return _numericYear; } }
        public string FailureReason { get; }

        public CarYearConverter(string CarYear)
        {
            Successful = int.TryParse(CarYear, out _numericYear);
            FailureReason = (Successful ? null : "Year entered is not a number.");
        }
    }
}
