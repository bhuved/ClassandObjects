using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotLab
{
    internal class Point
    {
        public int x;
        public int y;

        public void CalculateDistance(int pointX, int pointY)
        {
            Console.WriteLine(Math.Sqrt(Math.Pow(pointX - 0, 2) + Math.Pow(pointY - 0, 2)));
        }
    }
}
