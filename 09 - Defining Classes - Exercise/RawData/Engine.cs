

namespace RawData
{
    public class Engine
    {
		private int speed;
		private int power;

		public Engine(int speed, int power)
		{
			Power= power;
			Speed= speed;
		}

		public int Power
        {
			get { return power; }
			set { power = value; }
		}


		public int Speed
        {
			get { return speed; }
			set { speed = value; }
		}

	}
}
