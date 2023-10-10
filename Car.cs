namespace CSharpDiscovery.Quest04
{

    public class Car : Vehicule
    {
        public string Model { get; set; }

        public override void Accelerate(int Speed)
        {
            CurrentSpeed += Speed;
            if (CurrentSpeed > 180)
            {
                CurrentSpeed = 180;
            }
        }
        public override void Brake(int BrakePower)
        {
            CurrentSpeed -= BrakePower;
            if (CurrentSpeed < 0)
            {
                CurrentSpeed = 0;
            }
        }
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