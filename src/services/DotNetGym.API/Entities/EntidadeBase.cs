namespace DotNetGym.API.Entities
{
    public abstract class EntidadeBase
    {
        protected EntidadeBase() { }
        protected EntidadeBase(string nome,
                               string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
    }
}
