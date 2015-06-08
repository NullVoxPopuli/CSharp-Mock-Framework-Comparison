using Models;
using Plant.Core;

namespace PlantDemo.Support.Blueprints
{
    internal class DrivelineModelBlueprint : IBlueprint
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