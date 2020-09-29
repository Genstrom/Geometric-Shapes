namespace Shapes
{
    public abstract class Shape3D : Shape
    {
        public abstract float Volume { get; }
        public abstract string Name { get; }
    }
}