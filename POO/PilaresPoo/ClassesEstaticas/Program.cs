using ClassesEstaticas;

Console.WriteLine($"Numero de PI: {CalculoMatematicos.PI}");


//solicitar ao usuario 2 numeros reais e informear qual
//  e o maior e o menor dos numeros,
//  vc deve ultilizar a classe math, utilitaria do c#


    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        float n1 = float.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        float n2 = float.Parse(Console.ReadLine());

        double maior = Math.Max(n1, n2);
        double menor = Math.Min(n1, n2);

        Console.WriteLine($"Maior número: {maior}");
        Console.WriteLine($"Menor número: {menor}");
    }





















// Console.WriteLine($"Digite o primeiro numero:");
// float n1 = float.Parse(Console.ReadLine());
// Console.WriteLine($"Digite o segundo numero:");
// float n2 = float.Parse(Console.ReadLine());


// Console.WriteLine($"Resultados:");
// Console.WriteLine($"Soma: {CalculoMatematicos.Somar{n1, n2}}");
// Console.WriteLine($"Subtracao: {CalculoMatematicos.Subtrair(n1, n2)}");
// Console.WriteLine($"Multiplicacao: {CalculoMatematicos.Multipicar(n1, n2)}");

// Console.WriteLine($"divisao: {CalculoMatematicos.Dividir(n1, n2)}");













// CalculoMatematicos calc = new CalculoMatematicos();

// Console.WriteLine($"Numero de Pi: {CalculoMatematicos.PI}");
// Console.WriteLine($"Soma de 5 e 10 : {CalculoMatematicos.Somar(5, 10)}");
// Console.WriteLine($"Soma de 50,2 e 10,7: {CalculoMatematicos.Somar(50,2f , 10,7f)}");
// Console.WriteLine($"A divisao de 5 por 0 eh{CalculoMatematicos.Dividir(5, 0)}");
