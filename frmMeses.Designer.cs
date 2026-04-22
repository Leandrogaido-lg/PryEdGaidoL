namespace PryEdGaidoL
{
    partial class frmMeses
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lstbMeses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombre.Location = new System.Drawing.Point(37, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 24);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombreM
            // 
            this.txtNombreM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombreM.Location = new System.Drawing.Point(172, 65);
            this.txtNombreM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(260, 30);
            this.txtNombreM.TabIndex = 1;
            this.txtNombreM.TextChanged += new System.EventHandler(this.txtNombreM_TextChanged);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(43, 166);
            this.btnListar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(181, 34);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(263, 166);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(169, 34);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lstbMeses
            // 
            this.lstbMeses.FormattingEnabled = true;
            this.lstbMeses.ItemHeight = 16;
            this.lstbMeses.Location = new System.Drawing.Point(43, 222);
            this.lstbMeses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbMeses.Name = "lstbMeses";
            this.lstbMeses.Size = new System.Drawing.Size(391, 228);
            this.lstbMeses.TabIndex = 4;
            // 
            // frmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 462);
            this.Controls.Add(this.lstbMeses);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMeses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ListBox lstbMeses;
    }
}