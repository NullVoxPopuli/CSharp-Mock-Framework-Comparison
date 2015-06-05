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
        public readonly double AuxGearingRatio;
        //        public readonly Sequence Sequence;

        public DrivelineModel(double axleRatio, double auxGearingRatio)
        {
            AxleRatio = axleRatio;
            AuxGearingRatio = auxGearingRatio;
            //          Sequence = sequence;
        }
    }
}