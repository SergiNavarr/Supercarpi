using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Interfaces
{
    public interface ICajaService
    {
        Task<Caja> AbrirCaja(int numero);
        Task<bool> CerrarCaja(int numero);
        Task<Caja> ObtenerCajaAbierta(int numero);
        Task<List<Caja>> ObtenerCajas();
        Task<List<Caja>> ObtenerCajasCerradas();
    }
}