using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.Models;

namespace Negocio.Interfaces
{
    public interface IEmpleadoService
    {
        Task<List<Empleado>> Lista();
        Task<Empleado> Crear(Empleado entidad);
        Task<Empleado> Editar(Empleado empleado);
        Task<bool> Eliminar(int id);
        Task<Empleado> ObtenerPorCredenciales(string dni, string password);
        Task<Empleado> ObtenerPorDni(string dni);
    }
}
