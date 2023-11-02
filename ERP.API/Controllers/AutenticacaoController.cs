using ERP.Aplication.Interfaces;
using ERP.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly IAutenticacaoService _autenticacaoService;

        public AutenticacaoController(IAutenticacaoService autenticacaoService)
        {
            _autenticacaoService = autenticacaoService;
        }

        [HttpPost]
        [Route("logar")]
        public ActionResult Logar(Usuario usuario)
        {
            try
            {
                return Ok(_autenticacaoService.GerarToken(usuario));
            }catch (Exception ex)
            {
                return StatusCode(500, usuario);
            }
        }
    }
}
