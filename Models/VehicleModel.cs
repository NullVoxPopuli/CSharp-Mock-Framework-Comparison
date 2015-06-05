using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VehicleModel
    {
        public readonly double GrossVehicleWeight;
        public readonly double CenterGravityHeight;

        // ???
        public readonly int NumberOfPowerPacks;

        // Chassis
        public readonly double WheelBase;
        public readonly int NumberOfTires;
        public readonly int NumberOfWheels; // Artifact from ATOM?
        public readonly int WeightOnDriveWheelsType; // Replace with Enum
        public readonly double WeightOnDriveWheels;
        public readonly double OverallDrivelineRatio;
        public readonly double OverallDrivelineEfficiency;
        public readonly List<DrivelineModel> DrivelineComponents;

        // Body
        public readonly double FrontalArea;
        public readonly double CrossSectionalArea;
        public readonly double DragCoefficient;

        // Tire 
        public readonly TireModel Tire;


        public VehicleModel(
            double frontalArea, 
            double grossVehicleWeight, 
            int numberOfTires, 
            int numberOfWheels,
            int weightOnDriveWheelsType, 
            double weightOnDriveWheels, 
            double overallDrivelineRatio, 
            double overallDRivelineEfficiency,
            List<DrivelineModel> drivelineComponents, 
            TireModel tire, 
            double dragCoefficient, 
            double crossSectionalArea)
        {
            FrontalArea = frontalArea;
            GrossVehicleWeight = grossVehicleWeight;
            NumberOfTires = numberOfTires;
            NumberOfWheels = numberOfWheels;
            WeightOnDriveWheelsType = weightOnDriveWheelsType;
            WeightOnDriveWheels = weightOnDriveWheels;
            OverallDrivelineRatio = overallDrivelineRatio;
            OverallDrivelineEfficiency = overallDRivelineEfficiency;
            Tire = tire;
            DragCoefficient = dragCoefficient;
            CrossSectionalArea = crossSectionalArea;
            DrivelineComponents = drivelineComponents;
        }
    }
}
