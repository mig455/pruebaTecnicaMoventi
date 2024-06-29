using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaTecnicaMoventi.DTOs.Models
{
    public class Document
    {
        public string Nombre { get; set; }
        public int LongitudMinima { get; set; }
        public int LongitudMaxima { get; set; }
        public bool EsAlfanumerico { get; set; }
    }
}
