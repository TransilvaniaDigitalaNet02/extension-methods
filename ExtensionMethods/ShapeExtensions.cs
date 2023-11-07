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
    }
}
