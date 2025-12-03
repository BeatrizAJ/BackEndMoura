using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudMoura.Models
{
    public class Aluno
    {
        public int id {get; set;}
        public string Nome {get; set;}

        public int Idade {get; set;}

        public string Turma {get; set;}

        public string Cpf {get; set;}

    }
}