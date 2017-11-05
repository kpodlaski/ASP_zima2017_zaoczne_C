using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp {
    class Point2D : IComparable<Point2D>, IMovable2D {
        public double X { get; set; }
        public double Y;
        private double _radius;
        public double radius {
            get {
                return _radius; //Math.Sqrt(X * X + Y * Y);
            }
            set {
                _radius = value;
            }
        }

        public Point2D(double x, double y) {
            X=x;
            this.Y = y;
        }

        public override string ToString() {
            return "(" + X + "," + Y + ")";
        }

        public double R() {
            double c=this.radius;
            this.radius = 12;
            return Math.Sqrt(X * X + Y * Y);
        }

        public int CompareTo(Point2D other) {
            return Math.Sign(R()-other.R());
        }

        public void Move(Point2D vector) {
            this.X += vector.X;
            this.Y += vector.Y;
        }

        public void Move(double x, double y) {
            this.X += x;
            this.Y += y;
        }
    }

    class Point2DYComparer : IComparer<Point2D> {
        public int Compare(Point2D a, Point2D b) {
            return Math.Sign(a.Y - b.Y);
        }
    }
}
