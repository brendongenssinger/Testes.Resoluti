using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Logging;
using Pessoa.BackEnd.Model;
using Pessoa.BackEnd.Service;

namespace Pessoa.BackEnd.Controllers
{
    public class PessoasController : ControllerBase
    {
        private Logger<PessoasController> _log;
        private PessoasService _pessoaService;

        public PessoasController(Logger<PessoasController> logger,PessoasService pessoaService)
        {
            _log = logger;
            _pessoaService = pessoaService;
        }

        [HttpPost(Name ="Cadastrar Pessoa",Order = 0)]
        public async IActionResult Post(DadosPessoais dadosPessoais)
        {
            try
            {
               await _pessoaService.CadastrarPessoas(dadosPessoais);
                return StatusCode(200,"OK");
            }
            catch (Exception eX)
            {
                _log.LogError(eX, "Error Controller [Pessoas Controller]");
                return StatusCode(400);
            }
        }
    }
}
