namespace PryEdGaidoL
{
    partial class frmColores
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
            this.btnListarC = new System.Windows.Forms.Button();
            this.btnGrabarC = new System.Windows.Forms.Button();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.lstbColores = new System.Windows.Forms.ListBox();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnListarC
            // 
            this.btnListarC.Location = new System.Drawing.Point(18, 143);
            this.btnListarC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarC.Name = "btnListarC";
            this.btnListarC.Size = new System.Drawing.Size(122, 34);
            this.btnListarC.TabIndex = 0;
            this.btnListarC.Text = "Listar";
            this.btnListarC.UseVisualStyleBackColor = true;
            // 
            // btnGrabarC
            // 
            this.btnGrabarC.Location = new System.Drawing.Point(172, 143);
            this.btnGrabarC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGrabarC.Name = "btnGrabarC";
            this.btnGrabarC.Size = new System.Drawing.Size(122, 34);
            this.btnGrabarC.TabIndex = 1;
            this.btnGrabarC.Text = "Grabar";
            this.btnGrabarC.UseVisualStyleBackColor = true;
            this.btnGrabarC.Click += new System.EventHandler(this.btnGrabarC_Click);
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombreC.Location = new System.Drawing.Point(15, 61);
            this.lblNombreC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(66, 18);
            this.lblNombreC.TabIndex = 2;
            this.lblNombreC.Text = "Nombre:";
            // 
            // lstbColores
            // 
            this.lstbColores.FormattingEnabled = true;
            this.lstbColores.Location = new System.Drawing.Point(18, 196);
            this.lstbColores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstbColores.Name = "lstbColores";
            this.lstbColores.Size = new System.Drawing.Size(277, 173);
            this.lstbColores.TabIndex = 3;
            // 
            // txtNombreC
            // 
            this.txtNombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombreC.Location = new System.Drawing.Point(101, 56);
            this.txtNombreC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(194, 26);
            this.txtNombreC.TabIndex = 4;
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 384);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.lstbColores);
            this.Controls.Add(this.lblNombreC);
            this.Controls.Add(this.btnGrabarC);
            this.Controls.Add(this.btnListarC);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmColores";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarC;
        private System.Windows.Forms.Button btnGrabarC;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.ListBox lstbColores;
        private System.Windows.Forms.TextBox txtNombreC;
    }
}