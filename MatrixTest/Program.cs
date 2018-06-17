using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using matrix;


namespace MatrixTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[,] matrixForApproximstion = new Point[5, 5] {
             {new Point (0,0,12), new Point (1,0,14), new Point(2,0,17), new Point(3,0,18), new Point(4,0,20)},
             {new Point (0,1,9),  new Point (1,1,11), new Point(2,1,13), new Point(3,1,15), new Point(4,1,17)},
             {new Point (0,2,6),  new Point (1,2,8),  new Point(2,2,10), null,              new Point(4,2,14)},
             {new Point (0,3,3),  new Point (1,3,5),  new Point(2,3,7),  new Point(3,3,9),  new Point(4,3,11)},
             {new Point (0,4,0),  new Point (1,4,2),  new Point(2,4,4),  new Point(3,4,6),  new Point(4,4,8)}};


            Matrix matrix = new Matrix(matrixForApproximstion);
            matrix.Checked();
            Console.Write(matrix.Get(2, 3));


            Console.ReadLine();
        }
    }
}
