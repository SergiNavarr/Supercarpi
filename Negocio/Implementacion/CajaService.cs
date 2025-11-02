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
        public class CajaService : ICajaService
        {
            private readonly IRepositorioGenerico<Caja> _cajaRepo;

            public CajaService(IRepositorioGenerico<Caja> cajaRepo)
            {
                _cajaRepo = cajaRepo;
            }

            public async Task<Caja> AbrirCaja(int numero)
            {
                // Buscar la caja por número
                var caja = await _cajaRepo.Obtener(c => c.Numero == numero && c.EsActivo);

                if (caja == null)
                    throw new Exception($"No existe la caja N° {numero}");

                if (caja.Abierto)
                    throw new Exception($"La caja N° {numero} ya está abierta");

                caja.Abierto = true;
                await _cajaRepo.Editar(caja);

                return caja;
            }

            public async Task<bool> CerrarCaja(int cajaId)
            {
                var caja = await _cajaRepo.Obtener(c => c.CajaId == cajaId && c.Abierto && c.EsActivo);
                if (caja == null)
                    throw new Exception("No se encontró una caja abierta con ese ID");

                caja.Abierto = false;
                return await _cajaRepo.Editar(caja);
            }
            public async Task<Caja> ObtenerCajaAbierta(int numero)
            {
                var consulta = await _cajaRepo.Consultar(c => c.Numero == numero && c.Abierto && c.EsActivo);
                return consulta.FirstOrDefault();
            }
            public async Task<List<Caja>> ObtenerCajas()
            {
                var consulta = await _cajaRepo.Consultar(c => c.EsActivo);
                return consulta.ToList();
            }

            public async Task<List<Caja>> ObtenerCajasCerradas()
            {
                var consulta = await _cajaRepo.Consultar(c => !c.Abierto && c.EsActivo);
                return consulta.ToList();
            }

        }
    }

