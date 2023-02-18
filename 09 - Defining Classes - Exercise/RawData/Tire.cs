

namespace RawData
{
    public class Tire
    {
		private int age;
		private double pressure;

		public Tire(double pressure, int age)
		{
			Age= age;
			Pressure= pressure;
		}

		public double Pressure
        {
			get { return pressure; }
			set { pressure = value; }
		}


		public int Age
		{
			get { return age; }
			set { age = value; }
		}

	}
}
