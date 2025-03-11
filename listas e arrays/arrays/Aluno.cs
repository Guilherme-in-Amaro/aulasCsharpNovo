using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Aluno   //CRTL + .
    {
        public string nome;
        public int matricula;        //DECLARANDO
        public string curso;
        public string email;
        public string telefone;

        public Aluno(string nome, int matricula, string curso, string email, string telefone)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.curso = curso;
            this.email = email;
            this.telefone = telefone;
        }
    }
}
