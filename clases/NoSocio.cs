using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClubDeportivo
{
    internal class NoSocio : Persona
    {

        private int? numNoSocio;

        public NoSocio(string nombre, string apellido, string direccion, string dni, int numNoSocio) : base(nombre, apellido, direccion, dni)
        {
            NumNoSocio = numNoSocio;
        }

        public int? NumNoSocio { get => numNoSocio; set => numNoSocio = value; }
    }
}
