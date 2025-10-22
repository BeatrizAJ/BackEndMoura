//Pedir para o usuario digitar o nome, sobrenome, idade, saldo bancario e quanto investiu esse ano

string nome;
string sobrenome;
int idade;
float saldoBancario;
float investimentos;

//Pasca Case - Primeira letra de cada palavra sempre maiuscula
Console.WriteLine("Ola, qual e o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual e o seu sobrenome?");
sobrenomeDoFulano = Console.ReadLine();


Console.WriteLine("Qual w o seu sobrenome?");
idade = int.Parse(Console.ReadLine() );


Console.WriteLine("Qual e o seu saldo bancario?");
saldoBancario = float.Parse(Console.ReadLine()); // converte o texto digitado em float


//receber o investimento do usuario
Console.WriteLine("Qual e o investimento para esse ano");
saldoBancario = float.Parse(Console.ReadLine());


Console.Clear();
Console.WriteLine($"Nome: {nome} {sobrenomeDoFulano}");
Console.WriteLine($"Idade do : {nome} eh {idade}");
Console.WriteLine($"Saldo Bancario: {saldoBancario}"); 
Console.WriteLine($"Investimento para esse ano:  {investimentos}"); 