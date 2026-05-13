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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.txtCodigoA = new System.Windows.Forms.TextBox();
            this.lblCodigoA = new System.Windows.Forms.Label();
            this.lblNombreA = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.dgvCodigoA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGrabar.Location = new System.Drawing.Point(387, 186);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(139, 34);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(111, 135);
            this.cmbCarrera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(415, 28);
            this.cmbCarrera.TabIndex = 1;
            // 
            // txtNombreA
            // 
            this.txtNombreA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNombreA.Location = new System.Drawing.Point(111, 95);
            this.txtNombreA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(415, 26);
            this.txtNombreA.TabIndex = 2;
            this.txtNombreA.TextChanged += new System.EventHandler(this.txtNombreA_TextChanged);
            // 
            // txtCodigoA
            // 
            this.txtCodigoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCodigoA.Location = new System.Drawing.Point(387, 62);
            this.txtCodigoA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoA.Name = "txtCodigoA";
            this.txtCodigoA.Size = new System.Drawing.Size(139, 26);
            this.txtCodigoA.TabIndex = 3;
            this.txtCodigoA.TextChanged += new System.EventHandler(this.txtCodigoA_TextChanged);
            // 
            // lblCodigoA
            // 
            this.lblCodigoA.AutoSize = true;
            this.lblCodigoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCodigoA.Location = new System.Drawing.Point(8, 66);
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
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCodigoA,
            this.dgvNombreA,
            this.dgvCarrera});
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 241);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.RowTemplate.Height = 24;
            this.dgvAlumnos.Size = new System.Drawing.Size(513, 220);
            this.dgvAlumnos.TabIndex = 7;
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
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblNombreA);
            this.Controls.Add(this.lblCodigoA);
            this.Controls.Add(this.txtCodigoA);
            this.Controls.Add(this.txtNombreA);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.btnGrabar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.TextBox txtCodigoA;
        private System.Windows.Forms.Label lblCodigoA;
        private System.Windows.Forms.Label lblNombreA;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCarrera;
    }
}