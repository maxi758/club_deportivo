namespace club_deportivo
{
    partial class carnet
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
            lblDNI = new Label();
            lblNPostu = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(263, 91);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(145, 37);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "lblNombre";
            lblNombre.Click += carnet_Load;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblDNI.Location = new Point(263, 198);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(71, 30);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "label1";
            // 
            // lblNPostu
            // 
            lblNPostu.AutoSize = true;
            lblNPostu.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblNPostu.Location = new Point(263, 286);
            lblNPostu.Name = "lblNPostu";
            lblNPostu.Size = new Size(71, 30);
            lblNPostu.TabIndex = 2;
            lblNPostu.Text = "label1";
            // 
            // carnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNPostu);
            Controls.Add(lblDNI);
            Controls.Add(lblNombre);
            Name = "carnet";
            Text = "carnet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblDNI;
        private Label lblNPostu;
    }
}