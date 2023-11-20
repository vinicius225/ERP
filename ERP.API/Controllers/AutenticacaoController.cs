using ERP.API.Utils.Enuns;
using ERP.Aplication.Interfaces;
using ERP.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERP.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly IAutenticacaoService _autenticacaoService;
        private readonly ILogService _logService;

        public AutenticacaoController(IAutenticacaoService autenticacaoService, ILogService logService)
        {
            _autenticacaoService = autenticacaoService;
            _logService = logService;
        }

        [HttpPost]
        [Route("logar")]
        public ActionResult Logar(Usuario usuario)
        {
            try
            {
                throw new NotImplementedException();
                return Ok(_autenticacaoService.GerarToken(usuario));
            }catch (Exception ex)
            {
                _logService.Adicionar<Usuario, Exception>(usuario, ex, "logar", VerbosEnum.POST.ToString());
                return StatusCode(500, usuario);
            }
        }
    }
}
