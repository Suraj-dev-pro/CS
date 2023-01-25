using System;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double.Solvers;

class SimpleLinear
{
    public static void Main(string[] args)
    {
        

        // Input data
        double[] inputs = { 1, 2, 3, 4, 5 };
        double[] outputs = { 2, 4, 6, 8, 10 };

        // Create the input matrix and output vector
        Matrix<double> X = CreateMatrix.DenseOfRowArrays(inputs.Select(x => new double[] { x }));
        Matrix<double> y = CreateMatrix.DenseOfColumnArrays(outputs);

        // Perform the linear regression
        var ls = new LinearRegression();
        ls.Regress(X, y);

        // Get the coefficients of the linear model
        var coefficients = ls.Coefficients;

        // Print the coefficients
        Console.WriteLine("Intercept: " + coefficients[0]);
        Console.WriteLine("Slope: " + coefficients[1]);

    }
}