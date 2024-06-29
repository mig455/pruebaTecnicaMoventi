using pruebaTecnicaMoventi.DTOs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaTecnicaMoventi.Services.Interfaces
{
    public interface IDocumentTypeService
    {
        List<Country> GetAllDocumentTypes();
        Country GetDocumentTypesByCountry(Guid Id);
    }
}
