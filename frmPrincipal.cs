using DiseñoLogin.Datos;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmPrincipal_Load);
        }

        internal string? rol;
        internal string? usuario;


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol +
            ")";

        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            frmInscripcion inscripcion = new frmInscripcion();
            inscripcion.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListadoSocios listado = new frmListadoSocios();
            listado.Show();
            this.Hide();
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            frmListaActividades actividades = new frmListaActividades();
            actividades.Show();
            this.Hide();
        }
    }
}
