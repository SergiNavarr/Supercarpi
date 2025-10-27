using Datos.Interfaces;
using Entidades.Models;
using Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Implementacion
{
    public class PagoService : IPagoService
    {
        private readonly IRepositorioGenerico<Pago> _pagoRepo;
        private readonly IRepositorioGenerico<PagoTarjeta> _pagoTarjetaRepo;

        public PagoService(IRepositorioGenerico<Pago> pagoRepo,
                           IRepositorioGenerico<PagoTarjeta> pagoTarjetaRepo)
        {
            _pagoRepo = pagoRepo;
            _pagoTarjetaRepo = pagoTarjetaRepo;
        }

      
        public async Task<bool> RegistrarPago(Pago pago, PagoTarjeta pagoTarjeta = null)
        {
            if (pago == null) return false;

            var pagoCreado = await _pagoRepo.Crear(pago);

            if (pagoTarjeta != null)
            {
                pagoTarjeta.PagoId = pagoCreado.PagoId;
                await _pagoTarjetaRepo.Crear(pagoTarjeta);
            }

            return true;
        }

        public async Task<List<Pago>> ObtenerPagosPorVenta(int ventaId)
        {
            var consulta = await _pagoRepo.Consultar(p => p.VentaId == ventaId);
            return consulta.ToList();
        }

        public async Task<Pago> ObtenerPagoPorId(int pagoId)
        {
            return await _pagoRepo.Obtener(p => p.PagoId == pagoId);
        }
    }
}