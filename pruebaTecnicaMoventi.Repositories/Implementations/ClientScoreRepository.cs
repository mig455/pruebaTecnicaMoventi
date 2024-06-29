using pruebaTecnicaMoventi.DTOs.Models;
using pruebaTecnicaMoventi.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaTecnicaMoventi.Repositories.Implementations
{
    public class ClientScoreRepository : IClientScoreRepository
    {
        private List<ClientScore> clientScores = new List<ClientScore>
        {
            new ClientScore { ClientId = "1", Nombre = "Juan Perez", Pais = "Argentina", Documento = "DNI", DocumentoNumero = "12345678", Score = "A" },
            new ClientScore { ClientId = "2", Nombre = "Maria Lopez", Pais = "Argentina", Documento = "Pasaporte", DocumentoNumero = "A1234567", Score = "B" },
            new ClientScore { ClientId = "3", Nombre = "Pedro Sanchez", Pais = "Chile", Documento = "Cédula de Identidad", DocumentoNumero = "23456789", Score = "C" },
            new ClientScore { ClientId = "4", Nombre = "Ana Gomez", Pais = "Bolivia", Documento = "Cédula de Identidad", DocumentoNumero = "3456789", Score = "D" },
            new ClientScore { ClientId = "5", Nombre = "Luis Diaz", Pais = "Brasil", Documento = "Carteira de Identidade (RG)", DocumentoNumero = "45678912", Score = "E" },
            new ClientScore { ClientId = "6", Nombre = "Sofia Torres", Pais = "Colombia", Documento = "Cédula de Ciudadanía", DocumentoNumero = "5678901234", Score = "F" },
            new ClientScore { ClientId = "7", Nombre = "Miguel Ramirez", Pais = "Costa Rica", Documento = "Cédula de Identidad", DocumentoNumero = "678901234", Score = "G" },
            new ClientScore { ClientId = "8", Nombre = "Carla Fernandez", Pais = "Cuba", Documento = "Carné de Identidad", DocumentoNumero = "78901234567", Score = "H" },
            new ClientScore { ClientId = "9", Nombre = "Jorge Morales", Pais = "Ecuador", Documento = "Cédula de Identidad", DocumentoNumero = "8901234567", Score = "A" },
            new ClientScore { ClientId = "10", Nombre = "Rosa Castillo", Pais = "El Salvador", Documento = "Documento Único de Identidad (DUI)", DocumentoNumero = "901234567", Score = "B" },
            new ClientScore { ClientId = "11", Nombre = "Oscar Vargas", Pais = "Guatemala", Documento = "Documento Personal de Identificación (DPI)", DocumentoNumero = "0123456789012", Score = "C" },
            new ClientScore { ClientId = "12", Nombre = "Laura Rojas", Pais = "Honduras", Documento = "Tarjeta de Identidad", DocumentoNumero = "1234567890123", Score = "D" },
            new ClientScore { ClientId = "13", Nombre = "Daniel Gutierrez", Pais = "México", Documento = "CURP", DocumentoNumero = "ZXCV987654LKJHGF", Score = "E" },
            new ClientScore { ClientId = "14", Nombre = "Paula Sanchez", Pais = "Nicaragua", Documento = "Cédula de Identidad", DocumentoNumero = "23456789012345", Score = "F" },
            new ClientScore { ClientId = "15", Nombre = "Eduardo Martinez", Pais = "Panamá", Documento = "Cédula de Identidad", DocumentoNumero = "34567812", Score = "G" },
            new ClientScore { ClientId = "16", Nombre = "Martina Reyes", Pais = "Paraguay", Documento = "Cédula de Identidad", DocumentoNumero = "45678123", Score = "H" },
            new ClientScore { ClientId = "17", Nombre = "Lucas Jimenez", Pais = "Perú", Documento = "DNI", DocumentoNumero = "56781234", Score = "A" },
            new ClientScore { ClientId = "18", Nombre = "Valentina Ortiz", Pais = "Argentina", Documento = "Carné de Extranjería", DocumentoNumero = "B123456789", Score = "B" },
            new ClientScore { ClientId = "19", Nombre = "Gabriel Chavez", Pais = "Chile", Documento = "Pasaporte", DocumentoNumero = "C12345678", Score = "C" },
            new ClientScore { ClientId = "20", Nombre = "Marta Flores", Pais = "Bolivia", Documento = "Pasaporte", DocumentoNumero = "D1234567", Score = "D" },
            new ClientScore { ClientId = "21", Nombre = "José Silva", Pais = "Brasil", Documento = "Pasaporte", DocumentoNumero = "E12345678", Score = "E" },
            new ClientScore { ClientId = "22", Nombre = "Angela Moreno", Pais = "Colombia", Documento = "Pasaporte", DocumentoNumero = "F12345678", Score = "F" },
            new ClientScore { ClientId = "23", Nombre = "Carmen Diaz", Pais = "Costa Rica", Documento = "Pasaporte", DocumentoNumero = "G12345678", Score = "G" },
            new ClientScore { ClientId = "24", Nombre = "Raul Herrera", Pais = "Cuba", Documento = "Pasaporte", DocumentoNumero = "H12345678", Score = "H" },
            new ClientScore { ClientId = "25", Nombre = "Felipe Alvarado", Pais = "Ecuador", Documento = "Pasaporte", DocumentoNumero = "I12345678", Score = "A" }

        };
        public ClientScore GetClientScoreByDocumentNumber(string documentNumber)
        {
            return clientScores.FirstOrDefault(cs => cs.DocumentoNumero.Equals(documentNumber));
        }
    }
}
