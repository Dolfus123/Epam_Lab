using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    public class Program
    {
        public class Vector
        {
            private int x, y, z;
            public Vector()
            {
                x = 0;
                y = 0;
                z = 0;
            }
            public Vector(int x1, int y1, int z1)
            {
                x = x1;
                y = y1;
                z = z1;
            }
            public void outVector()
            {
                Console.WriteLine("вектор (x, y, z): {0} , {1} , {2} ;", x, y, z);
            }
            public static Vector operator +(Vector v1, Vector v2)
            {
                return new Vector
                {
                    x = v1.x + v2.x,
                    y = v1.y + v2.y,
                    z = v1.z + v2.z
                };
            }
            public static int operator *(Vector v1, Vector v2)
            {
                return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
            }
        };

        public class MultiMember
        {
            double[] Matrix;
            int Degree;

            public MultiMember(double[] matrix, int degree)
            {
                Matrix = matrix;
                Degree = degree;
            }


            public static MultiMember operator +(MultiMember A, MultiMember B)
            {
                int D1 = A.Degree;
                double[] M1 = new double[D1 + 1];
                MultiMember C = new MultiMember(M1, D1);
                for (int i = 0; i < A.Degree + 1; i++)
                {
                    C.Matrix[i] = A.Matrix[i] + B.Matrix[i];
                }

                return C;
            }
            public static MultiMember operator -(MultiMember A, MultiMember B)
            {
                int D1 = A.Degree;
                double[] M1 = new double[D1 + 1];
                MultiMember C = new MultiMember(M1, D1);
                for (int i = 0; i < A.Degree + 1; i++)
                {
                    C.Matrix[i] = A.Matrix[i] - B.Matrix[i];
                }

                return C;
            }
            public static MultiMember operator *(MultiMember A, MultiMember B)
            {
                int D1 = A.Degree;
                double[] M1 = new double[D1 + 1];
                MultiMember C = new MultiMember(M1, D1);
                for (int i = 0; i < A.Degree + 1; i++)
                {
                    C.Matrix[i] = A.Matrix[i] * B.Matrix[i];
                    //C.Degree = A.Degree * B.Degree;
                }

                return C;
            }
            public int Vivod(MultiMember A)
            {
                for (int i = 0; i <= Degree; i++)
                {
                    Console.Write(A.Matrix[i] + "X" + "^" + (Degree - i) + "+");
                }
                return 0;
            }
            public double this[int i]
            {
                get { return Matrix[i]; }
                set { Matrix[i] = value; }
            }
        };
        static void Main(string[] args)
        {
            Vector obj = new Vector(1, 2, 3);
            Vector obj1 = new Vector(1, 1, 1);
            Console.WriteLine("сумма векторов: ");
            Vector k = obj + obj1;
            k.outVector();
            Console.WriteLine();
            Console.WriteLine("скалярное произведние векторов: ");
            int p = obj * obj1;
            Console.WriteLine(p);

            int Degree = 2;
            int n = Degree + 1;//Длина многочлена  
            double[] Matrix = { 1, 2, 3 };
            MultiMember A = new MultiMember(Matrix, Degree);
            int Degree2 = 2;
            int n2 = Degree2 + 1;
            double[] Matrix2 = { 4, 5, 6 };

            MultiMember B = new MultiMember(Matrix2, Degree2);
            MultiMember C = A + B;
            MultiMember D = A - B;
            MultiMember E = A * B;
            Console.Write("A=");
            Console.WriteLine(A.Vivod(A));

            Console.Write("B=");
            Console.WriteLine(B.Vivod(B));

            Console.Write("A+B=");
            Console.WriteLine(C.Vivod(C) + "\n");
            Console.Write("A-B=");
            Console.WriteLine(D.Vivod(D) + "\n");
            Console.Write("A*B=");
            Console.WriteLine(E.Vivod(E) + "\n");

            Console.ReadLine();
        }
    }
}
