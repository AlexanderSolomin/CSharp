using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeHierarchy
{
    abstract class Shape
    {
        protected string shapeName;
        abstract public double P();
        abstract public double S();
        public Shape (string shapeName)
        {
            this.shapeName = shapeName;
        }
        public Shape () { }
        public string GetShapeName()
        {
            return shapeName;
        }
        public void Print() 
        {
            Console.WriteLine("Фигура: {0}", shapeName);
        }
    }
}
