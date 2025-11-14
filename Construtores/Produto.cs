namespace Construtores
{
    public class Produto
    {
        public string Nome;

        public string Preco;

        public int Estoque;

        public Produto(string n, float p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;
        }
    }
}