namespace Calculator
{
    public class Calculator
    {
        public int Add(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        public int Subtract(int valor1, int valor2)
        {
            return valor1 - valor2;
        }

        public int Multiply(int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        public int Divide(int valor1, int valor2)
        {
            if (CheckForZero(valor2))
                throw new DivideByZeroException("Cannot divide by zero.");
            return valor1 / valor2;
        } 
        private static bool CheckForZero(int valor2) => valor2 == 0;
    }
}