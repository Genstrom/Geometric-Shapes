using System;
using System.Numerics;

namespace Shapes
{
    public abstract class Shape
    {
        private static readonly Random Rnd = new Random();
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        private static Vector3 RndVector3()
        {
            return new Vector3(RndFloat(), RndFloat(), RndFloat());
        }

        private static Vector2 RndVector2()
        {
            return new Vector2(RndFloat(), RndFloat());
        }

        private static float RndFloat()
        {
            var rndFloat = (float) Rnd.NextDouble() * 10.00f + 1.00f;
            return rndFloat;
        }

        private static Triangle CalculatedTriangle(Vector2 point1, Vector2 point2)
        {
            var centerPoint = RndVector2();
            var point3X = centerPoint.X * 3 - point1.X - point2.X;
            var point3Y = centerPoint.Y * 3 - point1.Y - point2.Y;
            var point3 = new Vector2(point3X, point3Y);
            var triangle = new Triangle(point1, point2, point3);
            return triangle;
        }


        public static Shape GenerateShape()
        {
            var shape = Rnd.Next(0, 7);


            switch (shape)
            {
                case 0:
                {
                    var circle = new Circle(RndVector2(), RndFloat());
                    return circle;
                }
                case 1:
                {
                    var rectangle = new Rectangle(RndVector2(), RndVector2());
                    return rectangle;
                }
                case 2:
                {
                    var square = new Rectangle(RndVector2(), RndFloat());
                    return square;
                }
                case 3:
                {
                    var triangle = CalculatedTriangle(RndVector2(), RndVector2());
                    return triangle;
                }
                case 4:
                {
                    var cube = new Cuboid(RndVector3(), RndFloat());
                    return cube;
                }
                case 5:
                {
                    var cuboid = new Cuboid(RndVector3(), RndVector3());
                    return cuboid;
                }
                case 6:
                {
                    var sphere = new Sphere(RndVector3(), RndFloat());
                    return sphere;
                }
            }


            return null;
        }

        public static Shape GenerateShape(Vector3 center)
        {
            var centerVector2 = new Vector2(center.X, center.Y);
            var shape = Rnd.Next(0, 7);


            switch (shape)
            {
                case 0:
                {
                    var circle = new Circle(centerVector2, RndFloat());
                    return circle;
                }
                case 1:
                {
                    var rectangle = new Rectangle(centerVector2, RndVector2());
                    return rectangle;
                }
                case 2:
                {
                    var square = new Rectangle(centerVector2, RndFloat());
                    return square;
                }
                case 3:
                {
                    var triangle = CalculatedTriangle(RndVector2(), RndVector2());
                    return triangle;
                }
                case 4:
                {
                    var cube = new Cuboid(center, RndFloat());
                    return cube;
                }
                case 5:
                {
                    var cuboid = new Cuboid(center, RndVector3());
                    return cuboid;
                }
                case 6:
                {
                    var sphere = new Sphere(center, RndFloat());
                    return sphere;
                }
            }


            return null;
        }
    }
}