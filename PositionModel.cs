namespace GoogleMapsHelper.DataModels
{
    public class PositionModel
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }
        
        public double Elevation { get; set; }

        public int SatelliteCount { get; set; }

        public PositionModel(double latitude, double longitude, int numOfSatellites, double elevation = 0)
        {
            Latitude = latitude;
            Longitude = longitude;
            SatelliteCount = numOfSatellites;
            Elevation = elevation;
        }
    }
}
