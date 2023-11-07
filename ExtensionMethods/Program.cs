namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(100, 100);
            p.Move(10, 10);
            p.PrintCoordinates();

            string textPoint = p;
            Console.WriteLine(textPoint);

            string text = "[X=110, Y=110]";
            Point p2 = (Point)text;
            p2.PrintCoordinates();

            Triangle t = new Triangle(
                new Point(10, 10),
                new Point(100, 20),
                new Point(70, 100));

            t.Move(10, 10);
            t.PrintCoordinates();


            Square square = new Square(
                new Point(50, 50),
                100);

            square.Move(20, 20);
            square.PrintCoordinates();
        }
    }
}