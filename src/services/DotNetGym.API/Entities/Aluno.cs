using DotNetGym.API.Enums;
using System;

namespace DNG.API.Entities
{
    public class Aluno : EntidadeBase
    {
        protected Aluno() { }
        public Aluno(string nome,
                     string endereco,
                     DateTime nascimento) : base(nome,
                                                 endereco)
        {
            Nascimento = nascimento;
            Status = StatusAlunoEnum.Ativo;
        }

        public DateTime Nascimento { get; private set; }
        public StatusAlunoEnum Status { get; private set; }
        public int IdUnidade { get; private set; }
        public Unidade Unidade { get; set; }
        public int IdProfessor { get; set; }
        public Professor Professor { get; set; }
    }
}
