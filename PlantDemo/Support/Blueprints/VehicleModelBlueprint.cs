using System.Collections.Generic;
using Models;
using Plant.Core;

namespace PlantDemo.Support.Blueprints
{
    public class VehicleModelBlueprint : IBlueprint
    {
        public void SetupPlant(BasePlant plant)
        {
            plant.DefineConstructionOf<VehicleModel>(new
            {
                Area = 20.0,
                Weight = 1234.00,
                NumberOfTires = 4,
                TotalRatio = .20,
                TotalEfficiency = .90,
                Tire = new LazyProperty<TireModel>(() =>
                {
                    plant = new BasePlant().WithBlueprintsFromAssemblyOf<TireModelBlueprint>();
                    return plant.Create<TireModel>();
                }),
                DragCoefficient = 2
            });
        }
    }
}