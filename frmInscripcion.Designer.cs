namespace club_deportivo
{
    partial class frmInscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblApellido = new Label();
            lblDireccion = new Label();
            lblDNI = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDireccion = new TextBox();
            txtDNI = new TextBox();
            btnVolver = new Button();
            btnInscribir = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(449, 53);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(449, 101);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(449, 142);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 2;
            lblDireccion.Text = "Direccion";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(449, 180);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(599, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(599, 98);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(599, 139);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 6;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(599, 180);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 7;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(249, 258);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new Point(599, 258);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(75, 23);
            btnInscribir.TabIndex = 9;
            btnInscribir.Text = "Inscribirse";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(599, 312);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Borrar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnInscribir);
            Controls.Add(btnVolver);
            Controls.Add(txtDNI);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDNI);
            Controls.Add(lblDireccion);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "frmInscripcion";
            Text = "frmInscripcion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDireccion;
        private Label lblDNI;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDireccion;
        private TextBox txtDNI;
        private Button btnVolver;
        private Button btnInscribir;
        private Button btnLimpiar;
    }
}