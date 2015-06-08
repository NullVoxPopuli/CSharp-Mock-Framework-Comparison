using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryGirlCore;
using Models;

namespace FactoryGirlDemo.Support.Factories
{
    class TireModelFactory : IDefinable
    {
        public void Define()
        {
            FactoryGirl.Define<TireModel>(() => new TireModel(
                1.0, 2.0, 3.0, 5.0, 10, 1000, .9
            ) {
                // non read-only properties can be set here
            });
        }
    }
}
