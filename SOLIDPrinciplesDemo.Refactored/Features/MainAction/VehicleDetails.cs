namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction
{
    class VehicleDetails : GetVehicleDetailsResult
    {
        public string CarMake { get; }
        public string CarYear { get; }

        public VehicleDetails(string CarMake, string CarYear)
        {
            this.CarMake = CarMake;
            this.CarYear = CarYear;
        }
    }
}
