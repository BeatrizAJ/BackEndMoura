string[] nomes = new string[3];
int[] idade = new int[3];
int totalAlunos = 0;
int opcao;

do
{
    Console.WriteLine($"====== Aplicativo sala de aula ====");
    Console.WriteLine($"1) lista de alunos");
    Console.WriteLine($"2) cadastro Alunos");
    Console.WriteLine($"0) Sair");
    Console.WriteLine($"Escolha uma opcao: ");
    opcao = int.Parse(Console.ReadLine());


switch (opcao)
{
        case 0:
    Console.WriteLine($"Encerrando. . .");

            break;

        case 1:
            ListarAlunos();
            break;

        case 2:
            CadastroAlunos();
            break;
        default:
            Console.WriteLine($"Opcao Invalida");
            
            break;

}



} while (opcao != 0);


void ListarAlunos ()
{
    Console.WriteLine($"====== listagem de alunos =====");
    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine($"Nomes: {nomes[i]}, {idade[i]} anos");
        
    }
} 

void CadastroAlunos ()
{
    Console.WriteLine($"====== Cadastro de alunos =====");

    if (totalAlunos == 3)
    {
        Console.WriteLine($"Limites de vagas atingidas");
        return;
    }
    Console.WriteLine($"Digite o nome do Aluno");
    string n = Console.ReadLine();

    Console.WriteLine($"Digite a idade de {n}");
    n = Console.ReadLine();
    totalAlunos++;
    Console.WriteLine($"Aluno cadastrado com sucesso.");

    }