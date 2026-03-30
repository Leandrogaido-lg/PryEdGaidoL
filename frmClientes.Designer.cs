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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCl
            // 
            this.txtNombreCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNombreCl.Location = new System.Drawing.Point(102, 99);
            this.txtNombreCl.Name = "txtNombreCl";
            this.txtNombreCl.Size = new System.Drawing.Size(482, 26);
            this.txtNombreCl.TabIndex = 0;
            // 
            // txtDeuda
            // 
            this.txtDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDeuda.Location = new System.Drawing.Point(438, 137);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(146, 26);
            this.txtDeuda.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCodigo.Location = new System.Drawing.Point(438, 67);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(146, 26);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCodigo.Location = new System.Drawing.Point(8, 73);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 20);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código";
            // 
            // lblNombreCl
            // 
            this.lblNombreCl.AutoSize = true;
            this.lblNombreCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombreCl.Location = new System.Drawing.Point(8, 105);
            this.lblNombreCl.Name = "lblNombreCl";
            this.lblNombreCl.Size = new System.Drawing.Size(68, 20);
            this.lblNombreCl.TabIndex = 4;
            this.lblNombreCl.Text = "Nombre";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDeuda.Location = new System.Drawing.Point(8, 137);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(58, 20);
            this.lblDeuda.TabIndex = 5;
            this.lblDeuda.Text = "Deuda";
            // 
            // btnGrabarCl
            // 
            this.btnGrabarCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGrabarCl.Location = new System.Drawing.Point(438, 196);
            this.btnGrabarCl.Name = "btnGrabarCl";
            this.btnGrabarCl.Size = new System.Drawing.Size(146, 35);
            this.btnGrabarCl.TabIndex = 6;
            this.btnGrabarCl.Text = "Grabar";
            this.btnGrabarCl.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcodigo,
            this.dgvNombre,
            this.dgvDeuda});
            this.dataGridView1.Location = new System.Drawing.Point(12, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(572, 212);
            this.dataGridView1.TabIndex = 7;
            // 
            // dgvcodigo
            // 
            this.dgvcodigo.HeaderText = "Código";
            this.dgvcodigo.MinimumWidth = 6;
            this.dgvcodigo.Name = "dgvcodigo";
            this.dgvcodigo.Width = 125;
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.MinimumWidth = 6;
            this.dgvNombre.Name = "dgvNombre";
            this.dgvNombre.Width = 225;
            // 
            // dgvDeuda
            // 
            this.dgvDeuda.HeaderText = "Deuda";
            this.dgvDeuda.MinimumWidth = 6;
            this.dgvDeuda.Name = "dgvDeuda";
            this.dgvDeuda.Width = 125;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGrabarCl);
            this.Controls.Add(this.lblDeuda);
            this.Controls.Add(this.lblNombreCl);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtDeuda);
            this.Controls.Add(this.txtNombreCl);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDeuda;
    }
}