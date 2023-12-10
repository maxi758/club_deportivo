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
    public partial class carnet : Form
    {
        public carnet()
        {
            InitializeComponent();
            this.Load += new EventHandler(carnet_Load);
        }

        internal string nombre;
        internal string dni;
        internal string id;

        private void carnet_Load(object sender, EventArgs e)
        {
            lblNombre.Text = nombre;
            lblDNI.Text = dni;
            lblNPostu.Text = id;
        }
    }
}
