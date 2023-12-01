namespace club_deportivo
{
    partial class frmListadoSocios
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
            dtgv1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgv1).BeginInit();
            SuspendLayout();
            // 
            // dtgv1
            // 
            dtgv1.BackgroundColor = SystemColors.ActiveCaption;
            dtgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv1.Location = new Point(26, 22);
            dtgv1.Name = "dtgv1";
            dtgv1.RowTemplate.Height = 25;
            dtgv1.Size = new Size(739, 416);
            dtgv1.TabIndex = 5;
            dtgv1.Text = "Listado de Socios";
            // 
            // frmListadoSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgv1);
            Name = "frmListadoSocios";
            Text = "ListadoSocios";
            ((System.ComponentModel.ISupportInitialize)dtgv1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgv1;
    }
}