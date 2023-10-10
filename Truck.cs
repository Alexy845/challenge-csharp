namespace CSharpDiscovery.Quest04
{
    public class Truck : Vehicule {

        public int Tonnage { get; set; }

        public Truck() : base()
        {
            Tonnage = 0;
        }
        public Truck(int tonnage, string brand, string color, int currentSpeed = 0) : base(brand, color, currentSpeed)
        {
            this.Tonnage = tonnage;
            currentSpeed = 0;
        }
        public override void Accelerate(int Speed)
        {
            CurrentSpeed += Speed;
            if (CurrentSpeed > 100)
            {
                CurrentSpeed = 100;
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
        public override string ToString()
        {
            return Color + " " + Brand + " " + Tonnage + "T Truck";
        }
    }
}