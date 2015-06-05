using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TireModel
    {
        // Coefficients of Sliding Friction
        // ax² + bx + c 
        public readonly double SlidingFrictionCoefficient1; // c
        public readonly double SlidingFrictionCoefficient2; // b
        public readonly double SlidingFrictionCoefficient3; // a

        public readonly double RollingRadius;
        public readonly double Inertia;
        public readonly double RevsPerMile;
        public readonly double Friction;

        public TireModel(
            double slidingFrictionCoefficient1, 
            double slidingFrictionCoefficient2, 
            double slidingFrictionCoefficient3,
            double rollingRadius, 
            double inertia, 
            double revsPerMile, 
            double friction)
        {
            SlidingFrictionCoefficient1 = slidingFrictionCoefficient1;
            SlidingFrictionCoefficient2 = slidingFrictionCoefficient2;
            SlidingFrictionCoefficient3 = slidingFrictionCoefficient3;
            RollingRadius = rollingRadius;
            Inertia = inertia;
            RevsPerMile = revsPerMile;
            Friction = friction;
        }
    }
}
