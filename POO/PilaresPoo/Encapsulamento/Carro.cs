using System.Security.Cryptography.X509Certificates;

namespace Encapsulamento
{
    public class Carro
    {
        private string Marca;

        private string Modelo;

        private int VelocidadeAtual;

        public void DefinirMarca(string valor)
        {
            Marca = valor;
        }
        public string ObterMarca()
        {
            return Marca;
        }

        public void DefinirModelo(string valor)
        {
            Modelo = valor;
        }

        public void ObterModelo()
        {
            return Modelo;
        }

        public int ObterVelocidade()
        {
            return VelocidadeAtual;
        }

        public void Acelerar(int valor)
        {
            if (valor > 0)
            {
                VelocidadeAtual += valor;
            }
            else
            {
                Console.WriteLine($"Nao acelera negativamente!!");
            }
        }

        public void Frear(int valor)
        {
            if (valor > 0)
            {
                
            }
            else
            {
                
            }
        }
    }
}