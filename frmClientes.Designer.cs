namespace PryEdGaidoL
{
    partial class frmClientes
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
            this.txtNombreCl = new System.Windows.Forms.TextBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombreCl = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.btnGrabarCl = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dgvcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCl
            // 
            this.txtNombreCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNombreCl.Location = new System.Drawing.Point(76, 80);
            this.txtNombreCl.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCl.Name = "txtNombreCl";
            this.txtNombreCl.Size = new System.Drawing.Size(362, 23);
            this.txtNombreCl.TabIndex = 0;
            // 
            // txtDeuda
            // 
            this.txtDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDeuda.Location = new System.Drawing.Point(328, 111);
            this.txtDeuda.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(110, 23);
            this.txtDeuda.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCodigo.Location = new System.Drawing.Point(328, 54);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(110, 23);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCodigo.Location = new System.Drawing.Point(6, 59);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código";
            // 
            // lblNombreCl
            // 
            this.lblNombreCl.AutoSize = true;
            this.lblNombreCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombreCl.Location = new System.Drawing.Point(6, 85);
            this.lblNombreCl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCl.Name = "lblNombreCl";
            this.lblNombreCl.Size = new System.Drawing.Size(58, 17);
            this.lblNombreCl.TabIndex = 4;
            this.lblNombreCl.Text = "Nombre";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDeuda.Location = new System.Drawing.Point(6, 111);
            this.lblDeuda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(50, 17);
            this.lblDeuda.TabIndex = 5;
            this.lblDeuda.Text = "Deuda";
            // 
            // btnGrabarCl
            // 
            this.btnGrabarCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGrabarCl.Location = new System.Drawing.Point(328, 159);
            this.btnGrabarCl.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrabarCl.Name = "btnGrabarCl";
            this.btnGrabarCl.Size = new System.Drawing.Size(110, 28);
            this.btnGrabarCl.TabIndex = 6;
            this.btnGrabarCl.Text = "Grabar";
            this.btnGrabarCl.UseVisualStyleBackColor = true;
            this.btnGrabarCl.Click += new System.EventHandler(this.btnGrabarCl_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcodigo,
            this.dgvNombre,
            this.dgvDeuda});
            this.dgvClientes.Location = new System.Drawing.Point(9, 202);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(429, 172);
            this.dgvClientes.TabIndex = 7;
            // 
            // dgvcodigo
            // 
            this.dgvcodigo.HeaderText = "Código";
            this.dgvcodigo.MinimumWidth = 6;
            this.dgvcodigo.Name = "dgvcodigo";
            this.dgvcodigo.Width = 80;
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.MinimumWidth = 6;
            this.dgvNombre.Name = "dgvNombre";
            // 
            // dgvDeuda
            // 
            this.dgvDeuda.HeaderText = "Deuda";
            this.dgvDeuda.MinimumWidth = 6;
            this.dgvDeuda.Name = "dgvDeuda";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 384);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnGrabarCl);
            this.Controls.Add(this.lblDeuda);
            this.Controls.Add(this.lblNombreCl);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtDeuda);
            this.Controls.Add(this.txtNombreCl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCl;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombreCl;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Button btnGrabarCl;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDeuda;
    }
}