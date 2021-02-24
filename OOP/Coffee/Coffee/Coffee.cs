using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee
{

    class Coffee
    {
        public string typeOfCoffee;
        public int quantity;
        public double singlePriceOfCoffee;
        public double totalPriceOfCoffee;

        public Coffee(string typeOfCoffee
            , int quantity
            , double singlePriceOfCoffee
            , double totalPriceOfCoffee)
        {
            this.typeOfCoffee = typeOfCoffee;
            this.quantity = quantity;
            this.singlePriceOfCoffee = singlePriceOfCoffee;
            this.totalPriceOfCoffee = totalPriceOfCoffee;
        }


        public static double TotalPriceOfCoffee(int quantity, double singlePriceOfCoffe)
        {
            return quantity * singlePriceOfCoffe;
        }

        public static double SinglePriceOfCoffee(string typeOfCoffee)
        {
            switch (typeOfCoffee)
            {
                case "short":
                    return 0.2d;

                case "normal":
                    return 0.4d;

                case "long":
                    return 0.5d;
                default:
                    return 0;

            }

        }
    }
}
