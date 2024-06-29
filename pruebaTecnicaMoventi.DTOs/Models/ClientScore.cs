using pruebaTecnicaMoventi.DTOs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaTecnicaMoventi.DTOs.Models
{
    public class ClientScore
    {
        public string DocumentoNumero { get; set; }
        public string Score { get; set; }
        public string RiskLevel { get; set; }
        public string ClientId { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Documento { get; set; }
    }
}         