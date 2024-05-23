﻿using System;
using System.Linq;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[,] { { -1 } };

        int rowSize = matrix1.GetLength(0);
        int colSize = matrix2.GetLength(1);
        var result = new double[rowSize, colSize];

        for (int row = 0; row < rowSize; row++)
        {
            for (int col = 0; col < colSize; col++)
            {
                result[row, col] = VectorMath.DotProduct(GetRow(matrix1, (uint)row), GetColumn(matrix2, (uint)col));
            }
        }

        return result;
    }

    public static double[] GetRow(double[,] matrix, uint row)
    {
        int size = matrix.GetLength(1);
        double[] r = new double[size];

        for (int i = 0; i < size; i++)
        {
            r[i] = matrix[row, i];
        }

        return r;
    }

    public static double[] GetColumn(double[,] matrix, uint column)
    {
        int size = matrix.GetLength(0);
        var col = new double[size];

        for (int i = 0; i < size; i++)
        {
            col[i] = matrix[i, column];
        }

        return col;
    }
}

class VectorMath
{
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        int size = vector1.Length;

        if (size != vector2.Length || !(IsVector(vector1) && IsVector(vector2)))
            return -1;

        double[] dot = new double[size];

        for (int i = 0; i < size; i++)
        {
            dot[i] = vector1[i] * vector2[i];
        }

        return dot.Sum();
    }

    public static double Magnitude(double[] vector)
    {
        int size = vector.Length;

        if (size < 2 || size > 3)
            return -1;

        double magnitude = 0;

        for (int i = 0; i < size; i++)
        {
            magnitude += vector[i] * vector[i];
        }

        return Math.Round(Math.Sqrt(magnitude), 1);
    }

    public static double[] Add(double[] vector1, double[] vector2)
    {
        int size = vector1.Length;
        double[] sum = new double[size];

        if (size != vector2.Length || !IsVector(vector1) || !IsVector(vector2))
            return new double[] { -1 };

        for (int i = 0; i < size; i++)
        {
            sum[i] = vector1[i] + vector2[i];
        }

        return sum;
    }

    static bool IsVector(double[] vec)
    {
        int size = vec.Length;
        return size == 2 || size == 3;
    }

    public static double[] Multiply(double[] vector, double scalar)
    {
        if (!IsVector(vector))
            return new double[] { -1 };

        for (int i = 0; i < vector.Length; i++)
        {
            vector[i] *= scalar;
        }

        return vector;
    }
}

