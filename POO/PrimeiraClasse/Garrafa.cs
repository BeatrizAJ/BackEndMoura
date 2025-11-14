using System.Security.Cryptography;
using PrimeiraClasse;
Console.WriteLine($"=== PROGRAMA PRIMEIRA CLASSE ===");

// Console.WriteLine($"=== PROGRAMA PRIMEIRA CLASSE ===");

// Carro mclaren = new Carro();
// mclaren.marca = "Mclaren";
// mclaren.cor = "Laranja";
// mclaren.modelo = "750s";
// mclaren.potencia = 800;

// Console.Write($"Ligando a {mclaren.marca} {mclaren.cor}");
// mclaren.Ligar();
// Console.WriteLine($"Acelerando a {mclaren.marca} de {mclaren.potencia} cv");
// mclaren.Acelerar();


// Pessoa bia = new Pessoa();
// bia.Nome = "Beatriz Andrade";
// bia.Idade = 16;
// bia.Altura = 166;

// bia.Falar();
// bia.Dormir();

Garrafa Tapperware = new Garrafa();
Tupperware.Cor = "Roxa";
Tapperware.Capacidade = 500;
Tapperware.Tamanho = 27;
Tapperware.Formato = "Arredondada";

Tapperware.Abrir();
Tapperware.Beber();

Garrafa Stanley = new Garrafa;
Stanley.Cor = "Azul Goiaba";
Stanley.Capacidade = 500;
Stanley.Tamanho = 20;
Stanley.Formato = "Cilindrico";
Console.WriteLine($"Abrindo a garrafa stanley: ");
Stanley.Abrir();

Console.WriteLine($"Bebendo agua da garrafa stanley: ");
Stanley.Beber();

Console.WriteLine($"Bebendo agua da garrafa stanley: ");
Stanley.Beber();


        public string Cor;

        public int Capacidade;

        public int Tamanho;

        public string Formato;

        public void Beber()
        {
            Console.WriteLine($"Glu, Glu, Glu, Glu...");

        }

        public void Abrir()
        {
            Console.WriteLine($"Thro...");
            
        }