// quantidade de numeros digitado, laco que exiba o numero digitado apeas e for par. ultilize while 

int qntdUsuario = 0;
int contador = 1;
Console.WriteLine($"Quantos numeros quer digitar?");
qntdUsuario = int.Parse(Console.ReadLine());

while (contador <= qntdUsuario)
{
    Console.WriteLine($"Digite um numero:");
    int batata = int.Parse(Console.ReadLine());
    if (batata % 2 == 0)
    {
        Console.WriteLine($"Numero digitado eh par: {batata}");

    }

    contador++;
}


