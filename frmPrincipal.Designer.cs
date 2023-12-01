using System.Data;

namespace club_deportivo
{
    partial class frmPrincipal
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
            btnInscribir = new Button();
            btnSalir = new Button();
            lblIngreso = new Label();
            btnListado = new Button();
            btnActividades = new Button();
            SuspendLayout();
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = SystemColors.MenuHighlight;
            btnInscribir.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnInscribir.ForeColor = SystemColors.ButtonHighlight;
            btnInscribir.Location = new Point(53, 92);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(193, 112);
            btnInscribir.TabIndex = 0;
            btnInscribir.Text = "Inscribirse";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Crimson;
            btnSalir.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ButtonFace;
            btnSalir.Location = new Point(690, 21);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 37);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(23, 9);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(46, 15);
            lblIngreso.TabIndex = 2;
            lblIngreso.Text = "usuario";
            // 
            // btnListado
            // 
            btnListado.BackColor = SystemColors.MenuHighlight;
            btnListado.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnListado.ForeColor = SystemColors.ButtonHighlight;
            btnListado.Location = new Point(53, 246);
            btnListado.Name = "btnListado";
            btnListado.Size = new Size(193, 118);
            btnListado.TabIndex = 3;
            btnListado.Text = "Listado de Socios";
            btnListado.UseVisualStyleBackColor = false;
            btnListado.Click += btnListado_Click;
            // 
            // btnActividades
            // 
            btnActividades.BackColor = SystemColors.MenuHighlight;
            btnActividades.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnActividades.ForeColor = SystemColors.ButtonHighlight;
            btnActividades.Location = new Point(419, 246);
            btnActividades.Name = "btnActividades";
            btnActividades.Size = new Size(193, 118);
            btnActividades.TabIndex = 4;
            btnActividades.Text = "Listado de Actividades";
            btnActividades.UseVisualStyleBackColor = false;
            btnActividades.Click += btnActividades_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActividades);
            Controls.Add(btnListado);
            Controls.Add(lblIngreso);
            Controls.Add(btnSalir);
            Controls.Add(btnInscribir);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInscribir;
        private Button btnSalir;
        private Label lblIngreso;
        private Button btnListado;
        private Button btnActividades;
    }
}