namespace CSharpDiscovery.Quest04 
{
    public class HybridCar : Car, IThermalCar, IElectricCar
    {
        public HybridCar() : base()
        {

        }
        public HybridCar(string model, string brand, string color, int currentSpeed = 0) : base(model, brand, color, currentSpeed)
        {
            currentSpeed = 0;
            FuelLevel = 100;
            BatteryLevel = 100;
        }
        public int FuelLevel { get; set; }
        public int BatteryLevel { get; set; }
        public int GetFuelLevel()
        {
            return FuelLevel;
        }
        public int GetBatteryLevel()
        {
            return BatteryLevel;
        }
        public void FillUp()
        {
            FuelLevel = 100;
        }
        public void Recharge()
        {
            BatteryLevel = 100;
        }
        public override string ToString()
        {
            return Color + " " + Brand + " " + Model + ", Battery: " + BatteryLevel + "%, Fuel: " + FuelLevel + "%";
        }
    }
}