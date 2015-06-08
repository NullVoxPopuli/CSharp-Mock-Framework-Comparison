using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryGirlCore;
using Models;

namespace FactoryGirlDemo.Support.Factories
{
    class DrivelineModelFactory : IDefinable
    {
        public void Define()
        {
                FactoryGirl.Define<DrivelineModel>(() => new DrivelineModel(
                    0.5, 0.2
                )
                {
                    // non read-only properties can be set here              
                });
        }
    }
}
