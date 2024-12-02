using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotLab
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public static List<Car> CarList { get; set; }

        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;
        }
        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public static void ListCar()
        {
            for (int i = 0; i < CarList.Count; i++)
            {
                Console.WriteLine($"{i + 1}\t{CarList[i].ToString()}");

            }



        }
        public static void Remove(int carIndex)
        {
            if (CarList.Contains(CarList[carIndex]))
            {
                CarList.RemoveAt(carIndex);

            }
            else
            {

                Console.WriteLine("Car not exist in the List, try another car");
            }

        }
        public override string ToString()
        {
            return $"Make {Make}\t Model {Model}\t Year {Year}\t Price {Price}\t";
            
        }

    }
}
