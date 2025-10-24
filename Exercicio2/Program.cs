//2) Desenvolva um programa que recebe do usuário, o placar de um 
// jogo de futebol (os gols de cada time) e informa 
//se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.
float n1,n2;

Console.Write("Informe o numero de gols do time1: ");
n1 = float.Parse(Console.ReadLine());

Console.Write("Informe o numero de gols do time2: ");
n2 = float.Parse(Console.ReadLine());

{ 
  if (n1 > n2)
    {
        Console.Write($"O numero de gols do time1 {n1} eh maior que o time2 {n2} time1 vencedor!:");
    }
    else if (n2 > n1)

    {
        Console.Write($"O numero de gols do time1 {n1} eh menor que o time2 {n2} time2 vencedor!:");
    }
    else
    {
        Console.Write($"Os times1 {n1} e time2 {n2} empataram! (:0 :");
    }



}

