﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using Negocio.Interfaces;

namespace Negocio.Implementacion
{
    public class UtilidadesService : IUtilidadesService
    {
        public string ConvertirSHA256(string texto)
        {
            StringBuilder sb = new StringBuilder();

            // Crear una instancia de SHA256
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;


                // Convertir el texto a un arreglo de bytes
                byte[] result = hash.ComputeHash(enc.GetBytes(texto));

                foreach (byte b in result)
                {
                    sb.Append(b.ToString("x2"));
                }
            }

            // Devolver el hash en formato hexadecimal
            return sb.ToString();
        }
    }
}
