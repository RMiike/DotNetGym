using System.Collections.Generic;

namespace DNG.API.Entities
{
    public class Unidade : EntidadeBase
    {
        protected Unidade() { }
        public Unidade(string nome,
                       string endereco) : base(nome,
                                               endereco)
        {
            Alunos = new List<Aluno>();
            Professores = new List<Professor>();
        }
        public List<Aluno> Alunos { get; private set; }
        public List<Professor> Professores { get; private set; }
    }
}
