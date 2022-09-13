using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(4, 4);
            Matrix matrix2 = new Matrix(2, 2);
            Matrix matrix3 = new Matrix(2, 2);
            Matrix matrix4 = new Matrix(3, 3);

            Console.WriteLine("Сумма первой и второй матрицы:");
            matrix1.Sum(matrix2);
            matrix1.Print();

            Console.WriteLine("Умножение:");
            matrix4.Multiply(7); // Ввести число для умножения
            matrix4.Print();
            
            Console.WriteLine("Умножение матрицы на матрицу:");
            matrix2.MatrixMatrix(matrix3);
            matrix2.Print();
        }
    }
}
