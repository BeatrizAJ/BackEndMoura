using Calculadora;
Console.Clear();

Calculator calc = new Calculator();


do
{


    Console.WriteLine($"---------------------------------------------");
    Console.WriteLine($"                 Bem Vindo                   ");
    Console.WriteLine($"                     a                       ");
    Console.WriteLine($"                Calculadora                  ");
    Console.WriteLine($"---------------------------------------------");
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine($"Escolha uma opcao abaixo:");
    Console.WriteLine();

    Console.WriteLine($"Somar");
    Console.WriteLine($"Subtrair");
    Console.WriteLine($"Multiplicar");
    Console.WriteLine($"Dividir");

    switch (opcao)
    {
        case 1:
            Somar();
            break;
        case 2:
            Subtrair();
            break;
        case 3:
            Multiplicar();
            break;
        case 4:
            Dividir();
            break;

    }
}



calc.Numero1 = 50;
calc.Numero2 = 10;

Console.WriteLine($"Soma {calc.Somar()}");
Console.WriteLine($"Primeiro numero {calc.Numero1}");
Console.WriteLine($"Segundo numero {calc.Numero2}");


Console.WriteLine($"Resultados:");
Console.WriteLine();


Console.WriteLine($"Subtracao {calc.Subtrair()}");
Console.WriteLine($"Prim");
Console.WriteLine();

Console.WriteLine($"Multiplicacao {calc.Multiplicar})}");
Console.WriteLine($"");
Console.WriteLine();

Console.WriteLine($"Divisao {calc.Dividir()}");
Console.WriteLine($"");
Console.WriteLine();

