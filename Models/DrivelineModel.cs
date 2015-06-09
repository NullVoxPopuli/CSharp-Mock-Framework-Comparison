using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class DrivelineModel
    {
        public readonly double AxleRatio;
        public readonly double GearRatio;

        public DrivelineModel(double axleRatio, double gearRatio)
        {
            AxleRatio = axleRatio;
            GearRatio = gearRatio;
        }
    }
}