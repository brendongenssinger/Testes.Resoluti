using Pessoa.BackEnd.Enums;

namespace Pessoa.BackEnd.Model
{
    public class Contatos
    {
        public string Nome { get; set; }
        public string Contato { get; set; }
        public TipoDeContato TipoDeContato { get; set; }

    }
}
