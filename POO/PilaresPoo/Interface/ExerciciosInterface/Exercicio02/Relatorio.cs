using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Relatorio : IImprimivel
    {
     public void imprimir()
        {
          Console.WriteLine($"Imprimindo o relatorio....");
          
        }
    }
}