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
    public class ClientScoreService : IClientScoreService
    {
        private readonly IClientScoreRepository _clientScoreRepository;

        public ClientScoreService(IClientScoreRepository clientScoreRepository)
        {
            _clientScoreRepository = clientScoreRepository;
        }
        public ClientScore GetClientScoreByDocumentNumber(string documentNumber)
        {
            return _clientScoreRepository.GetClientScoreByDocumentNumber(documentNumber);
        }
    }
}
