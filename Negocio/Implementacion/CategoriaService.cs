using Datos.Interfaces;
using Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Implementacion
{
    public class CategoriaService : ICategoriaService
    {
        private readonly IRepositorioGenerico<Categoria> _categoriaRepo;

        // Constructor
        public CategoriaService(IRepositorioGenerico<Categoria> repositorio)
        {
            _categoriaRepo = repositorio;
        }

        public async Task<Categoria> Crear(Categoria entidad)
        {
            if (entidad == null)
                throw new ArgumentNullException(nameof(entidad));

            if (string.IsNullOrWhiteSpace(entidad.Nombre))
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.", nameof(entidad.Nombre));

            var existe = await _categoriaRepo.Obtener(c => c.Nombre.ToLower() == entidad.Nombre.ToLower());
            if (existe != null)
                throw new InvalidOperationException("Ya existe una categoría con ese nombre.");

            return await _categoriaRepo.Crear(entidad);
        }

        public async Task<Categoria> Editar(Categoria entidad)
        {
            if (entidad == null)
                throw new ArgumentNullException(nameof(entidad));

            if (string.IsNullOrWhiteSpace(entidad.Nombre))
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.", nameof(entidad.Nombre));

            var categoriaDb = await _categoriaRepo.Obtener(c => c.CategoriaId == entidad.CategoriaId);
            if (categoriaDb == null)
                throw new InvalidOperationException("La categoría no existe.");

            var duplicada = await _categoriaRepo.Obtener(c =>
                c.Nombre.ToLower() == entidad.Nombre.ToLower() &&
                c.CategoriaId != entidad.CategoriaId);

            if (duplicada != null)
                throw new InvalidOperationException("Ya existe otra categoría con ese nombre.");

            await _categoriaRepo.Editar(entidad);
            return entidad;
        }

        public async Task<bool> Eliminar(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID de la categoría no es válido.", nameof(id));

            var categoria = await _categoriaRepo.Obtener(c => c.CategoriaId == id);
            if (categoria == null)
                return false;

            return await _categoriaRepo.Eliminar(categoria);
        }

        public async Task<List<Categoria>> Lista()
        {
            var query = await _categoriaRepo.Consultar();
            return await query
                .Include(c => c.Proveedor)
                .Include(c => c.Productos)
                .ToListAsync();
        }

        public async Task<Categoria?> ObtenerPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID no es válido.", nameof(id));

            var query = await _categoriaRepo.Consultar(c => c.CategoriaId == id);
            if (query == null)
                return null;

            return await query
                .Include(c => c.Proveedor)
                .Include(c => c.Productos)
                .FirstOrDefaultAsync();
        }

    }
}