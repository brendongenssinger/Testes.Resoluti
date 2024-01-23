using Pessoa.BackEnd.Model;

namespace Pessoa.BackEnd.Repository
{
    public class PessoasRepository
    {
        public PessoasRepository()
        {
            
        }
        public async Task Salvar(DadosPessoais dadosPessoais)
        {
            throw new NotImplementedException();
        }

        internal Task<List<DadosPessoais>> Listar(int idPessoa)
        {
            throw new NotImplementedException();
        }
    }
}
