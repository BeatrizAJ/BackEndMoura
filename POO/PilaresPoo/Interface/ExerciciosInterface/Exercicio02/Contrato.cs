using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";

        public string Credor = "";

        public float Valor = 0;

        public int DiaAtraso = 0;

        private float Juros = 0.10f;

        public Fatura(string nomeDevedor, string nomeEmpresa, float valorFatura, int qtdDiasAtraso)
        {
            
            Devedor = nomeDevedor;
            Credor = nomeEmpresa;
            Valor = valorFatura;
            DiaAtraso = qtdDiasAtraso;
        }

        public void CalcularValorDivida()
        {
            if (DiaAtraso > 0)
            {
                Valor = Valor + DiaAtraso * Juros;
            }


            if(DiaAtraso >= 5)
            {
                Console.WriteLine($"Divida encaminhada para o SERASA");
                
            }
        }



        public void imprimir()
        {

            CalcularValorDivida();
            
            Console.WriteLine($@"
    Credor: {Credor}
    Devedor: {Devedor}
    Dias de atraso: {DiaAtraso}
    Júros: R${Juros + DiaAtraso:F2}
    Valor total: R${Valor}
            ");

        }
    }
}