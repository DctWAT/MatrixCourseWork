using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    public class Matrix
    {
        public Point[,] matrix;

        public Matrix(Point[,] newMatrix)
        {
            this.matrix = newMatrix;
        }

        public void Checked()
        {
            ArrayList results = new ArrayList();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == null)
                    {
                        Point point = new Point();

                        point.Value = (FindValue(i , j, FindSupportPoints(i, j)));
                        point.X = j;
                        point.Y = i;

                        matrix[i, j] = point;
                    }
                }
            }
        }

        private Point[] FindSupportPoints(int i, int j)
        {
            Point[] supportPoint = new Point[4];

            int helpI = i;
            int helpJ = j;


            while (helpI + 1 < matrix.GetLength(0) && helpJ + 1 < matrix.GetLength(1) && helpI - 1 > 0 && helpJ - 1 > 0)
            {
                int difference = 1;

                if (matrix[helpI - difference, helpJ - difference] != null &&
                    matrix[helpI + difference, helpJ - difference] != null &&
                    matrix[helpI - difference, helpJ + difference] != null &&
                    matrix[helpI + difference, helpJ + difference] != null)
                {
                    supportPoint[0] = matrix[helpI - difference, helpJ - difference];
                    supportPoint[1] = matrix[helpI + difference, helpJ - difference];
                    supportPoint[2] = matrix[helpI - difference, helpJ + difference];
                    supportPoint[3] = matrix[helpI + difference, helpJ + difference];

                    return supportPoint;
                }
                else difference++;
            }

            if (supportPoint[0] == null || supportPoint[1] == null || supportPoint[2] == null || supportPoint[3] == null)
            {
                throw new Exception("Нет допустимых значений для дополнительных точек");
            }
            return null;
        }

        public Double FindValue(int i, int j, Point[] supportPoint)
        {
            Double R1 = 0;
            Double R2 = 0;

            R1 = (supportPoint[0].Value + ((j - supportPoint[0].X) * ((supportPoint[2].Value - supportPoint[0].Value) / (supportPoint[2].X - supportPoint[0].X))));
            R2 = supportPoint[1].Value + ((j - supportPoint[0].X) * ((supportPoint[3].Value - supportPoint[1].Value) / (supportPoint[2].X - supportPoint[0].X)));

            return R1 + (i - supportPoint[0].Y) * ((R2 - R1) / supportPoint[1].Y - supportPoint[0].Y);
        }

        public Double Get(int i, int j)
        {
            return matrix[i, j].Value;
        }
    }
}
