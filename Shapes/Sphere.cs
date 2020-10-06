using System;
using System.Numerics;

namespace Shapes
{
    public class Sphere : Shape3D
    {
        private readonly Vector3 _center;
        private readonly string _name;
        private readonly float _radius;

        public Sphere(Vector3 center, float radius)
        {
            _center = center;
            _radius = radius;
            _name = "Sphere";
        }

        public override Vector3 Center => new Vector3(_center.X, _center.Y, _center.Z);

        public override float Area => 4 * MathF.PI * MathF.Pow(-_radius, 2);

        public override float Volume => 4 * MathF.PI * MathF.Pow(_radius, 3) / 3;

        public override string Name => "Sphere";

        public override string ToString()
        {
            return $"sphere @({_center.X:0.00}, {_center.Y:0.00}, {_center.Z:0.00}): r = {_radius:0.00}";
        }
    }
}