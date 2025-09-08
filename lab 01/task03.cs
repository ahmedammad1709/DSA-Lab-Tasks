//Program to calculate Addition, Subtraction, Multiplication, Determinant and inverse of Matrix
using System;
class Program
{
    static void Main()
    {
        Console.Write("Ente Row of 1st Matrix : ");
        int row1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ente Coloumn of 1st Matrix : ");
        int col1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ente row of 2nd Matrix : ");
        int row2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ente coloumn of 2nd Matrix : ");
        int col2 = Convert.ToInt32(Console.ReadLine());

        int[,] matrix1 = new int[row1, col1];
        int[,] matrix2 = new int[row2, col2];

        int[,] addMatrix = new int[row1, col1];
        int[,] subMatrix = new int[row1, col1];

        //Input Matrix 01
        Console.WriteLine("--For Matrix 01--");
        for (int i = 0; i < row1; i++)
        {
            for (int j = 0; j < col1; j++)
            {
                Console.Write("Enter value for " + i + " " + j + " : ");
                int num = Convert.ToInt32(Console.ReadLine());
                matrix1[i, j] = num;
            }
        }
        //Input Matrix 02
        Console.WriteLine("--For Matrix 02--");
        for (int i = 0; i < row2; i++)
        {
            for (int j = 0; j < col2; j++)
            {
                Console.Write("Enter value for " + i + " " + j + " : ");
                int num = Convert.ToInt32(Console.ReadLine());
                matrix2[i, j] = num;
            }
        }


        //Addition of matrix
        if (col1 == col2 && row1 == row2)
        {
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    addMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                    subMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
        }
        else
        {
            Console.WriteLine("Addition/Subtraction is not Possible !");
        }

        Console.WriteLine("\n---Printing after Addition----");
        printMatrix(addMatrix);

        Console.WriteLine("\n---Printing after Subtraction----");
        printMatrix(subMatrix);

        int[,] mulMatrix = new int[row1, col2];

        //Multiplication
        if (col1 == row2)
        {
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    for (int k = 0; k < col1; k++)
                    {
                        mulMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("\nMultiplication is not Possible !");
        }

        Console.WriteLine("\n---Printing after Multiplication----");
        printMatrix(mulMatrix);

        // Determinant & Inverse of Matrix 1
        if (row1 == col1)
        {
            int det1 = Determinant(matrix1, row1);
            Console.WriteLine("\nDeterminant of Matrix 1 = " + det1);

            if (det1 != 0)
            {
                double[,] inv1 = new double[row1, row1];
                if (Inverse(matrix1, inv1, row1))
                {
                    Console.WriteLine("Inverse of Matrix 1:");
                    printMatrix(inv1);
                }
            }
            else
            {
                Console.WriteLine("Matrix 1 has no inverse (determinant = 0).");
            }
        }
        else
        {
            Console.WriteLine("\nMatrix 1 is not square, determinant/inverse not possible.");
        }

        // Determinant & Inverse of Matrix 2
        if (row2 == col2)
        {
            int det2 = Determinant(matrix2, row2);
            Console.WriteLine("\nDeterminant of Matrix 2 = " + det2);

            if (det2 != 0)
            {
                double[,] inv2 = new double[row2, row2];
                if (Inverse(matrix2, inv2, row2))
                {
                    Console.WriteLine("Inverse of Matrix 2:");
                    printMatrix(inv2);
                }
            }
            else
            {
                Console.WriteLine("Matrix 2 has no inverse (determinant = 0).");
            }
        }
        else
        {
            Console.WriteLine("\nMatrix 2 is not square, determinant/inverse not possible.");
        }

        Console.ReadLine();
    }

    // Print int matrix
    static void printMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Print double matrix (for inverse)
    static void printMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(Math.Round(matrix[i, j], 2) + "\t");
            }
            Console.WriteLine();
        }
    }

    static int Determinant(int[,] matrix, int n)
    {
        if (n == 1) return matrix[0, 0];
        if (n == 2) return (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);

        int det = 0;
        for (int p = 0; p < n; p++)
        {
            int[,] subMatrix = new int[n - 1, n - 1];
            for (int i = 1; i < n; i++)
            {
                int colIndex = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j == p) continue;
                    subMatrix[i - 1, colIndex] = matrix[i, j];
                    colIndex++;
                }
            }
            det += matrix[0, p] * (int)Math.Pow(-1, p) * Determinant(subMatrix, n - 1);
        }
        return det;
    }

    // Helper for Cofactor
    static void GetCofactor(int[,] matrix, int[,] temp, int p, int q, int n)
    {
        int i = 0, j = 0;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (row != p && col != q)
                {
                    temp[i, j++] = matrix[row, col];

                    if (j == n - 1)
                    {
                        j = 0;
                        i++;
                    }
                }
            }
        }
    }

    // Adjoint
    static void Adjoint(int[,] matrix, int[,] adj, int n)
    {
        if (n == 1)
        {
            adj[0, 0] = 1;
            return;
        }

        int sign;
        int[,] temp = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                GetCofactor(matrix, temp, i, j, n);
                sign = ((i + j) % 2 == 0) ? 1 : -1;
                adj[j, i] = sign * Determinant(temp, n - 1);
            }
        }
    }

    // Inverse
    static bool Inverse(int[,] matrix, double[,] inverse, int n)
    {
        int det = Determinant(matrix, n);
        if (det == 0)
        {
            return false;
        }

        int[,] adj = new int[n, n];
        Adjoint(matrix, adj, n);

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                inverse[i, j] = adj[i, j] / (double)det;

        return true;
    }
}
