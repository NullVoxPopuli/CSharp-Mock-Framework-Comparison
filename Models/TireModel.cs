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
        public readonly double c; // c
        public readonly double b; // b
        public readonly double a; // a

        public readonly double Radius;
        public readonly double Inertia;
        public readonly double RPM;
        public readonly double Friction;

        public TireModel(
            double cin, 
            double bin, 
            double ain,
            double radius, 
            double inertia, 
            double rpm, 
            double friction)
        {
            c = cin;
            b = bin;
            a = ain;
            Radius = radius;
            Inertia = inertia;
            RPM = rpm;
            Friction = friction;
        }
    }
}
