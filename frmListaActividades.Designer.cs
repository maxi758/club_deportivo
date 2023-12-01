namespace club_deportivo
{
    partial class frmListaActividades
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
            dtgvAct = new DataGridView();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvAct).BeginInit();
            SuspendLayout();
            // 
            // dtgvAct
            // 
            dtgvAct.BackgroundColor = SystemColors.ActiveCaption;
            dtgvAct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgvAct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAct.Location = new Point(77, 32);
            dtgvAct.Name = "dtgvAct";
            dtgvAct.RowTemplate.Height = 25;
            dtgvAct.Size = new Size(642, 321);
            dtgvAct.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(350, 398);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmListaActividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(dtgvAct);
            Name = "frmListaActividades";
            Text = "frmListaActividades";
            ((System.ComponentModel.ISupportInitialize)dtgvAct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvAct;
        private Button btnVolver;
    }
}