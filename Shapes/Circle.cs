using System;
using System.Numerics;

namespace Shapes
{
    public class Circle : Shape2D
    {
        private readonly Vector2 _center;
        private readonly float _radius;


        public Circle(Vector2 center, float radius)
        {
            _center = center;
            _radius = radius;
        }

        public override float Circumference => _radius * (2 * MathF.PI);

        public override float Area => MathF.Pow(_radius, 2) * MathF.PI;

        public override Vector3 Center => new Vector3(_center.X, _center.Y, 0);

        public override string ToString()
        {
            return $"circle @({_center.X:0.00}, {_center.Y:0.00}): r = {_radius:0.00}";
        }
    }
}