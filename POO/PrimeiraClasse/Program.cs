using PrimeiraClasse;

Console.WriteLine($"=== PROGRAMA PRIMEIRA CLASSE ===");

Carro mclaren = new Carro();
mclaren.marca = "Mclaren";
mclaren.cor = "Laranja";
mclaren.modelo = "750s";
mclaren.potencia = 800;

Console.Write($"Ligando a {mclaren.marca} {mclaren.cor}");
mclaren.Ligar();
Console.WriteLine($"Acelerando a {mclaren.marca} de {mclaren.potencia} cv");
mclaren.Acelerar();

