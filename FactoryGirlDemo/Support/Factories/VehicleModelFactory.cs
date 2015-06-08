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
                20.0, 1234.00, 4, 4, 2, 3000.0, .20, .90, 
                new List<DrivelineModel>()
                {
                   FactoryGirl.Build<DrivelineModel>() 
                }, 
                FactoryGirl.Build<TireModel>(),
                2, 2      
            )
            {
                // non read-only properties can be set here              
            });
        }
    }
}
