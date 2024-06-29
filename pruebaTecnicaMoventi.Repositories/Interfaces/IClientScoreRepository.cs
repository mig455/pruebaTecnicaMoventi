using pruebaTecnicaMoventi.DTOs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaTecnicaMoventi.Repositories.Interfaces
{
    public interface IClientScoreRepository
    {
        ClientScore GetClientScoreByDocumentNumber(string documentNumber);
    }
}
