using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClubDeportivo
{
    internal class Socio : Persona
    {
        private int? numCarnetSocio;

        public Socio()
        {
        }

        public Socio(string nombre, string apellido, string direccion, string dni, int numCarnetSocio) : base(nombre, apellido, direccion, dni)
        {
            NumCarnetSocio = numCarnetSocio;
        }

        public int? NumCarnetSocio { get => numCarnetSocio; set => numCarnetSocio = value; }
    }
}

