using System;
using System.IO;



namespace Matematicas.FrameworkTest
{
    internal class Calculadora
    {
        public Calculadora()
        {
        }

        internal int AumentarEntero(int numeroEntero1, int numeroEntero2)
        {
            int sum = numeroEntero1;
            for (int i = 0; i < numeroEntero2; i++)
            {
                sum += 1;
            }
            return sum;

        }

        internal double RaizCuadrada(double numero1)
        {
            if (numero1 < 0)
                throw new ArgumentException("No existe raiz cuadrada de números negativos");

            return Math.Sqrt(numero1);
        }
    }
}