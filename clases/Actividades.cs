using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClubDeportivo
{
    internal class Actividades
    {
        List<string> listaDeActividades = new List<string>();
        private string? preciosDeActividades;

        public Actividades(List<string> listaDeActividades, string? preciosDeActividades)
        {
            ListaDeActividades = listaDeActividades;
            PreciosDeActividades = preciosDeActividades;
        }

        public List<string> ListaDeActividades { get => listaDeActividades; set => listaDeActividades = value; }
        public string? PreciosDeActividades { get => preciosDeActividades; set => preciosDeActividades = value; }
    }
}

