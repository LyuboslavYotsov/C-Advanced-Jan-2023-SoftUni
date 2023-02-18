using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{

    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }

        public Engine(string model, int power, int displacement) : this(model, power)
        {
            Displacement = displacement;
        }

        public Engine(string model, int power, int displacement, string efficiency) : this(model, power, displacement)
        {

            Efficiency = efficiency;
        }

        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }


        public int Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }


        public int Power
        {
            get { return power; }
            set { power = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public override string ToString()
        {
            string displacement = Displacement == 0 ? "n/a" : Displacement.ToString();
            string efficiency = Efficiency ?? "n/a";

            string result = $"{Model}:{Environment.NewLine}" +
                            $"    Power: {Power}{Environment.NewLine}" +
                            $"    Displacement: {displacement}{Environment.NewLine}" +
                            $"    Efficiency: {efficiency}";
            return result;
        }

    }
}



