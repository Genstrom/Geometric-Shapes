using System.Numerics;

namespace Shapes
{
    public class Cuboid : Shape3D
    {
        private readonly Vector3 _center;
        private readonly Vector3 _size;
        
        public Cuboid(Vector3 center, Vector3 size)
        {
            _center = center;
            _size = size;
        }

        public Cuboid(Vector3 center, float width)
        {
            _center = center;
            _size = new Vector3(width, width, width);
        }

        public override Vector3 Center => new Vector3(_center.X, _center.Y, _center.Z);

        public override float Area => 2 * (_size.X * _size.Y + _size.Y * _size.Z + _size.Z * _size.X);

        public override float Volume => _size.X * _size.Y * _size.Z;

        public override string Name =>
            _size.X == _size.Y && _size.X == _size.Z && _size.Y == _size.Z
                ? "cube"
                : "cuboid";

        public override string ToString()
        {
            var measures =
                $"@({_center.X:0.00}, {_center.Y:0.00}, {_center.Z:0.00}): w = {_size.X:0.00}, h = {_size.Y:0.00}, l = {_size.Z:0.00}";
            return _size.X == _size.Y && _size.X == _size.Z && _size.Y == _size.Z
                ? $"cube {measures}"
                : $"cuboid {measures}";
        }
    }
}