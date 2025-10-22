// Faca um programa q solicete ao usuario um numero de repeticoes "x". 
//para cada repeticao solicite dois numeros e imprima qual e o maior deles.




Console.WriteLine($"Quantos numeros voce quer digitar?");
int x int.Parse(console.ReadLine());
int n1, n2;
int contador = 1;


while (contador <= x)
{
    Console.WriteLine($"Digite o primeiro numero:");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o segundo numero:");
    n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.Write($"O numero {n1} eh maior que o {n2}:");
    }
    else if (n2 > n1)

    {
        Console.Write($"O numero {n1} eh maior que o {n2}:");
    }
    else
    {
        Console.Write($"O numero {n1} e o {n2} sao iguais (:0 :");
    }

    contador++;



}