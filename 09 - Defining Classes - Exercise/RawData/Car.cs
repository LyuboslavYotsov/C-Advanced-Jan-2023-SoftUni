﻿

namespace RawData
{
    public class Car
    {
		private string model;
		private Engine engine;
		private Cargo cargo;
		private Tire tire1;
        private Tire tire2;
        private Tire tire3;
        private Tire tire4;

		public Car(string model, Engine engine , Cargo cargo , Tire tire1, Tire tire2, Tire tire3, Tire tire4)
		{
			Model = model;
			Engine = engine;
			Cargo = cargo;
			Tire1 = tire1;
			Tire2 = tire2;
			Tire3 = tire3;
			Tire4 = tire4;
		}

        public Tire Tire4
        {
            get { return tire4; }
            set { tire4 = value; }
        }

        public Tire Tire3
        {
            get { return tire3; }
            set { tire3 = value; }
        }

        public Tire Tire2
        {
            get { return tire2; }
            set { tire2 = value; }
        }

        public Tire Tire1
		{
			get { return tire1; }
			set { tire1 = value; }
		}


		public Cargo Cargo
		{
			get { return cargo; }
			set { cargo = value; }
		}


		public Engine Engine
        {
			get { return engine; }
			set { engine = value; }
		}


		public string Model
        {
			get { return model; }
			set { model = value; }
		}

	}
}
