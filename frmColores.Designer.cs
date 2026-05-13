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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrabarC = new System.Windows.Forms.Button();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.lstbColores = new System.Windows.Forms.ListBox();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(24, 176);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(163, 42);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrabarC
            // 
            this.btnGrabarC.Location = new System.Drawing.Point(229, 176);
            this.btnGrabarC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrabarC.Name = "btnGrabarC";
            this.btnGrabarC.Size = new System.Drawing.Size(163, 42);
            this.btnGrabarC.TabIndex = 1;
            this.btnGrabarC.Text = "Grabar";
            this.btnGrabarC.UseVisualStyleBackColor = true;
            this.btnGrabarC.Click += new System.EventHandler(this.btnGrabarC_Click);
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombreC.Location = new System.Drawing.Point(20, 75);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(84, 24);
            this.lblNombreC.TabIndex = 2;
            this.lblNombreC.Text = "Nombre:";
            // 
            // lstbColores
            // 
            this.lstbColores.FormattingEnabled = true;
            this.lstbColores.ItemHeight = 16;
            this.lstbColores.Location = new System.Drawing.Point(24, 241);
            this.lstbColores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbColores.Name = "lstbColores";
            this.lstbColores.Size = new System.Drawing.Size(368, 212);
            this.lstbColores.TabIndex = 3;
            // 
            // txtNombreC
            // 
            this.txtNombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombreC.Location = new System.Drawing.Point(135, 69);
            this.txtNombreC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(257, 30);
            this.txtNombreC.TabIndex = 4;
            this.txtNombreC.TextChanged += new System.EventHandler(this.txtNombreC_TextChanged);
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 473);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.lstbColores);
            this.Controls.Add(this.lblNombreC);
            this.Controls.Add(this.btnGrabarC);
            this.Controls.Add(this.btnLimpiar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmColores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrabarC;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.ListBox lstbColores;
        private System.Windows.Forms.TextBox txtNombreC;
    }
}