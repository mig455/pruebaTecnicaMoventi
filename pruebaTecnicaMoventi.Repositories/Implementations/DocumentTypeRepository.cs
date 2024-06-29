using pruebaTecnicaMoventi.DTOs.Models;
using pruebaTecnicaMoventi.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaTecnicaMoventi.Repositories.Implementations
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {

        private List<Country> countries = new List<Country>
        {
            new Country
            {
                NombrePais = "Perú",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "Documento Nacional de Identidad (DNI)", LongitudMinima = 8, LongitudMaxima = 8, EsAlfanumerico = false },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 9, LongitudMaxima = 9, EsAlfanumerico = true },
                    new Document { Nombre = "Carné de Extranjería", LongitudMinima = 11, LongitudMaxima = 11, EsAlfanumerico = false }
                }
            },
            new Country
            {
                NombrePais = "Argentina",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "DNI", LongitudMinima = 8, LongitudMaxima = 8, EsAlfanumerico = false },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 8, LongitudMaxima = 8, EsAlfanumerico = false },
                    new Document { Nombre = "Carné de Extranjería", LongitudMinima = 10, LongitudMaxima = 10, EsAlfanumerico = true }
                }
            },
            new Country
            {
                NombrePais = "Bolivia",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "Cédula de Identidad", LongitudMinima = 7, LongitudMaxima = 8, EsAlfanumerico = false },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 7, LongitudMaxima = 8, EsAlfanumerico = false }
                }
            },
            new Country
            {
                NombrePais = "Brasil",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "Carteira de Identidade (RG)", LongitudMinima = 8, LongitudMaxima = 9, EsAlfanumerico = true },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 9, LongitudMaxima = 9, EsAlfanumerico = true }
                }
            },
            new Country
            {
                NombrePais = "Chile",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "Cédula de Identidad", LongitudMinima = 7, LongitudMaxima = 9, EsAlfanumerico = false },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 9, LongitudMaxima = 9, EsAlfanumerico = true },
                    new Document { Nombre = "Carné de Extranjería", LongitudMinima = 11, LongitudMaxima = 11, EsAlfanumerico = false }
                }
            },
            new Country
            {
                NombrePais = "Colombia",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "Cédula de Ciudadanía", LongitudMinima = 10, LongitudMaxima = 10, EsAlfanumerico = false },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 9, LongitudMaxima = 9, EsAlfanumerico = true },
                    new Document { Nombre = "Cédula de Extranjería", LongitudMinima = 10, LongitudMaxima = 10, EsAlfanumerico = false }
                }
            },
            new Country
            {
                NombrePais = "Costa Rica",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "Cédula de Identidad", LongitudMinima = 9, LongitudMaxima = 9, EsAlfanumerico = false },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 9, LongitudMaxima = 9, EsAlfanumerico = true },
                    new Document { Nombre = "Documento de Identidad de Extranjeros (DIMEX)", LongitudMinima = 11, LongitudMaxima = 11, EsAlfanumerico = false }
                }
            },
            new Country
            {
                NombrePais = "Cuba",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "Carné de Identidad", LongitudMinima = 11, LongitudMaxima = 11, EsAlfanumerico = false },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 9, LongitudMaxima = 9, EsAlfanumerico = true }
                }
            },
            new Country
            {
                NombrePais = "Ecuador",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "Cédula de Identidad", LongitudMinima = 10, LongitudMaxima = 10, EsAlfanumerico = false },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 9, LongitudMaxima = 9, EsAlfanumerico = true }
                }
            },
            new Country
            {
                NombrePais = "El Salvador",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "Documento Único de Identidad (DUI)", LongitudMinima = 9, LongitudMaxima = 9, EsAlfanumerico = false },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 9, LongitudMaxima = 9, EsAlfanumerico = true }
                }
            },
            new Country
            {
                NombrePais = "Guatemala",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "Documento Personal de Identificación (DPI)", LongitudMinima = 13, LongitudMaxima = 13, EsAlfanumerico = false },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 8, LongitudMaxima = 8, EsAlfanumerico = true }
                }
            },
            new Country
            {
                NombrePais = "Honduras",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "Tarjeta de Identidad", LongitudMinima = 13, LongitudMaxima = 13, EsAlfanumerico = false },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 8, LongitudMaxima = 8, EsAlfanumerico = true }
                }
            },
            new Country
            {
                NombrePais = "México",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "CURP", LongitudMinima = 18, LongitudMaxima = 18, EsAlfanumerico = true },
                    new Document { Nombre = "Credencial para Votar (INE)", LongitudMinima = 13, LongitudMaxima = 13, EsAlfanumerico = true },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 9, LongitudMaxima = 9, EsAlfanumerico = true },
                    new Document { Nombre = "Tarjeta de Residente Temporal/Permanente", LongitudMinima = 18, LongitudMaxima = 18, EsAlfanumerico = true }
                }
            },
            new Country
            {
                NombrePais = "Nicaragua",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "Cédula de Identidad", LongitudMinima = 14, LongitudMaxima = 14, EsAlfanumerico = false },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 9, LongitudMaxima = 9, EsAlfanumerico = true }
                }
            },
            new Country
            {
                NombrePais = "Panamá",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "Cédula de Identidad", LongitudMinima = 8, LongitudMaxima = 8, EsAlfanumerico = false },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 9, LongitudMaxima = 9, EsAlfanumerico = true },
                    new Document { Nombre = "Carné de Residente Permanente", LongitudMinima = 8, LongitudMaxima = 8, EsAlfanumerico = false }
                }
            },
            new Country
            {
                NombrePais = "Paraguay",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "Cédula de Identidad", LongitudMinima = 8, LongitudMaxima = 8, EsAlfanumerico = false },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 9, LongitudMaxima = 9, EsAlfanumerico = true }
                }
            },
            new Country
            {
                NombrePais = "Puerto Rico",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "Licencia de Conducir", LongitudMinima = 7, LongitudMaxima = 8, EsAlfanumerico = true },
                    new Document { Nombre = "Pasaporte Estadounidense", LongitudMinima = 9, LongitudMaxima = 9, EsAlfanumerico = true }
                }
            },
            new Country
            {
                NombrePais = "República Dominicana",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "Cédula de Identidad y Electoral", LongitudMinima = 11, LongitudMaxima = 11, EsAlfanumerico = true },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 9, LongitudMaxima = 9, EsAlfanumerico = true }
                }
            },
            new Country
            {
                NombrePais = "Uruguay",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "Cédula de Identidad", LongitudMinima = 8, LongitudMaxima = 8, EsAlfanumerico = false },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 9, LongitudMaxima = 9, EsAlfanumerico = true }
                }
            },
            new Country
            {
                NombrePais = "Venezuela",
                Id = Guid.NewGuid(),
                Documentos = new List<Document>
                {
                    new Document { Nombre = "Cédula de Identidad", LongitudMinima = 8, LongitudMaxima = 9, EsAlfanumerico = false },
                    new Document { Nombre = "Pasaporte", LongitudMinima = 9, LongitudMaxima = 9, EsAlfanumerico = true }
                }
            }
        };

        public List<Country> GetAllDocumentTypes()
        {
            return countries;
        }
        public Country GetDocumentTypesByCountry(Guid Id)
        {
            var result = countries.Where(x => x.Id.ToString() == Id.ToString()).FirstOrDefault();
            return result;
        }
    }
}
