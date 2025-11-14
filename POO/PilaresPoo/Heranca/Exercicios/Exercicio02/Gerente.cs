namespace Exercicio02
{
    public class Gerente : Funcionario
    {
        public float Bonus;

        public override void CalcularSalario()
        {
            return SalarioBase += Bonus;
        }
    }
}