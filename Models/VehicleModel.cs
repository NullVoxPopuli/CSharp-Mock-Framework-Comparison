using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VehicleModel
    {
        public readonly double Weight;
        public readonly int NumberOfTires;
        public readonly double TotalRatio;
        public readonly double TotalEfficiency;
        public readonly double Area;
        public readonly double DragCoefficient;
        public readonly TireModel Tire;

        public VehicleModel(double area, int numberOfTires, double weight, double totalRatio, 
            double totalEfficiency, TireModel tire, double dragCoefficient)
        {
            NumberOfTires = numberOfTires;
            Weight = weight;
            TotalRatio = totalRatio;
            TotalEfficiency = totalEfficiency;
            Tire = tire;
            DragCoefficient = dragCoefficient;
            Area = area;
        }
    }
}
