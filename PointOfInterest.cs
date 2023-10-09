using System.Security.Cryptography.X509Certificates;

namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }

        public PointOfInterest()
        {
            Latitude = 44.854186;
            Longitude = -0.5663056;
            Name = "Bordeaux Ynov Campus";
        }
        public PointOfInterest(string name, double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            Name = name;
        }

        public string GetGoogleMapsUrl(){
            string url = string.Format(GoogleMapsUrlTemplate, Name, Latitude, Longitude);
            return url;
        }
        public static string GoogleMapsUrlTemplate { get ; } = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";  
    }
}