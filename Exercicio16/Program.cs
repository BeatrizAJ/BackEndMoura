// int idade;
// string nome;


// Console.WriteLine("Ola, qual eh seu nome?");
// nome = Console.ReadLine();

// Console.WriteLine("Ola, qual eh a sua idade?");
// idade = int.Parse(Console.ReadLine());

// Console.WriteLine($"{nome}, obrigada por responder");

// if (idade >= 18)
// {

//     Console.WriteLine("Voce eh MAIOR de idade");
// }
// else
// {

//     Console.WriteLine("voce eh menor de idade");

// } 

//Uma empresa decide dar aumento aos funcionários de acordo com o seu cargo,disposto na tabela abaixo:


//Producao 6.5
//Admin 7.5
//Diretoria 12



//salario = salarIo * 1.65
//salario = salario * 1.075
//salario = salario * 1.12


string cargo;
double salario, novoSalario = 0;




Console.WriteLine("Digite o cargo do funcionário (producao, administrativo ou diretoria):");
        cargo = Console.ReadLine(); 

        Console.WriteLine("Digite o salário atual do funcionário:");
        salario = double.Parse(Console.ReadLine());

        if (cargo == "producao")
        {
            novoSalario = salario + (salario    * 0.065);
        }
        else if (cargo == "administrativo")
        {
            novoSalario = salario + (salario * 0.075);
        }
        else if (cargo == "diretoria")
        {
            novoSalario = salario + (salario * 0.12);
            
        }
        else
        {
            Console.WriteLine("Cargo inválido!");
            return; 
        }

        Console.WriteLine($"O novo salário reajustado é: R$ {novoSalario}");
    
