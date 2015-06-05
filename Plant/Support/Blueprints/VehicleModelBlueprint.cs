using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Models;
using Plant.Core;

namespace PlantDemo.Support.Blueprints
{
    class VehicleModelBlueprint : IBlueprint
    {
        public void SetupPlant(BasePlant plant)
        {
            plant.DefineConstructionOf<VehicleModel>(new
            {
                FrontalArea = 20.0,
                GrossVehicleWeight = 1234.00,
                NumberOfTires = 4,
                NumberOfWheels = 4,
                WeightOnDriveWheelsType = 2,
                WeightOnDriveWheels = 3000.0,
                OverallDrivelineRatio = .20,
                OverallDrivelineEfficiency = .90,

                DrivelineComponents = new LazyProperty<List<DrivelineModel>>(() =>
                {
                    Plant.Core.BasePlant p = new BasePlant().WithBlueprintsFromAssemblyOf<DrivelineModelBlueprint>();
                    List<DrivelineModel> collection = new List<DrivelineModel> {
                            p.Create<DrivelineModel>()
                        };
                    return collection;
                }),
                Tire = new LazyProperty<TireModel>(() => {
                    plant = new BasePlant().WithBlueprintsFromAssemblyOf<TireModelBlueprint>();
                    return plant.Create<TireModel>();          
                }),
                CrossSectionalArea = 2,
                DragCoefficient = 2
            });
        }
    }
}