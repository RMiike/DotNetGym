using DotNetGym.API.Enums;
using System.Collections.Generic;

namespace DNG.API.Entities
{
    public class Professor : EntidadeBase
    {
        protected Professor() { }
        public Professor(string nome, string endereco) : base(nome, endereco)
        {
            Alunos = new List<Aluno>();
            Status = StatusProfessorEnum.Ativo;
        }

        public StatusProfessorEnum Status { get; private set; }
        public List<Aluno> Alunos { get; private set; }
    }
}
