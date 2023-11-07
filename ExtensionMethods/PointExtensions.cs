using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class PointExtensions
    {
        public static void Rotate(this Point p, double angleDegrees)
        {
            double angleRadians = (Math.PI / 180) * angleDegrees;

            // see: https://en.wikipedia.org/wiki/Rotation_matrix
            double originalX = p.X;
            double originalY = p.Y;

            p.X = originalX * Math.Cos(angleRadians) - originalY * Math.Sin(angleRadians);
            p.Y = originalX * Math.Sin(angleRadians) + originalY * Math.Cos(angleRadians);
        }

        public static void Move(this Point p, double dx, double dy)
        {
            if (p is null)
            {
                throw new ArgumentNullException(nameof(p));
            }

            p.X += dx;
            p.Y += dy;
        }

        public static void PrintCoordinates(this Point p)
        {
            if (p is null)
            {
                throw new ArgumentNullException(nameof(p));
            }

            Console.WriteLine($"Point [X={p.X}, Y={p.Y}]");
        }

    }
}
