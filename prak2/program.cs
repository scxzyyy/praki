using System;

class QuadraticEquationSolver
{
    private double a, b, c;
    private double root1, root2;

    public QuadraticEquationSolver(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    private double CalculateDiscriminant()
    {
        return b * b - 4 * a * c;
    }

    public void CalculateRoots()
    {
        double discriminant = CalculateDiscriminant();

        if (discriminant > 0)
        {
            root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Корень 1: {root1}");
            Console.WriteLine($"Корень 2: {root2}");
        }
        else if (discriminant == 0)
        {
            root1 = -b / (2 * a);
            Console.WriteLine($"Корень: {root1}");
        }
        else
        {
            Console.WriteLine("Корней нет");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Напиши коэффициенты a, b, и c:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        QuadraticEquationSolver equationSolver = new QuadraticEquationSolver(a, b, c);
        equationSolver.CalculateRoots();
    }
}
