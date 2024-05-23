using System;

class MainClass {
  public static void Main (string[] args) {
    double[,] matrix = {
      { 4, 7 },
      { 2, 6 }
    };
    
    double[,] inverseMatrix = MatrixMathLibrary.MatrixMath.Inverse2D(matrix);
    for (int i = 0; i < inverseMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inverseMatrix.GetLength(1); j++)
        {
            Console.Write(inverseMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
  }
}
