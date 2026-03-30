namespace PryEdGaidoL
{
    partial class frmAlumnos
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.txtCodigoA = new System.Windows.Forms.TextBox();
            this.lblCodigoA = new System.Windows.Forms.Label();
            this.lblNombreA = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvCodigoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(386, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Grabar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(111, 136);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(414, 28);
            this.cmbCarrera.TabIndex = 1;
            // 
            // txtNombreA
            // 
            this.txtNombreA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNombreA.Location = new System.Drawing.Point(111, 95);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(414, 26);
            this.txtNombreA.TabIndex = 2;
            // 
            // txtCodigoA
            // 
            this.txtCodigoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCodigoA.Location = new System.Drawing.Point(386, 61);
            this.txtCodigoA.Name = "txtCodigoA";
            this.txtCodigoA.Size = new System.Drawing.Size(139, 26);
            this.txtCodigoA.TabIndex = 3;
            // 
            // lblCodigoA
            // 
            this.lblCodigoA.AutoSize = true;
            this.lblCodigoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCodigoA.Location = new System.Drawing.Point(8, 67);
            this.lblCodigoA.Name = "lblCodigoA";
            this.lblCodigoA.Size = new System.Drawing.Size(66, 20);
            this.lblCodigoA.TabIndex = 4;
            this.lblCodigoA.Text = "Código:";
            // 
            // lblNombreA
            // 
            this.lblNombreA.AutoSize = true;
            this.lblNombreA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombreA.Location = new System.Drawing.Point(8, 101);
            this.lblNombreA.Name = "lblNombreA";
            this.lblNombreA.Size = new System.Drawing.Size(73, 20);
            this.lblNombreA.TabIndex = 5;
            this.lblNombreA.Text = "Nombre:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCarrera.Location = new System.Drawing.Point(8, 139);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(71, 20);
            this.lblCarrera.TabIndex = 6;
            this.lblCarrera.Text = "Carrera:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCodigoA,
            this.dgvNombreA,
            this.dgvCarrera});
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(513, 220);
            this.dataGridView1.TabIndex = 7;
            // 
            // dgvCodigoA
            // 
            this.dgvCodigoA.HeaderText = "Código";
            this.dgvCodigoA.MinimumWidth = 6;
            this.dgvCodigoA.Name = "dgvCodigoA";
            this.dgvCodigoA.Width = 75;
            // 
            // dgvNombreA
            // 
            this.dgvNombreA.HeaderText = "Nombre";
            this.dgvNombreA.MinimumWidth = 6;
            this.dgvNombreA.Name = "dgvNombreA";
            this.dgvNombreA.Width = 200;
            // 
            // dgvCarrera
            // 
            this.dgvCarrera.HeaderText = "Carrera";
            this.dgvCarrera.MinimumWidth = 6;
            this.dgvCarrera.Name = "dgvCarrera";
            this.dgvCarrera.Width = 150;
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblNombreA);
            this.Controls.Add(this.lblCodigoA);
            this.Controls.Add(this.txtCodigoA);
            this.Controls.Add(this.txtNombreA);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.button1);
            this.Name = "frmAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.TextBox txtCodigoA;
        private System.Windows.Forms.Label lblCodigoA;
        private System.Windows.Forms.Label lblNombreA;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCarrera;
    }
}