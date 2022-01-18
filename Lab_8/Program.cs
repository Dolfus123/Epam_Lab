using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Program
    {
        public class Matrix
        {
            private int n;
            public int[,] mass;
            public Matrix() { }
            public Matrix(int n)
            {
                if (n > 0 )
                {
                    this.n = n;

                    mass = new int[this.n, this.n];
                }
                else
                {
                    Console.WriteLine("Размер матрицы не может быть отрицательным");
                }
                
            }
            public int this[int i, int j]
            {
                get
                {
                    return mass[i, j];
                }
                set
                {
                    mass[i, j] = value;
                }
            }

            public void WriteMat()
            {
                
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine("Введите элемент матрицы {0}:{1}", i + 1, j + 1);
                        try
                        {
                            mass[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("вы ввели не число");
                            //throw;
                        }
                    }
                }
            }

            public void ReadMat()
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(mass[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            public static Matrix operator *(Matrix a, Matrix b)
            {
                Matrix resMass = new Matrix(a.N);
                for (int i = 0; i < a.N; i++)
                    for (int j = 0; j < b.N; j++)
                        for (int k = 0; k < b.N; k++)
                            resMass[i, j] += a[i, k] * b[k, j];

                return resMass;
            }
            public static Matrix operator -(Matrix a, Matrix b)
            {
                Matrix resMass = new Matrix(a.N);
                for (int i = 0; i < a.N; i++)
                {
                    for (int j = 0; j < b.N; j++)
                    {
                        resMass[i, j] = a[i, j] - b[i, j];
                    }
                }
                return resMass;
            }
            public static Matrix operator +(Matrix a, Matrix b)
            {
                Matrix resMass = new Matrix(a.N);
                for (int i = 0; i < a.N; i++)
                {
                    for (int j = 0; j < b.N; j++)
                    {
                        resMass[i, j] = a[i, j] + b[i, j];
                    }
                }
                return resMass;
            }
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите размерность матрицы: ");
            int nn = Convert.ToInt32(Console.ReadLine());
            
            Matrix mass1 = new Matrix(nn);
            Matrix mass2 = new Matrix(nn);
            Matrix mass3 = new Matrix(nn);
            Matrix mass4 = new Matrix(nn);
            Matrix mass5 = new Matrix(nn);
            
            Console.WriteLine("ввод Матрица А: ");
            mass1.WriteMat();
            Console.WriteLine("Ввод Матрица B: ");
            mass2.WriteMat();

            Console.WriteLine("Матрица А: ");
            mass1.ReadMat();
            Console.WriteLine();
            Console.WriteLine("Матрица В: ");
            Console.WriteLine();
            mass2.ReadMat();

            Console.WriteLine("Сложение матриц А и Б: ");
            mass3 = (mass1 + mass2);
            mass3.ReadMat();

            Console.WriteLine("Вычитание матриц А и Б: ");
            mass4 = (mass1 - mass2);
            mass4.ReadMat();

            Console.WriteLine("Умножение матриц А и Б: ");
            mass5 = (mass1 * mass2);
            mass5.ReadMat();

            Console.ReadKey();
        }
    }
}
