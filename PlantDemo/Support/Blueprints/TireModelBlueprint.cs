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
                c = 1.0,
                b = 2.0,
                a = 3.0,
                Radius = 5.0,
                Inertia = 10,
                RPM = 1000,
                Friction = .9
            });
        }
    }
}