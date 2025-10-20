using Datos.Interfaces;
using Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negocio.Implementacion
{
    public class MarcaService : IMarcaService
    {
        private readonly IRepositorioGenerico<Marca> _marcaRepo;

        public MarcaService(IRepositorioGenerico<Marca> repositorio)
        {
            _marcaRepo = repositorio ?? throw new ArgumentNullException(nameof(repositorio));
        }

        public async Task<Marca> Crear(Marca entidad)
        {
            if (entidad == null)
                throw new ArgumentNullException(nameof(entidad));

            if (string.IsNullOrWhiteSpace(entidad.Nombre))
                throw new ArgumentException("El nombre de la marca no puede estar vacío.", nameof(entidad.Nombre));

            var existe = await _marcaRepo.Obtener(m => m.Nombre.ToLower() == entidad.Nombre.ToLower());
            if (existe != null)
                throw new InvalidOperationException("Ya existe una marca con ese nombre.");

            return await _marcaRepo.Crear(entidad);
        }

        public async Task<Marca> Editar(Marca entidad)
        {
            if (entidad == null)
                throw new ArgumentNullException(nameof(entidad));

            if (string.IsNullOrWhiteSpace(entidad.Nombre))
                throw new ArgumentException("El nombre de la marca no puede estar vacío.", nameof(entidad.Nombre));

            var marcaDb = await _marcaRepo.Obtener(m => m.MarcaId == entidad.MarcaId);
            if (marcaDb == null)
                throw new InvalidOperationException("La marca no existe.");

            var duplicada = await _marcaRepo.Obtener(m =>
                m.Nombre.ToLower() == entidad.Nombre.ToLower() &&
                m.MarcaId != entidad.MarcaId);

            if (duplicada != null)
                throw new InvalidOperationException("Ya existe otra marca con ese nombre.");

            await _marcaRepo.Editar(entidad);
            return entidad;
        }

        public async Task<bool> Eliminar(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID de la marca no es válido.", nameof(id));

            var marca = await _marcaRepo.Obtener(m => m.MarcaId == id);
            if (marca == null)
                return false;

            return await _marcaRepo.Eliminar(marca);
        }

        public async Task<List<Marca>> Lista()
        {
            var query = await _marcaRepo.Consultar();
            if (query == null)
                return new List<Marca>();

            return await query
                .Include(m => m.Productos) // opcional: solo si querés traer los productos
                .ToListAsync();
        }

        public async Task<Marca?> ObtenerPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID no es válido.", nameof(id));

            var query = await _marcaRepo.Consultar(m => m.MarcaId == id);
            if (query == null)
                return null;

            return await query
                .Include(m => m.Productos) // opcional
                .FirstOrDefaultAsync();
        }
    }
}