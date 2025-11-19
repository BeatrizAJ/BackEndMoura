namespace Exercicio01
{
    public class Circulo : IForma
    {
        public float Raio;

        private float PI = 3,14f;

        public void CalcularArea()
        {
            float area = PI * Raio * Raio;
            Console.WriteLine($"A area do circulo eh {area}");
            
        }
    }
}