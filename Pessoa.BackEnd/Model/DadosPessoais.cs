namespace Pessoa.BackEnd.Model
{
    public class DadosPessoais
    {
        public Pessoa Pessoa { get; set; }
        public Endereco Endereco { get; set; }
        public List<Contatos> Contatos { get; set; }


    }
}
