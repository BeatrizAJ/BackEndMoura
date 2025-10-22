//PERGUNTAR USUARIO QUANTOS NUMEROS ELE QUER DIGITAR EXIBIR, SEPARADAMENTE, OS 
// NUMEROS PARS E OS NUMEORS IMPARES QUE ELE DIGITA
// EXEMPLO DE SAIDA PARES-2,4,60,200,8
//IMPARES- 1,3,61,2009,7

Console.WriteLine($"Quantos numeros vc quer digitar?");
int qtdNumeros = int.Parse (Console.ReadLine());
string pares = "Pares: ";
string impares = "Impares: ";

for (int i = 1; i < qtdNumeros; i++)
{
    Console.WriteLine($"Digite o {i} numero:");
    int numeroDigitado = int.Parse (Console.ReadLine());

    if (numeroDigitado % 2 == 0)
    { //é par?
        pares += numeroDigitado.ToString() + ", ";
    }
    else
    {
        impares += numeroDigitado.ToString() + ", ";
    }
}

Console.Clear();
Console.WriteLine($"Resultado");
Console.WriteLine();
Console.WriteLine(pares);
Console.WriteLine(impares);