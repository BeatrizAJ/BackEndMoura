using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class Pessoa
    {
        public string Nome;

        public int Altura;

        public int Idade;

        public void Falar()
        {
            Console.WriteLine($"Ola, eu sou {Nome} prazer!");
            
        }

        public void Dormir()
        {
            Console.WriteLine($"ZZZZZZzzzz...!");
        }
   
   public int Envelhecer(int _id = 0)
   {
            if (_id > 0)
            {
                Idade += _id;
            }
            else
            {//add 1 ano a idade
                Idade++;
            }
            
     } 
   
    }
}