
using Pessoa.BackEnd.Model;
using Pessoa.BackEnd.Repository;

namespace Pessoa.BackEnd.Service
{
    public class PessoasService
    {
        private PessoasRepository _pessoasRepository;

        public PessoasService(PessoasRepository pessoasRepository)
        {
            _pessoasRepository = pessoasRepository;
        }
        public async Task CadastrarPessoas(DadosPessoais dadosPessoais)
        {
            if (dadosPessoais is null ) throw new Exception("dados pessoais encontra-se vazio");
            if(dadosPessoais.Pessoa is null) throw new Exception("Dados Pessoais encontra-se vazio");
            if (dadosPessoais.Endereco is null) throw new Exception("Endereço encontra-se vazio");
            if (dadosPessoais.Contatos is null) throw new Exception("Contatos encontra-se vazio");

            await _pessoasRepository.Salvar(dadosPessoais);
        }

        internal async Task GetPessoas(int idPessoa)
        {
            await _pessoasRepository.Listar(idPessoa);
        }
    }
}
