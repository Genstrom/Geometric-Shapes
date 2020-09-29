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

        public override float Area
        {
            get
            {
                var area = 4 * Math.PI * Math.Pow(_radius, 2);
                return Convert.ToSingle(area);
            }
        }

        public override float Volume
        {
            get
            {
                var volume = 4 * Math.PI * Math.Pow(_radius, 3) / 3;
                return Convert.ToSingle(volume);
            }
        }

        public override string Name => "Sphere";


        public override string ToString()
        {
            return $"sphere @({_center.X:0.0}, {_center.Y:0.0}, {_center.Z:0.0}): r = {_radius:0.0}";
        }
    }
}