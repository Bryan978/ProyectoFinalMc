namespace Application.UnitTest;

public class UnitTestCirculo
{
    [Theory]
    [InlineData(3.14, 6, 37.68)]
    [InlineData(3.14, 9, 56.52)]
    [InlineData(3.14, 13, 81.64)]
    [InlineData(3.14, 18, 113.04)]
    [InlineData(3.14, 21, 131.88)]
    public void TestPerimetro(double pi, double radio, double perimetro)
    {
        // Arrange – Set up

        // Act – Perform
        double resultado = Circulo.Perimetro(pi,radio);

        // Assert – Verify
        Assert.Equal(perimetro, resultado);
    }

    [Theory]
    [InlineData(3.14, 4, 50.24)]
    [InlineData(3.14, 7, 153.86)]
    [InlineData(3.14, 9, 254.34)]
    [InlineData(3.14, 22, 1519.76)]
    [InlineData(3.14, 35, 3846.50)]
    public void TestArea(double pi, double radio, double area)
    {
        // Arrange – Set up

        // Act – Perform
        double resultado = Circulo.Area(pi,radio);

        // Assert – Verify
        Assert.Equal(area, resultado);
    }
}