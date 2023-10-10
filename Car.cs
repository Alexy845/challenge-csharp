namespace CSharpDiscovery.Quest04
{

    public class Car : Vehicule
    {
        public string Model { get; set; }
        public Car() : base()
        {
            Model = "Unknown";
        }
        public Car(String model, string brand, string color, int currentSpeed = 0) : base(brand, color, currentSpeed)
        {
            this.Model = model;
        }
        
        public override string ToString()
        {
            return Color + " " + Brand + " " + Model;
        }
    }
}