using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotLab
{
    internal class UsedCar : Car
    {
        public double Mileage { get; set; }

        public UsedCar(string make, string model, int year, decimal price, double mileage)
            : base(make, model, year, price)
        {
            Mileage = mileage;
                        
        }

        

        public override string ToString()
        {
            
            return $"{Make}   \t{Model}   \t{Year}   \t{Price}   \t{Mileage}";
        }

    }
}
