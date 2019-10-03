using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzd1
{
    public class Rectangle
    {
        private float width; private float height;
        public float Area() => throw new NotImplementedException();
        public float Perimiter() => throw new NotImplementedException();
    }

    public class Circle
    {
        private float radius;
        public float Area() => throw new NotImplementedException();
        public float Circumference() => throw new NotImplementedException();
    }

    public class Cuboid
    {
        private float width; private float height; private float length;
        public float SurfaceArea() => throw new NotImplementedException();
        public float Volume() => throw new NotImplementedException();
    }

    public class Cone
    {
        private float radius; private float height;
        public float SurfaceArea() => throw new NotImplementedException();
        public float Volume() => throw new NotImplementedException();
        public float BaseArea() => throw new NotImplementedException();
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
