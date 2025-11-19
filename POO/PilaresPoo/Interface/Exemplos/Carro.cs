namespace Exemplos
{
    public class Carro : IMotor
    {

        //propriedades
        public string Cor;

        public string Marca;

        public string Modelo;

        public int Ano;


        //construtores

        public Carro(string c,string m, string md, int a)
        {
            Cor = c;
            Marca = m;
            Modelo = md;
            Ano = a;
        }

             //metodos

        public void ExibirInfo()
        {
            Console.WriteLine($@"
            Informacoes do Veiculo:
             Marca: {Marca}
             Modelo: {Modelo}
             Ano: {Ano}
             Cor: {Cor}
             ");
        }

        public void Acelerar()
        {
            Console.WriteLine($"Carro acelerando...");

        }

        public void Freiar()
        {
            Console.WriteLine($"Carro freiando!");

        }
    }
}