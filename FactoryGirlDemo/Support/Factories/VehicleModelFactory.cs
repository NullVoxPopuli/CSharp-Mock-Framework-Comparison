using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryGirlCore;
using Models;

namespace FactoryGirlDemo.Support.Factories
{
    class VehicleModelFactory : IDefinable
    {
        public void Define()
        {
            FactoryGirl.Define<VehicleModel>(() => new VehicleModel(
                area: 0,
                numberOfTires: 0,
                weight: 0,
                totalEfficiency: 0,
                totalRatio: 0,
                tire: FactoryGirl.Build<TireModel>(),
                dragCoefficient: 0)
            {
                // non read-only properties can be set here              
            });
        }
    }
}
