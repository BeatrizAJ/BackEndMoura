namespace Calculadora
{
    public class Calculator
    {
        public Double Numero1;
        public Double Numero2;

        public Double Resultado;


        public void Somar()
        {
            Resultado = Numero1 + Numero2;
            return Resultado;

        }
        public void Subtrair()
        {
            Resultado = Numero1 - Numero2;
            return Resultado;

        }


        public void Multiplicar()
        {
            Resultado = Numero1 * Numero2;
            return Resultado;
        }


        public void Dividir()
        {
            if (Numero1 == 0)
            {
                Console.WriteLine($"Nao existe divisao por zero");
                return -1;
            }


            Resultado = Numero1 / Numero2;
            return Resultado;
        }


    }
}