namespace ExtensionMethods
{
    public class Point
    {
        public Point(double x = 0D, double y = 0D)
        {
            X = x;
            Y = y;
        }

        public double X
        {
            get;
            set;
        }

        public double Y
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"[X={X}, Y={Y}]";
        }

        public static implicit operator string(Point p)
        {
            if (p is null)
            {
                return null;
            }

            return p.ToString();
        }


        public static explicit operator Point(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return null;
            }

            string textWithoutParantheses = text.Replace("[", string.Empty, StringComparison.OrdinalIgnoreCase)
                                                .Replace("]", string.Empty, StringComparison.OrdinalIgnoreCase);

            string[] parts = textWithoutParantheses.Split(",", StringSplitOptions.TrimEntries);

            string xCoordinate = parts.Length > 0 
                ? parts[0].Replace("X=", string.Empty, StringComparison.OrdinalIgnoreCase) 
                : "0";

            string yCoordinate = parts.Length > 1 
                ? parts[1].Replace("Y=", string.Empty, StringComparison.OrdinalIgnoreCase)
                : "0";

            if (double.TryParse(xCoordinate, out double x) &&
                double.TryParse(yCoordinate, out double y))
            {
                return new Point(x, y);
            }

            throw new InvalidCastException($"String '{text}' cannot be converted to a {nameof(Point)} instance.");
        }

    }
}
