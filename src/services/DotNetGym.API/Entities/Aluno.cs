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
    }
}
