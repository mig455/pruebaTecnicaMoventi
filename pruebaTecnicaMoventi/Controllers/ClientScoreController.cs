using Microsoft.AspNetCore.Mvc;
using pruebaTecnicaMoventi.Services.Interfaces;

namespace pruebaTecnicaMoventi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientScoreController : Controller
    {
        private readonly IClientScoreService _clientScoreService;

        public ClientScoreController(IClientScoreService clientScoreService)
        {
            _clientScoreService = clientScoreService;
        }
        [HttpGet("{documentNumber}")]
        public IActionResult GetClientScore(string documentNumber)
        {
            var result = _clientScoreService.GetClientScoreByDocumentNumber(documentNumber);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound("Score no encontrado para el número de documento especificado.");
            }
        }
    }
}
