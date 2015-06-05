using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Plant.Core;

namespace PlantDemo.Support.Blueprints
{
    class DrivelineModelBlueprint : IBlueprint
    {
        public void SetupPlant(BasePlant plant)
        {
            plant.DefineConstructionOf<DrivelineModel>(new
            {
                AxelRatio = 0.5,
                AuxGearingRatio = 0.2
            });
        }
    }
}
