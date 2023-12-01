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
    public partial class frmListaActividades : Form
    {
        public frmListaActividades()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmListaActividades_Load);
        }
        frmPrincipal principal = new frmPrincipal();

        private void frmListaActividades_Load(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            if (usuarios.ListarActividades() == null)
            {
                Console.WriteLine("No hay actividades");
                MessageBox.Show("No hay actividades");
                principal.Show();
                this.Hide();

            }
            dtgvAct.DataSource = usuarios.ListarActividades();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}
