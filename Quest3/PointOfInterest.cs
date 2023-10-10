using System.Security.Cryptography.X509Certificates;

namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }
        public static string GoogleMapsUrlTemplate { get; } = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";

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

        public string GetGoogleMapsUrl()
        {
            string url = string.Format(GoogleMapsUrlTemplate, Name.Replace(" ", "+"), Latitude, Longitude);
            return url;
        }

        public override string ToString()
        {
            return Name + " (Lat=" + Latitude + ", Long=" + Longitude + ")";
        }
        public int GetDistance(PointOfInterest other)
        {
            double rad(double angle) => angle * 0.017453292519943295769236907684886127d; // = angle * Math.Pi / 180.0d
            double havf(double diff) => Math.Pow(Math.Sin(rad(diff) / 2d), 2); // = sin²(diff / 2)
            return (int)Math.Round((12745.6 * Math.Asin(Math.Sqrt(havf(other.Latitude - Latitude) + Math.Cos(rad(Latitude)) * Math.Cos(rad(other.Latitude)) * havf(other.Longitude - Longitude)))));
        }

        public static int GetDistance(PointOfInterest p1, PointOfInterest p2)
        {
            double rad(double angle) => angle * 0.017453292519943295769236907684886127d; // = angle * Math.Pi / 180.0d
            double havf(double diff) => Math.Pow(Math.Sin(rad(diff) / 2d), 2); // = sin²(diff / 2)
            return (int)Math.Round(12745.6 * Math.Asin(Math.Sqrt(havf(p2.Latitude - p1.Latitude) + Math.Cos(rad(p1.Latitude)) * Math.Cos(rad(p2.Latitude)) * havf(p2.Longitude - p1.Longitude))));
        }
    }
}