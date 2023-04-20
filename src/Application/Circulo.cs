namespace Application;

public static class Circulo
{
    public static double Perimetro(double pi, double radio)
    {
        double perimetro = 2 * pi * radio;
        return perimetro;
    }
    public static double Area(double pi,double radio)
    {
        double area = pi * Math.Pow (radio,2);
        return area;
    }
}