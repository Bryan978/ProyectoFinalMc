using Xunit;
namespace Application.IntegrationTest;

public class IntegrationTestApplication
{
    [Theory]
    [InlineData(3.14, 5, 36, 2826)]
    [InlineData(3.14, 11, 24, 9118.56)]
    [InlineData(3.14, 19, 66, 74813.64)]
    [InlineData(3.14, 23, 15, 24915.90)]
    [InlineData(3.14, 8, 13, 2612.48)]

    public void TestVolumen(double pi, double radio, double altura, double volumen)
    {
        // Arrange – Set up
        double area = Circulo.Area(pi, radio);

        // Act – Perform
        double resultado = Cilindro.Volumen(area, altura);

        // Assert – Verify
        Assert.Equal(resultado, volumen);
    }
}