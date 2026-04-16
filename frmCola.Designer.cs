namespace PryEdGaidoL
{
    partial class frmCola
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
            this.picBCola = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSombraN = new System.Windows.Forms.Label();
            this.lblSombraC = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblTramite1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSombraT = new System.Windows.Forms.Label();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstbCola = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBCola)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.SuspendLayout();
            // 
            // picBCola
            // 
            this.picBCola.Image = global::PryEdGaidoL.Properties.Resources.cola;
            this.picBCola.Location = new System.Drawing.Point(12, 12);
            this.picBCola.Name = "picBCola";
            this.picBCola.Size = new System.Drawing.Size(184, 168);
            this.picBCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBCola.TabIndex = 0;
            this.picBCola.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSombraT);
            this.groupBox1.Controls.Add(this.lblSombraN);
            this.groupBox1.Controls.Add(this.lblSombraC);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.lblTramite2);
            this.groupBox1.Controls.Add(this.lblNombre2);
            this.groupBox1.Controls.Add(this.lblCodigo2);
            this.groupBox1.Location = new System.Drawing.Point(384, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elemento Eliminado";
            // 
            // lblSombraN
            // 
            this.lblSombraN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSombraN.Location = new System.Drawing.Point(70, 61);
            this.lblSombraN.Name = "lblSombraN";
            this.lblSombraN.Size = new System.Drawing.Size(98, 20);
            this.lblSombraN.TabIndex = 10;
            this.lblSombraN.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSombraC
            // 
            this.lblSombraC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSombraC.Location = new System.Drawing.Point(86, 29);
            this.lblSombraC.Name = "lblSombraC";
            this.lblSombraC.Size = new System.Drawing.Size(82, 20);
            this.lblSombraC.TabIndex = 9;
            this.lblSombraC.Text = " ";
            this.lblSombraC.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(9, 126);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(159, 36);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblTramite2
            // 
            this.lblTramite2.AutoSize = true;
            this.lblTramite2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTramite2.Location = new System.Drawing.Point(6, 93);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.Size = new System.Drawing.Size(56, 17);
            this.lblTramite2.TabIndex = 2;
            this.lblTramite2.Text = "Tràmite";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre2.Location = new System.Drawing.Point(6, 61);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(58, 17);
            this.lblNombre2.TabIndex = 1;
            this.lblNombre2.Text = "Nombre";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCodigo2.Location = new System.Drawing.Point(6, 29);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo2.TabIndex = 0;
            this.lblCodigo2.Text = "Còdigo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTramite);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.lblCodigo1);
            this.groupBox2.Controls.Add(this.lblNombre1);
            this.groupBox2.Controls.Add(this.lblTramite1);
            this.groupBox2.Location = new System.Drawing.Point(202, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 168);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(68, 93);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(68, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(90, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(78, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(9, 126);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(161, 36);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCodigo1.Location = new System.Drawing.Point(6, 29);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo1.TabIndex = 4;
            this.lblCodigo1.Text = "Còdigo";
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre1.Location = new System.Drawing.Point(6, 62);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(58, 17);
            this.lblNombre1.TabIndex = 5;
            this.lblNombre1.Text = "Nombre";
            // 
            // lblTramite1
            // 
            this.lblTramite1.AutoSize = true;
            this.lblTramite1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTramite1.Location = new System.Drawing.Point(6, 93);
            this.lblTramite1.Name = "lblTramite1";
            this.lblTramite1.Size = new System.Drawing.Size(56, 17);
            this.lblTramite1.TabIndex = 6;
            this.lblTramite1.Text = "Tràmite";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstbCola);
            this.groupBox3.Controls.Add(this.dgvCola);
            this.groupBox3.Location = new System.Drawing.Point(12, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(546, 196);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado en una lista y una grilla";
            // 
            // lblSombraT
            // 
            this.lblSombraT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSombraT.Location = new System.Drawing.Point(70, 90);
            this.lblSombraT.Name = "lblSombraT";
            this.lblSombraT.Size = new System.Drawing.Size(98, 23);
            this.lblSombraT.TabIndex = 11;
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCola.Location = new System.Drawing.Point(170, 19);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(370, 171);
            this.dgvCola.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Còdigo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tràmite";
            this.Column3.Name = "Column3";
            // 
            // lstbCola
            // 
            this.lstbCola.FormattingEnabled = true;
            this.lstbCola.Location = new System.Drawing.Point(6, 19);
            this.lstbCola.Name = "lstbCola";
            this.lstbCola.Size = new System.Drawing.Size(158, 173);
            this.lstbCola.TabIndex = 1;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 405);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picBCola);
            this.Name = "frmCola";
            this.Text = "Estructura Dinàmica Lineal - Cola";
            ((System.ComponentModel.ISupportInitialize)(this.picBCola)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBCola;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblTramite1;
        private System.Windows.Forms.Label lblSombraN;
        private System.Windows.Forms.Label lblSombraC;
        private System.Windows.Forms.Label lblSombraT;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.ListBox lstbCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}