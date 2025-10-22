//Pedir para o usuario digitar dois numeros e exibir a soma desses dois numeros

int n1, n2;

Console.WriteLine($"Digite oo primeiro numero");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite oo segundo numero");
n2 = int.Parse(Console.ReadLine());


int soma = n1 + n2;

Console.WriteLine($"A soma de {n1} + {n2} eh {n1 + n2}");