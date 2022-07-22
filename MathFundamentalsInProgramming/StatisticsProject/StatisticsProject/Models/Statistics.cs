using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StatisticsProject.Models
{
    class Statistics
    {
        public Statistics(string input)
        {

            var newInput = string.Join(" ", Regex.Split(input, @"(?:\r\n|\n|\r)"));

            string[] inputStringArr = newInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            decimal[] inputDecimalArr = inputStringArr.Select(x => decimal.Parse(x))
                                                        .ToArray();

            this.Input = inputDecimalArr;

            this.NMV = this.Input.Min();
            this.ChNMV = this.Input.Where(x => x == this.NMV).Count();
            this.NGV = this.Input.Max();
            this.ChNGV = this.Input.Where(x => x == this.NGV).Count();
            this.AVG = this.Input.Average();
            if (this.Input.Length % 2 == 0)
            {
                this.Mediana = (this.Input[Input.Length / 2] + this.Input[(Input.Length / 2) - 1]) / 2;
            }
            else
            {
                this.Mediana = this.Input[Input.Length / 2];
            }
            this.Moda = this.GetMode(this.Input, 0);
            this.Obem = this.Input.Length;
            this.Output = this.Input.OrderBy(x => x).ToArray();

            decimal dispersia = 0m;
            decimal sao = 0m;

            foreach (var item in this.Input)
            {
                dispersia += ((item - this.AVG) * (item - this.AVG));
                sao += Math.Abs(item - this.AVG);
            }

            dispersia /= this.Input.Length;
            sao /= this.Input.Length;

            this.Disperia = dispersia;
            this.SAO = sao;
            this.SKO = (decimal)Math.Sqrt((double)this.Disperia);

        }

        public decimal[] Input { get; set; }
        public decimal[] Output { get; set; }
        public decimal NMV { get; set; }
        public int ChNMV { get; set; }
        public decimal NGV { get; set; }
        public int ChNGV { get; set; }
        public decimal AVG { get; set; }
        public decimal Mediana { get; set; }
        public decimal Moda { get; set; }
        public decimal SAO { get; set; }
        public decimal SKO { get; set; }
        public decimal Disperia { get; set; }
        public int Obem { get; set; }

        public decimal GetMode(decimal[] values, int count)

        {

            Dictionary<decimal, int> h = new Dictionary<decimal, int>();

            count = 0;

            foreach (int value in values)
            {
                if (!h.ContainsKey(value))
                {
                    h.Add(value, 1);
                }
                else
                {
                    h[value] = (int)h[value] + 1;
                }

                if ((int)h[value] > count)
                {
                    count = (int)h[value];
                }
            }

            List<decimal> list = new List<decimal>();
            foreach (var entry in h)
            {
                if ((int)entry.Value == count)
                {
                    list.Add((decimal)entry.Key);
                }
            }
            if (list.Count != 1)
            {
                return list.Average();
            }

            foreach (var entry in h)
            {
                if ((int)entry.Value == count)
                {
                    return decimal.Parse(entry.Key.ToString());
                }
            }
            return 0m;
        }
    }
}
