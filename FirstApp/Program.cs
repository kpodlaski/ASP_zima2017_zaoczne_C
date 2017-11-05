using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Tekst");
            Point2D p = new Point2D(12.3, 45);
            Console.WriteLine(p);
            List<Point2D> punkty = new List<Point2D>();
            punkty.Add(p);
            punkty.Add(new FirstApp.Point2D(1, 1));
            punkty.Add(new FirstApp.Point2D(1, -1));
            punkty.Add(new FirstApp.Point2D(100, 1));
            Console.WriteLine("Przed Sortowaniem");
            foreach (Point2D point in punkty) {
                Console.WriteLine(point);
            }
            punkty.Sort();
            Console.WriteLine("Po Sortowaniu");
            foreach (Point2D point in punkty) {
                Console.WriteLine(point);
            }

            punkty.Sort(new Point2DYComparer());
            Console.WriteLine("Po Sortowaniu po Y");
            foreach (Point2D point in punkty) {
                Console.WriteLine(point);
            }

            punkty[1].X = 12;

            //Map in C#
            Dictionary<String, Point2D> dict = new Dictionary<String, Point2D>();
            dict["Punkt Startowy"] = punkty[0];
            dict["Punkt Końcowy"] = punkty[2];

            int l = punkty.ToArray().Length;
            l = punkty.Count;
            Console.ReadLine();
        }
    }
}
