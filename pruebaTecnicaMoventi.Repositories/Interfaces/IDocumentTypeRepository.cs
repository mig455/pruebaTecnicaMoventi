using pruebaTecnicaMoventi.DTOs.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pruebaTecnicaMoventi.Repositories.Interfaces
{
    public interface IDocumentTypeRepository
    {
        List<Country> GetAllDocumentTypes();
        Country GetDocumentTypesByCountry(Guid Id);
    }
}
