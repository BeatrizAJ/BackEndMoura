//1) Faça um programa que o usuário informe o salário recebido e o total gasto. 
// Deverá ser exibido na tela “Gastos dentro do orçamento” caso
//  o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se
//  o valor gasto ultrapassar o valor do salário.

double salario, gastos;

Console.Write("Informe o salario recebido: ");
salario = double.Parse(Console.ReadLine());

Console.Write("Informe o total gasto do mes: ");
gastos = double.Parse(Console.ReadLine());

if (gastos > salario)
{
    Console.WriteLine("Orçamento estourado!  >:(");
}
else
{
    Console.WriteLine("Gastos dentro do orçamento  :)");
}
