//review



string[] nomes = new string[4];

nomes[0] =   "Bia";
nomes[1]=    "Edu";
nomes[2] = "Alexia";

Console.WriteLine($"Tamanho do Array: {nomes.Length}");

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"    {i + 1} o Nome: {nomes{i}}");
}



