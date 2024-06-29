using Microsoft.AspNetCore.Mvc;
using pruebaTecnicaMoventi.DTOs.Models;
using pruebaTecnicaMoventi.Services.Interfaces;

namespace pruebaTecnicaMoventi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentTypeController : Controller
    {
        private readonly IDocumentTypeService _documentTypeService;

        public DocumentTypeController(IDocumentTypeService documentTypeService)
        {
            _documentTypeService = documentTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDocumentTypes()
        {
            var documentTypes = _documentTypeService.GetAllDocumentTypes();
            return Ok(documentTypes);
        }
        [HttpGet("{Id}")]
        public IActionResult GetDocumentTypeByCountry(Guid Id)
        {
            var result = _documentTypeService.GetDocumentTypesByCountry(Id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound("Tipo de documento no encontrado para el país especificado.");
            }
        }

    }
}
