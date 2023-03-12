using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Lab2
{
    internal class Circle
    {
        public float radius;
        public Circle()
        { this.radius = 1.0f; }
        public Circle(float radius)
        {
            this.radius = radius;
        }
        public float GetRadius()
        { return this.radius; }
        public void SetRadius(float radius) { this.radius = radius; }
        public float GetPerimeter()
        { return (float)PI * 2 * this.radius; }
        public float GetArea()
        { return (float)PI * this.radius * this.radius; }

    }
}
