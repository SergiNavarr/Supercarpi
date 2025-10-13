using Entidades.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Negocio.Interfaces
{
    public interface IProductoService
    {
        // CRUD básico (todas acceden a BD)
        Task<Producto> CrearProducto(Producto producto);
        Task<Producto> ActualizarProducto(Producto producto);
        Task<bool> EliminarProducto(Producto producto);
        Task<Producto> ObtenerPorId(int idProducto);
        Task<List<Producto>> ObtenerTodos();

        // Operaciones de negocio (también tocan BD)
        Task DescontarStock(int idProducto, int cantidad);
        Task AumentarStock(int idProducto, int cantidad);
        Task<bool> HayStockDisponible(int idProducto, int cantidad);

        // Búsquedas y filtrado (acceden a BD)
        Task<List<Producto>> BuscarPorNombre(string nombre);
        Task<List<Producto>> BuscarPorCategoria(int idCategoria);
        Task<List<Producto>> ObtenerProductosConBajoStock(int limite);

        // Imágenes (si se almacenan en BD o ruta)
        Task AsignarImagen(int idProducto, string rutaImagen);
        Task<string> ObtenerRutaImagen(int idProducto);
        Task EliminarImagen(int idProducto);
    }
}
