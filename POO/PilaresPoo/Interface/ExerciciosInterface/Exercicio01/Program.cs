Console.WriteLine();
Console.WriteLine($"-- BEM VINDO AO PROG DE GEOMETRIA -- ");
Console.WriteLine();

Console.WriteLine($"Vamos calcular a area do retangulo?");


Console.WriteLine($"Informe a altura:");
float altura = float.Parse(Console.ReadLine();)
Console.WriteLine($"Informe a largura:");
float largura = float.Parse(Console.ReadLine();)

Retangulo retangulo = new Retangulo(largura, altura);
Console.WriteLine();



Console.WriteLine($"Agora vamos calcular a area do circulo!");
Console.WriteLine($"informe a area do circulo");
float raio = float.Parse(Console.ReadLine();)


Circulo circulo = new Circulo();
circulo.Raio = raio;



Console.WriteLine();

retangulo.CalcularArea();
circulo.CalcularArea();

