namespace ExtensionMethods
{
    public class Square : IShape
    {
        public Square(
            Point topLeft,
            double width)
        {
            TopLeft = topLeft ?? throw new ArgumentNullException(nameof(topLeft));
            TopRight = new Point(topLeft.X + width, topLeft.Y);
            BottomRight = new Point(topLeft.X + width, topLeft.Y + width);
            BottomLeft = new Point(topLeft.X, topLeft.Y + width);
            Width = width;
        }

        public Point TopLeft { get; }

        public Point TopRight { get; }

        public Point BottomRight { get; }

        public Point BottomLeft { get; }

        public double Width { get; }

        public Point[] Points
        {
            get
            {
                return new[] { TopLeft, TopRight, BottomRight, BottomLeft };
            }
        }

        public double GetArea()
        {
            return Width * Width;
        }
    }
}
