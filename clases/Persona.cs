using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClubDeportivo
{
    internal class Persona
    {
        string nombre;
        string apellido;
        string direccion;
        string dni;

        public Persona()
        {
        }

        public Persona(string nombre, string apellido, string direccion, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Dni { get => dni; set => dni = value; }


        public override string ToString()
        {
            return "Nombre: " + nombre + " -Apellido: " + apellido + " -direccion: " + direccion + " -DNI: " + dni;
        }
    }
}
