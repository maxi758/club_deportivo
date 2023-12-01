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
    public partial class frmListadoSocios : Form
    {
        public frmListadoSocios()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmListadoSocios_Load);
        }

        private void frmListadoSocios_Load(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            if (usuarios.ListarPersonas() == null)
            {
                Console.WriteLine("No hay usuarios");
                MessageBox.Show("No hay usuarios");
            }

            dtgv1.DataSource = usuarios.ListarPersonas();

        }
    }
}
