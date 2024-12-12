using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraSe
    {
        public int Somar(int valor1, int valor2){
            var res = valor1 + valor2;
            return res;
        }
        public int Subtrair(int valor1, int valor2){
            var res = valor1 - valor2;
            return res;
        }

        public int Multiplicar(int valor1, int valor2){
            var res = valor1 * valor2;
            return res;
        }

        public float Dividir(int valor1, int valor2){
            var res = valor1 / valor2;
            return res;
        }
    }
}