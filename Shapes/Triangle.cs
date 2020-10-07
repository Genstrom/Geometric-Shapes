using System;
using System.Collections;
using System.Numerics;

namespace Shapes
{
    public class Triangle : Shape2D, IEnumerable, IEnumerator
    {
        private readonly Vector2 _pointA;
        private readonly Vector2[] _pointArray;
        private readonly Vector2 _pointB;
        private readonly Vector2 _pointC;
        private int _idx = -1;


        public Triangle(Vector2 pointA, Vector2 pointB, Vector2 pointC)
        {
            _pointA = pointA;
            _pointB = pointB;
            _pointC = pointC;
            _pointArray = new[] {pointA, pointB, pointC};
        }
        
        public override Vector3 Center
        {
            get
            {
                var x = (_pointA.X + _pointB.X + _pointC.X) / 3.00f;
                var y = (_pointA.Y + _pointB.Y + _pointC.Y) / 3.00f;

                return new Vector3(x, y, 0);
            }
        }

        public override float Area
        {
            get
            {
                var a = _pointA.X * (_pointB.Y - _pointC.Y);
                var b = _pointB.X * (_pointC.Y - _pointA.Y);
                var c = _pointC.X * (_pointA.Y - _pointB.Y);

                var area = a + b + c;
                area = MathF.Abs(area) / 2.00f;
                return area;
            }
        }

        public override float Circumference
        {
            get
            {
                var a = MathF.Sqrt(MathF.Pow(_pointB.X - _pointC.X, 2) + MathF.Pow(_pointB.Y - _pointC.Y, 2));
                var b = MathF.Sqrt(MathF.Pow(_pointA.X - _pointC.X, 2) + MathF.Pow(_pointA.Y - _pointC.Y, 2));
                var c = MathF.Sqrt(MathF.Pow(_pointA.X - _pointB.X, 2) + MathF.Pow(_pointA.Y - _pointB.Y, 2));
               var circumference = a + b + c;
               return circumference;

            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public object Current => _pointArray[_idx];

        public bool MoveNext()
        {
            _idx++;
            return _idx < _pointArray.Length;
        }

        public void Reset()
        {
            _idx = -1;
        }

        public override string ToString()
        {
            return
                $"triangle @({Center.X:0.00}, {Center.Y:0.00}): p1({_pointA.X:0.00}, {_pointA.Y:0.00}), p2({_pointB.X:0.00}, {_pointB.Y:0.00}), p3({_pointC.X:0.00}, {_pointC.Y:0.00})";
        }
    }
}