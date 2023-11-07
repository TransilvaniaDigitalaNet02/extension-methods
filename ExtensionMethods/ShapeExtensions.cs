namespace ExtensionMethods
{
    public static class ShapeExtensions
    {
        public static void Move(this IShape shape, double dx, double dy)
        {
            if (shape is null)
            {
                throw new ArgumentNullException(nameof(shape));
            }

            foreach (Point p in shape.Points ?? new Point[0])
            {
                p.Move(dx, dy);
            }
        }

        public static void Rotate(this IShape shape, double angleDegrees)
        {
            if (shape is null)
            {
                throw new ArgumentNullException(nameof(shape));
            }

            foreach (Point p in shape.Points ?? new Point[0])
            {
                p.Rotate(angleDegrees);
            }
        }

        public static void PrintCoordinates(this IShape shape)
        {
            if (shape is null)
            {
                throw new ArgumentNullException(nameof(shape));
            }

            Type shapeType = shape.GetType();

            Console.WriteLine(shapeType.Name);
            foreach (Point p in shape.Points ?? new Point[0])
            {
                Console.WriteLine($"  - Point [X={p.X}, Y={p.Y}]");
            }
        }
    }
}
