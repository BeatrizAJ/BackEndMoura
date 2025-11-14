
namespace ClasseEObjetos
{
    public class AgenciaBancaria
    {
        public string Titular = "";

        public float Saldo;

        public void Depositar(float _valorSaque)
        {
            if (_valorSaque <= 0)
            {
                Console.WriteLine($"O valor do saldo deve ser maior do que R$ 0");
                return;
            }

            Saldo += _valorSaque;
            Console.WriteLine($"Deposito realizado. Novo Saldo: {Saldo} ");
        }

        public void Sacar(float _valorSaque)
        {
            if (_valorSaque <= 0 && _valorSaque < Saldo)
            {

                Console.WriteLine($"Saldo Atual: {Saldo}");

                Console.WriteLine($"Nao e possivel sacar esse valor verifique o saldo e digite um valor valido");
            }


            Saldo -= _valorSaque;

            Console.WriteLine($"Saque realizado. Novo Saldo: {Saldo} ");
        }




    }

}