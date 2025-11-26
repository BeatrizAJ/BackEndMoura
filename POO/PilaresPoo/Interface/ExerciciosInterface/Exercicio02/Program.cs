using System.Drawing;
using Exercicio02;

List<IImprimivel> Documentos = new List<IImprimivel>();


//Lista de dados da fatura
Console.WriteLine($"FATURAS:");
foreach (var Fat in Documentos)
{
    if (Fat is Fatura)
    {
        Fat.imprimir();
    }
}

Console.WriteLine($"CONTRATOS:");
foreach (var Cont in Documentos)
{
    if (Cont is Contrato)
    {
        Cont.imprimir();
    }
}

Console.WriteLine($"RELATORIOS:");
foreach (var Rel in Documentos)
{
    if (Rel is Relatorio)
    {
        Rel.imprimir();
    }
}
int opcao;

do
{
    Console.Clear();
    Console.Write($@"Menu de Opções
    1) Cadastrar Fatura
    2) Cadastrar Relátorio
    3) Cadastrar Contrato
    4) Listar Faturas
    5) Listar Relatórios
    6) Listar Contratos
    0) Sair
    Escolha a opção: 
    ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarFatura();
            break;
        case 2:
            Console.WriteLine($"Cadastrar Relatório em desenvolvimento");
            break;
        case 3:
            Console.WriteLine($"Cadastrar Contrato em desenvolvimento");
            break;
        case 4:
            ListarFaturas();
            break;
        case 5:
            Console.WriteLine($"Listar Relatórios em desenvolvimento");
            break;
        case 6:
            Console.WriteLine($"Listar Contratos em desenvolvimento");
            break;
        case 0:
            Console.WriteLine($"Sair");
            break;

        default:
            Console.WriteLine($"Opção inválida");

            break;
    }

    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine();
} while (opcao != 0);




//--------FUNÇÔES--------
void CadastrarFatura()
{
    Console.Write($"Digite o nome do Cliente Devedor: ");
    string dev = Console.ReadLine();

    Console.Write($"Digite o nome da empresa: ");
    string empresa = Console.ReadLine();

    Console.Write($"Digite o valor da fatura: ");
    float valor = float.Parse(Console.ReadLine());

    Console.Write($"Dias de atraso da fatura: ");
    int qtdAtraso = int.Parse(Console.ReadLine());

    Console.WriteLine($"Fatura Cadastrada com sucesso!");


    Fatura fat = new Fatura(dev, empresa, valor, qtdAtraso);
    Documentos.Add(fat);

}
void CadastrarContrato()
{
    Console.WriteLine($"Informe o nome");
    string nome = Console.ReadLine();
    Console.WriteLine($"qual o texto da clausola do contrato");
    string texto = Console.ReadLine();
    //objeto classe contrato  
    Contrato contrato = new Contrato();
    contrato.Nome = nome;
    contrato.TextoClausulas = texto;
    // contrato na lista de doc
    Documentos.Add(contrato);
    Console.WriteLine($"Contrato Cadastrado com sucesso!!");
}
void CadastrarRelatorio()
{
    Console.WriteLine($"Digite o nome do responsavel");
    string nome = Console.ReadLine();
    Console.WriteLine($"digite os textos do relatorio");
    string texto = Console.ReadLine();
    //obj classe relatorio
    Relatorio relatorio = new Relatorio();
    relatorio.NomeResponsavel = nome;
    relatorio.TextoRelatorio = texto;
    //cadastro de relat. lista documento
    Documentos.Add(relatorio);
    Console.WriteLine($"Relatorio Cadastrado com Sucesso");
}
void ListarFaturas()
{
    Console.WriteLine($"Listando Faturas");
    foreach (var item in Documentos)
    {
        if (item is Fatura)
        {
            item.imprimir();
        }
    }


}
void ListarRelatorio()
{
    Console.WriteLine($"Listando Relatorios:");
    foreach (var item in Documentos)
    {
        if (item is Relatorio)
        {
            item.imprimir();
        }
    }
}
void ListarContrato()
{
    foreach (var item in Documentos)
    {
        if (item is Contrato)
        {
            item.imprimir();
        }
    }

}







//criar uma lista para faturas, relatorios e contratos
// List<Fatura> ListaFaturas = new List<Fatura>();
// List<Relatorio> ListaRelatorios = new List<Relatorio>();
// List<Contrato> ListaContrato = new List<Contrato>();

//cria um  objeto de cada classe e adiciona a listas
// Fatura fatdiogo = new Fatura();
// ListaFaturas.Add(fatdiogo);

// Fatura fatjunior = new Fatura();
// ListaFaturas.Add(fatjunior);

// Relatorio reldiogo = new Relatorio();
// ListaRelatorios.Add(reldiogo);

// Contrato condiogo = new Contrato();
// ListaContrato.Add(condiogo);


