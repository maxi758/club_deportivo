using DiseñoLogin.Datos;
using SistemaClubDeportivo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace club_deportivo
{
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }
        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" ||
            txtDNI.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;
                Socio persona = new Socio()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Dni = txtDNI.Text,
                    Direccion = txtDireccion.Text
                };

                // instanciamos para usar el metodo dentro de postulantes
                Usuarios usuario = new Usuarios();
                respuesta = usuario.CrearPersona(persona);
                Console.WriteLine(respuesta);
                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("POSTULANTE YA EXISTE", "AVISO DELSISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("se almaceno con exito con el codigo Nro " + respuesta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                    }
                }
            }
        }
        /* ===================================================
        * Limpiamos los objetos para un nuevo ingreso
        * ================================================ */
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtDireccion.Text = "";
            txtNombre.Focus();
        }
    }

}
