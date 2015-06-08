using Models;
using Plant.Core;

namespace PlantDemo.Support.Blueprints
{
    internal class TireModelBlueprint : IBlueprint
    {
        public void SetupPlant(BasePlant plant)
        {
            plant.DefineConstructionOf<TireModel>(new
            {
                SlidingFrictionCoefficient1 = 1.0,
                SlidingFricitonCoefficient2 = 2.0,
                SlidingFrictionCoefficient3 = 3.0,
                RollingRadius = 5.0,
                Inertia = 10,
                RevsPerMile = 1000,
                Friction = .9
            });
        }
    }
}