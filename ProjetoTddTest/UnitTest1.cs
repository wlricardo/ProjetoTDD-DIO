using ProjetoTDD_DIO;

namespace ProjetoTddTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10, 5, 15)]
        [InlineData(4, 2, 6)]
        public void SomarTest(int num1, int num2, int resultado)
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            int resultadoCalculadora = calc.Somar(num1, num2);

            // Assert
            Assert.Equal(resultadoCalculadora, resultado);
        }

        [Theory]
        [InlineData(10, 3, 7)]
        [InlineData(4, 1, 3)]
        public void SubtrairTest(int num1, int num2, int resultado)
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            int resultadoCalculadora = calc.Subtrair(num1, num2);

            // Assert
            Assert.Equal(resultadoCalculadora, resultado);
        }

        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(4, 2, 8)]
        public void MultiplicarTest(int num1, int num2, int resultado)
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            int resultadoCalculadora = calc.Multiplicar(num1, num2);

            // Assert
            Assert.Equal(resultadoCalculadora, resultado);
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(6, 2, 3)]
        public void DividirTest(int num1, int num2, int resultado)
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            int resultadoCalculadora = calc.Dividir(num1, num2);

            // Assert
            Assert.Equal(resultadoCalculadora, resultado);
        }
    }
}