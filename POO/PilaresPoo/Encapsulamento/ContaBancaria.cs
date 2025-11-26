namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        //Gets and Sets

        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float saldoInicial)
        {

            if (saldoInicial > 0)
            {
                Saldo = saldoInicial;
            }
            else
            {
                Saldo = 0;
            }
        }

        public float GetSaldo()
        {
            return Saldo;
        }
        public void Depositar(float valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"Valor Invalido");
            }
            else
            {
                Saldo += valor;
            }

        }

        public void Sacar(float valor)
        {
            if (valor >= 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque Efeituado com Sucesso!!");

            }
            else
            {
                Console.WriteLine($"Saldo insuficiente ou negativo!!");

            }

        }
    }
}