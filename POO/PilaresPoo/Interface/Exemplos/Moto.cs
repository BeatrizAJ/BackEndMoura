namespace Exemplos
{
    public class Moto : IMotor
    {
        public string Cor;
        
        public string Marca;

        public string Modelo;

        public int Ano;
        
//construtores 
        public Moto (string c, string m, string md, int a)
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
        Informações do Moto:
          Marca: {Marca}
          Modelo:{Modelo}
          Ano:{Ano}
          Cor:{Cor}
        ");
        
       }
        public void Acelerar()
        {
            Console.WriteLine($"Moto acelerando... Vrum Vrum");
            
        }

        public void Freiar()
        {
            Console.WriteLine($"Moto freiando... irrrrrrrrrrrrrrrrrrh");
            
        }

    }
}