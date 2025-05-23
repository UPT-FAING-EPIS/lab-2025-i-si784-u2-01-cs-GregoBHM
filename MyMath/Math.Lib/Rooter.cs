using System;

namespace Math.Lib
{
    /// <summary>
    /// Proporciona métodos matemáticos personalizados.
    /// </summary>
    public class Rooter
    {
        /// <summary>
        /// Calcula la raíz cuadrada de un número positivo.
        /// </summary>
        /// <param name="input">Número positivo a calcular la raíz.</param>
        /// <returns>Raíz cuadrada del número ingresado.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Lanza una excepción si el número es negativo o cero.
        /// </exception>
        public double SquareRoot(double input)
        {
            if (input <= 0.0)
                throw new ArgumentOutOfRangeException(nameof(input), "El valor ingresado es invalido, solo se puede ingresar números positivos");

            double result = input;
            double previousResult = -input;

            while (Math.Abs(previousResult - result) > result / 1000)
            {
                previousResult = result;
                result = result - (result * result - input) / (2 * result);
            }

            return result;
        }
    }
}
