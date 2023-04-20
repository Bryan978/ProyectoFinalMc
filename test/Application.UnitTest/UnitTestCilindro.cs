using Xunit;

namespace Application.UnitTest;

public class UnitTestCilindro
{
    [Theory]
    [InlineData(27, 4, 108)]
    [InlineData(13, 6, 78)]
    [InlineData(42, 11, 462)]
    [InlineData(36, 20, 720)]
    [InlineData(5, 17, 85)]

    public void TestVolumen(double area, double altura, double volumen)
    {
        // Arrange – Set up


        // Act – Perform
        double resultado = Cilindro.Volumen(area, altura);
        
        // Assert – Verify
        Assert.Equal(resultado, volumen);
    }
}