using pruebaTecnicaMoventi.DTOs.Models;
using pruebaTecnicaMoventi.Repositories.Interfaces;
using pruebaTecnicaMoventi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaTecnicaMoventi.Services.Implementations
{
    public class DocumentTypeService : IDocumentTypeService
    {
        private readonly IDocumentTypeRepository _IDocumentTypeRepository;

        public DocumentTypeService(IDocumentTypeRepository documentTypeRepository)
        {
            _IDocumentTypeRepository = documentTypeRepository;
        }
        public List<Country> GetAllDocumentTypes()
        {
            return _IDocumentTypeRepository.GetAllDocumentTypes();
        }

        public Country GetDocumentTypesByCountry(Guid Id)
        {
            return _IDocumentTypeRepository.GetDocumentTypesByCountry(Id);
        }
    }
}
