
namespace SpeedRacing
{
    public class Car
    {
		private string model;
		private double fuelAmount;
		private double fuelConsumption;
		private double traveledDistance;

		public Car()
		{
			traveledDistance = 0;
		}

		public Car(string model, double fuelAmount, double fuelConsumption) : this()
		{
			Model= model;
			FuelAmount= fuelAmount;
			FuelConsumption= fuelConsumption;
		}
		

		public double TraveledDistance
        {
			get { return traveledDistance; }
			set { traveledDistance = value; }
		}


		public double FuelConsumption
        {
			get { return fuelConsumption; }
			set { fuelConsumption = value; }
		}


		public double FuelAmount
        {
			get { return fuelAmount; }
			set { fuelAmount = value; }
		}


		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public void Drive(int distance)
		{
			double neededFuel = FuelConsumption * distance;
			if (FuelAmount - neededFuel >= 0)
			{
				FuelAmount -= neededFuel;
				TraveledDistance += distance;
			}
			else
			{
				System.Console.WriteLine("Insufficient fuel for the drive");
			}
		}


	}
}
