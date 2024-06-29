using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaTecnicaMoventi.DTOs.Models
{
    public class Country
    {
        public string NombrePais { get; set; }
        public Guid Id { get; set; }
        public List<Document> Documentos { get; set; }
    }
}
