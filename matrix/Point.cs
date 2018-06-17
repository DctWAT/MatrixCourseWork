using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    public class Point
    {
        double x;
        double y;

        double value;

        public Point(double x, double y, double value)
        {
            this.x = x;
            this.y = y;
            this.value = value;
        }

        public Point()
        {
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

    }
}
