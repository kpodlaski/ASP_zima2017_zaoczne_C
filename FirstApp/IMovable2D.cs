using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp {
    interface IMovable2D {
        void Move(Point2D vector);
        void Move(double x, double y);

    }
}
