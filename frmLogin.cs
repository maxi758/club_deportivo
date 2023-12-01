using DiseñoLogin.Datos;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System.Data;

namespace club_deportivo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            /* este evento se ejecuta cuando llega el foco */
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            /* este evento se ejecuta cuando se va el foco */
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingreso exitoso", txtUsuario.Text);
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Usuarios dato = new Usuarios(); // variable que contiene todas las caracteristicas de la clase
            Console.WriteLine(txtUsuario.Text);
            Console.WriteLine(txtPass.Text);
            Console.WriteLine(dato);
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                // ____ quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE ___
                // _____ informamos con un mensaje al usuario _____
                MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*
                __________________________________________________________
                ___________________
                una vez que tenemos la conexion establecida PASAMOS al
                formulario PRINCIPAL
                Se debe "Instanciar" un objeto de la clase formulario
                principal
                ___________________________________________________________________________
                _______ */
                frmPrincipal Principal = new frmPrincipal();
                /*
                _________________________________________________________
                ___________
                * la siguiente linea permite tomar el dominio de la
                primera columna
                * de la primera fila del resultado de la ejecucion de la
                query
                *
                ________________________________________________________
                ____________ */
                Principal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                Principal.usuario = Convert.ToString(txtUsuario.Text);
                Principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "MENSAJES DEL SISTEMA",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}