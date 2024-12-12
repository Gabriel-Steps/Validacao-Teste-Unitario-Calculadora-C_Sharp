using Calculadora.Services;

namespace CalculadoraTest;

public class CalculadoraTests
{
    [Theory]
    [InlineData(2,2,4)]
    public void TestarSoma(int valor1, int valor2, int resultadoEsperado)
    {
        CalculadoraSe calc = new CalculadoraSe();
        var resultado = calc.Somar(valor1,valor2);
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(4,2,2)]
    public void TestarSubtracao(int valor1, int valor2, int resultadoEsperado){
        CalculadoraSe calc = new CalculadoraSe();
        var resultado = calc.Subtrair(valor1, valor2);
        Assert.Equal(resultadoEsperado, resultado);
    }
    [Theory]
    [InlineData(4,2,8)]
    public void TestarMultiplicacao(int valor1, int valor2, int resultadoEsperado){
        CalculadoraSe calc = new CalculadoraSe();
        var resultado = calc.Multiplicar(valor1, valor2);
        Assert.Equal(resultadoEsperado, resultado);
    }
    [Theory]
    [InlineData(4,2,2)]
    public void TestarDivisao(int valor1, int valor2, int resultadoEsperado){
        CalculadoraSe calc = new CalculadoraSe();
        var resultado = calc.Dividir(valor1, valor2);
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(4,0)]
    public void TestarDivisaoPor0(int valor1, int valor2){
        CalculadoraSe calc = new CalculadoraSe();
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(valor1, valor2));
    }
}