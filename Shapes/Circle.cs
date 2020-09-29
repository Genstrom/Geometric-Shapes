using System;
using System.Numerics;

namespace Shapes
{
    public class Circle : Shape2D
    {
        private readonly Vector2 _center;
        private readonly float _radius;

        //Constructors

        public Circle(Vector2 center, float radius)
        {
            _center = center;
            _radius = radius;
        }

        public override float Circumference
        {
            get
            {
                var circumference = _radius * (2 * Math.PI);
                var circumferenceAsFloat = Convert.ToSingle(circumference);
                return circumferenceAsFloat;
            }
        }

        public override float Area
        {
            get
            {
                var area = Math.Pow(_radius, 2) * Math.PI;
                var areaAsFloat = Convert.ToSingle(area);
                return areaAsFloat;
            }
        }

        public override Vector3 Center
        {
            get
            {
                var centerPoint = new Vector3(_center, 0);
                return centerPoint;
            }
        }


        public override string ToString()
        {
            return $"circle @({_center.X:0.0}, {_center.Y:0.0}): r = {_radius:0.0}";
        }
    }
}