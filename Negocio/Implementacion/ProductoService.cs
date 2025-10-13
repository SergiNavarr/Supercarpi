using Datos.Interfaces;
using Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Negocio.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negocio.Servicios
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
            return await _productoRepositorio.Crear(producto);
        }

        public async Task<Producto> ActualizarProducto(Producto producto)
        {
            await _productoRepositorio.Editar(producto);
            return producto;
        }

        public async Task<bool> EliminarProducto(Producto producto)
        {
            return await _productoRepositorio.Eliminar(producto);
        }

        public async Task<Producto> ObtenerPorId(int idProducto)
        {
            return await _productoRepositorio.Obtener(p => p.ProductoId == idProducto);
        }

        public async Task<List<Producto>> ObtenerTodos()
        {
            IQueryable<Producto> queryProducto = await _productoRepositorio.Consultar();
            return [.. queryProducto];
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
            return await query.ToListAsync();
        }

        public async Task<List<Producto>> BuscarPorCategoria(int idCategoria)
        {
            var query = await _productoRepositorio.Consultar(p => p.CategoriaId == idCategoria);
            return await query.ToListAsync();
        }

        public async Task<List<Producto>> ObtenerProductosConBajoStock(int limite)
        {
            var query = await _productoRepositorio.Consultar(p => p.StockActual <= limite);
            return await query.ToListAsync();
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