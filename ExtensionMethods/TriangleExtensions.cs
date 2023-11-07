namespace ExtensionMethods
{
    public static class TriangleExtensions
    {
        public static void PrintCoordinates(this Triangle triangle)
        {
            if (triangle is null)
            {
                throw new ArgumentNullException(nameof(triangle));
            }

            Console.WriteLine("Triangle: ");
            foreach (Point p in triangle.Points ?? new Point[0])
            {
                Console.WriteLine($"  - Point [X={p.X}, Y={p.Y}]");
            }
        }
    }
}
