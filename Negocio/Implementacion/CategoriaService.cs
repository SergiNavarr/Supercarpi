using Entidades.Models;
using Negocio.Interfaces;
using Datos.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Implementacion
{
    public class CategoriaService : ICategoriaService
    {
        private readonly IRepositorioGenerico<Categoria> _repositorio;

        // Constructor
        public CategoriaService(IRepositorioGenerico<Categoria> repositorio)
        {
            _repositorio = repositorio;
        }

        public Task<Categoria> Crear(Categoria entidad)
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> Editar(Categoria empleado)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Categoria>> Lista()
        {
            throw new NotImplementedException();
        }

        public Task<Empleado> ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}