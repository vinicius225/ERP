using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace ERP.API.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(string producao)
        {
            try
            {
                return Ok();
            }catch (Exception ex)
            {
                return BadRequest("Erro no Servidor");
            }
        }
    }
}
