using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03FractionalKnapsackProblemGreedyAlgorithm
{
    class KnapsackPackage
    {
        private double weight;
        private double value;
        private double cost;

        public KnapsackPackage(double weight, double value)
        {
            this.weight = weight;
            this.value = value;

            this.cost = (double)value / weight;
        }

        public double Weight
        {
            get { return weight; }
        }

        public double Value
        {
            get { return value; }
        }

        public double Cost
        {
            get { return cost; }
        }
    }
}
