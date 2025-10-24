//------------------------------------------------------------------
//                      Bem Vindo Usuario
//------------------------------------------------------------------
int opcao;

do
{


    Console.WriteLine($"---------------------------------------------");
    Console.WriteLine($"                 Bem Vindo                   ");
    Console.WriteLine($"                     ao                      ");
    Console.WriteLine($"                Jacareca Food                ");
    Console.WriteLine($"---------------------------------------------");
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine($"Escolha uma opcao no menu abaixo:");
    Console.WriteLine();


    Console.WriteLine($" 1)  Hot Holl .............................R$ 29,90");
    Console.WriteLine($" 2)  Temaki   .............................R$ 30,00");
    Console.WriteLine($" 3)  Sashimi  .............................R$ 35,00");
    Console.WriteLine($" 4)  Yakisoba .............................R$ 45,00");
    Console.WriteLine($" 5)  Guiosa   .............................R$ 25,00");
    Console.WriteLine($" 6)  Shimeji  .............................R$ 35,00");
    Console.WriteLine($"     Sair");
    Console.WriteLine($"Opção:");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
            Console.WriteLine($"Digite <Enter> para continuar ...");
            Console.WriteLine();
            break;
        case 1:
            HotHoll();
            break;
        case 2:
            Temaki();
            break;
        case 3:
            Sashimi();
            break;
        case 4:
            Yakisoba();
            break;
        case 5:
            Guiosa();
            break;
        case 6:
            Shimeji();
            break;
        default:
            Console.WriteLine($"Opcao invalida");
            break;
    } //fim do switch

    Console.WriteLine($"Digite <Enter> para continuar ...");
    Console.ReadLine();
} while (opcao != 0);


void HotHoll()
{
    //A logica da funcao
    Console.WriteLine($"Boa escolha, vamos preparar seu Hot Holl com carinho");
}
void Temaki()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Termaki com carinho");
}
void Sashimi()
{
     Console.WriteLine($"Boa escolha, vamos preparar seu Sashimi com carinho");
}
void Yakisoba()
{
     Console.WriteLine($"Boa escolha, vamos preparar seu Yakisoba com carinho");
}
void Guiosa()
{
     Console.WriteLine($"Boa escolha, vamos preparar seu Guiosa com carinho");
}
void Shimeji()
{
      Console.WriteLine($"Boa escolha, vamos preparar seu Shimeji com carinho");
}
