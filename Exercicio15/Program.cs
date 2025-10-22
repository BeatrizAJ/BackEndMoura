// Faca um programa que receba 4 notasa de um aluno, 
// calcule e imprima a media aritmetica das notas e a mensagem de APROVADO para media superior ou igual
// a 7,0 RECUPERACAO para notas entre 5,0 e 7,0 ou a mensagem de REPROVADO para media infeiror a 5,0 


float n1, n2, n3, n4, media;

Console.WriteLine($"Digite o primeiro numero");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo numero");
n2 = float.Parse(Console.ReadLine()); 

Console.WriteLine($"Digite o terceiro numero");
n3 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o quarto numero");
n4 = float.Parse(Console.ReadLine());

media = (n1 + n2 + n3 + n4) / 4;

Console.WriteLine($"Media: {media}");

