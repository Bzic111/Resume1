namespace Resume1;

public class Circle
{
    public static double CalculateSquareByRadius(double r)
    {
        return Math.PI* Math.Pow(r,2);
    }
}
public class Triangle
{
    public static bool IsRectangular(double a, double b, double c)
    {
        double[] temp = { a, b, c };
        Array.Sort(temp);
        return Math.Pow(temp[0], 2) + Math.Pow(temp[1], 2) == Math.Pow(temp[2], 2);            
    }
    public static double CalculateSquareByBorders(double a,double b, double c)
    {
        if (IsRectangular(a,b,c))
        {
            double[] temp = { a, b, c };
            Array.Sort(temp);
            return temp[0] * temp[1] / 2;
        }
        else
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}