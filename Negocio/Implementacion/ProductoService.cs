using Datos.Interfaces;
using Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Negocio.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negocio.Implementacion
{
    public class ProductoService : IProductoService
    {
        private readonly IRepositorioGenerico<Producto> _productoRepositorio;

        public ProductoService(IRepositorioGenerico<Producto> productoRepositorio)
        {
            _productoRepositorio = productoRepositorio;
        }

        // --- CRUD básico ---
        public async Task<Producto> CrearProducto(Producto producto)
        {
            producto.ProductoId = 0;
            return await _productoRepositorio.Crear(producto);
        }


        public async Task<Producto> ActualizarProducto(Producto producto)
        {
            var productoDb = await _productoRepositorio.Obtener(p => p.ProductoId == producto.ProductoId);
            if (productoDb == null)
                throw new InvalidOperationException("Producto no encontrado.");

            productoDb.Nombre = producto.Nombre;
            productoDb.Descripcion = producto.Descripcion;
            productoDb.PrecioUnitario = producto.PrecioUnitario;
            productoDb.StockActual = producto.StockActual;
            productoDb.MarcaId = producto.MarcaId;
            productoDb.CategoriaId = producto.CategoriaId;
            productoDb.ImagenUrl = producto.ImagenUrl;

            await _productoRepositorio.Editar(productoDb);
            return productoDb;
        }


        public async Task<bool> EliminarProducto(int idProducto)
        {
            var producto = await ObtenerPorId(idProducto);
            if (producto == null)
                return false;

            return await _productoRepositorio.Eliminar(producto);
        }



        public async Task<Producto?> ObtenerPorId(int idProducto)
        {
            var query = await _productoRepositorio.Consultar(p => p.ProductoId == idProducto);
            return await query
                .Include(p => p.Marca)
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync();
        }


        public async Task<List<Producto>> ObtenerTodos()
        {
            var query = await _productoRepositorio.Consultar(p => p.EsActivo);
            return await query
                .AsNoTracking()
                .Include(p => p.Marca)
                .Include(p => p.Categoria)
                .ToListAsync();
        }


        // --- Operaciones de negocio ---
        public async Task DescontarStock(int idProducto, int cantidad)
        {
            var producto = await ObtenerPorId(idProducto);
            if (producto != null && producto.StockActual >= cantidad)
            {
                producto.StockActual -= cantidad;
                await _productoRepositorio.Editar(producto);
            }
        }

        public async Task AumentarStock(int idProducto, int cantidad)
        {
            var producto = await ObtenerPorId(idProducto);
            if (producto != null)
            {
                producto.StockActual += cantidad;
                await _productoRepositorio.Editar(producto);
            }
        }

        public async Task<bool> HayStockDisponible(int idProducto, int cantidad)
        {
            var producto = await ObtenerPorId(idProducto);
            return producto != null && producto.StockActual >= cantidad;
        }

        // --- Búsquedas y filtrado ---
        public async Task<List<Producto>> BuscarPorNombre(string nombre)
        {
            var query = await _productoRepositorio.Consultar(p => p.Nombre.Contains(nombre));
            return await query
                .AsNoTracking()
                .Include(p => p.Marca)
                .Include(p => p.Categoria)
                .ToListAsync();
        }


        public async Task<List<Producto>> BuscarPorCategoria(int idCategoria)
        {
            var query = await _productoRepositorio.Consultar(p => p.CategoriaId == idCategoria);
            return await query
                .AsNoTracking()
                .Include(p => p.Marca)
                .Include(p => p.Categoria)
                .ToListAsync();
        }

        public async Task<List<Producto>> ObtenerProductosConBajoStock(int limite)
        {
            var query = await _productoRepositorio.Consultar(p => p.StockActual <= limite);
            return await query
                .AsNoTracking()
                .Include(p => p.Marca)
                .Include(p => p.Categoria)
                .ToListAsync();
        }

        // --- Manejo de imágenes ---
        public async Task AsignarImagen(int idProducto, string rutaImagen)
        {
            var producto = await ObtenerPorId(idProducto);
            if (producto != null)
            {
                producto.ImagenUrl = rutaImagen;
                await _productoRepositorio.Editar(producto);
            }
        }

        public async Task<string> ObtenerRutaImagen(int idProducto)
        {
            var producto = await ObtenerPorId(idProducto);
            return producto?.ImagenUrl;
        }

        public async Task EliminarImagen(int idProducto)
        {
            var producto = await ObtenerPorId(idProducto);
            if (producto != null)
            {
                producto.ImagenUrl = null;
                await _productoRepositorio.Editar(producto);
            }
        }
    }
}