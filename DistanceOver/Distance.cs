using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceOver
{
    class Distance
    {
        public int feet;
        public float inch;

        public Distance() { }
        public Distance(int feet, float inch)
        {
            this.feet = feet;
            this.inch = inch;
        }
        public static Distance operator + (Distance d1, Distance d2)
        {
            float t1 = TotalInches(d1.feet, d1.inch);
            float t2 = TotalInches(d2.feet, d2.inch);
            int feet = (int)(t1 + t2) / 12;
            float inch = (float)(t1 + t2) % 12;
            return new Distance(feet, inch);
        }
        public static Distance operator -(Distance d1, Distance d2)
        {
            float t1 = TotalInches(d1.feet, d1.inch);
            float t2 = TotalInches(d2.feet, d2.inch);
            int feet = Math.Abs((int)(t1 - t2) / 12);
            float inch = Math.Abs((float)(t1 - t2) % 12);
            return new Distance(feet, inch);
        }

        private static float TotalInches(int feet, float inch)
        {
            return (feet * 12 + inch);
        }
        public override string ToString()
        {
            return $"{feet}'-{inch}\"";
        }
    }
}
