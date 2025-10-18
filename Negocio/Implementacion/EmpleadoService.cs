using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Datos.Interfaces;
using Entidades.Models;
using Negocio.Interfaces;

namespace Negocio.Implementacion
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IRepositorioGenerico<Empleado> _repoEmpleado;
        private readonly IUtilidadesService _utilidadesService;

        public EmpleadoService(IRepositorioGenerico<Empleado> repoEmpleado, IUtilidadesService utilidadesService)
        {
            _repoEmpleado = repoEmpleado;
            _utilidadesService = utilidadesService;
        }

        public async Task<List<Empleado>> Lista()
        {
            IQueryable<Empleado> queryEmpleado = await _repoEmpleado.Consultar();
            return await queryEmpleado.Include(r => r.Rol).ToListAsync();
        }

        public async Task<Empleado> Crear(Empleado entidad)
        {
            //validamos existencia del empleado
            Empleado empleado_existe = await _repoEmpleado.Obtener(e => e.Dni == entidad.Dni);
            if (empleado_existe != null)
                throw new InvalidOperationException("El empleado ya se encuentra registrado");

            try
            {
                entidad.PasswordHash = _utilidadesService.ConvertirSHA256(entidad.PasswordHash);

                Empleado empleado_creado = await _repoEmpleado.Crear(entidad);
                
                return empleado_creado;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo crear el empleado", ex);

            }
        }

        public async Task<Empleado> Editar(Empleado empleado)
        {
            //validamos existencia del empleado
            Empleado empleado_existe = await _repoEmpleado.Obtener(e => e.Dni == empleado.Dni);
            if (empleado_existe != null)
            {

                try
                {
                    //Buscar empleado a editar
                    IQueryable<Empleado> queryEmpleado = await _repoEmpleado.Consultar(e => e.Dni == empleado.Dni);
                    //crear el nuevo usuario
                    Empleado empleado_editar = queryEmpleado.First();
                    empleado_editar.Nombre = empleado.Nombre;
                    empleado_editar.Apellido = empleado.Apellido;
                    empleado_editar.Telefono = empleado.Telefono;
                    empleado_editar.Email = empleado.Email;
                    empleado_editar.RolId = empleado.RolId;
                    // empleado_editar.EsActivo = empleado.EsActivo;  --Luego hay que cambiar la bd

                    bool respuesta = await _repoEmpleado.Editar(empleado_editar);

                    if (!respuesta)
                        throw new Exception("No se pudo editar el empleado");

                    Empleado empleado_actualizado = queryEmpleado.Include(r => r.Rol).First();

                    return empleado_editar;

                }
                catch (Exception ex)
                {
                    throw new Exception("No se pudo editar el empleado", ex);
                }
            }
            else
            {
                throw new InvalidOperationException("El empleado no existe");
            }
        }

        public async Task<bool> Eliminar(int id)
        {
            try
            {
                //Buscar el empleado por ID
                Empleado empleadoEncontrado = await _repoEmpleado.Obtener(e => e.EmpleadoId == id);
                //Si no existe, lanzar excepcion
                if (empleadoEncontrado == null)
                    throw new Exception("El empleado no existe");

                //eliminar el empleado
                bool respuesta = await _repoEmpleado.Eliminar(empleadoEncontrado);
                return respuesta;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el empleado", ex);
            }

        }

        public async Task<Empleado> ObtenerPorCredenciales(string dni, string password)
        {
            string clave_encriptada = _utilidadesService.ConvertirSHA256(password);

            Empleado usuario_encontrado = await _repoEmpleado.Obtener(u => u.Dni.Equals(dni) && u.PasswordHash.Equals(clave_encriptada));

            return usuario_encontrado;
        }

        public async Task<Empleado> ObtenerPorDni(string dni)
        {
            IQueryable<Empleado> query = await _repoEmpleado.Consultar(u => u.Dni.Equals(dni));

            Empleado empleadoEncontrado = query.Include(r => r.Rol).FirstOrDefault();

            return empleadoEncontrado;
        }
    }
}
