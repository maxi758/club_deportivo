using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClubDeportivo
{
    internal class Cuota
    {
        private string? valorCuota;
        private int cantCuotas;
        private int fechaVencimiento;
        private string? metodoPago;

        public Cuota(string? valorCuota, int cantCuotas, int fechaVenciento, string? metodoPago)
        {
            ValorCuota = valorCuota;
            CantCuotas = cantCuotas;
            FechaVencimiento = fechaVenciento;
            MetodoPago = metodoPago;
        }

        public string? ValorCuota { get => valorCuota; set => valorCuota = value; }
        public int CantCuotas { get => cantCuotas; set => cantCuotas = value; }
        public int FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public string? MetodoPago { get => metodoPago; set => metodoPago = value; }
    }
}
