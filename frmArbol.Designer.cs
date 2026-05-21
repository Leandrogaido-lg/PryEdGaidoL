namespace PryEdGaidoL
{
    partial class frmArbol
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
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbPostOrden = new System.Windows.Forms.RadioButton();
            this.rbPreOrden = new System.Windows.Forms.RadioButton();
            this.rbInOrden = new System.Windows.Forms.RadioButton();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.gbEliminar = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.gbEliminar.SuspendLayout();
            this.gbNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.dgvListado);
            this.gbListado.Controls.Add(this.rbPostOrden);
            this.gbListado.Controls.Add(this.rbPreOrden);
            this.gbListado.Controls.Add(this.rbInOrden);
            this.gbListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListado.Location = new System.Drawing.Point(15, 289);
            this.gbListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbListado.Name = "gbListado";
            this.gbListado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbListado.Size = new System.Drawing.Size(871, 251);
            this.gbListado.TabIndex = 11;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado del Árbol";
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clNombre,
            this.clTramite});
            this.dgvListado.Location = new System.Drawing.Point(283, 23);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowHeadersWidth = 51;
            this.dgvListado.RowTemplate.Height = 24;
            this.dgvListado.Size = new System.Drawing.Size(577, 223);
            this.dgvListado.TabIndex = 3;
            // 
            // clCodigo
            // 
            this.clCodigo.HeaderText = "Código";
            this.clCodigo.MinimumWidth = 6;
            this.clCodigo.Name = "clCodigo";
            this.clCodigo.Width = 125;
            // 
            // clNombre
            // 
            this.clNombre.HeaderText = "Nombre";
            this.clNombre.MinimumWidth = 6;
            this.clNombre.Name = "clNombre";
            this.clNombre.Width = 150;
            // 
            // clTramite
            // 
            this.clTramite.HeaderText = "Trámite";
            this.clTramite.MinimumWidth = 6;
            this.clTramite.Name = "clTramite";
            this.clTramite.Width = 120;
            // 
            // rbPostOrden
            // 
            this.rbPostOrden.AutoSize = true;
            this.rbPostOrden.Location = new System.Drawing.Point(35, 148);
            this.rbPostOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPostOrden.Name = "rbPostOrden";
            this.rbPostOrden.Size = new System.Drawing.Size(106, 22);
            this.rbPostOrden.TabIndex = 2;
            this.rbPostOrden.TabStop = true;
            this.rbPostOrden.Text = "Post-Orden";
            this.rbPostOrden.UseVisualStyleBackColor = true;
            // 
            // rbPreOrden
            // 
            this.rbPreOrden.AutoSize = true;
            this.rbPreOrden.Location = new System.Drawing.Point(35, 103);
            this.rbPreOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPreOrden.Name = "rbPreOrden";
            this.rbPreOrden.Size = new System.Drawing.Size(98, 22);
            this.rbPreOrden.TabIndex = 1;
            this.rbPreOrden.TabStop = true;
            this.rbPreOrden.Text = "Pre-Orden";
            this.rbPreOrden.UseVisualStyleBackColor = true;
            // 
            // rbInOrden
            // 
            this.rbInOrden.AutoSize = true;
            this.rbInOrden.Location = new System.Drawing.Point(35, 55);
            this.rbInOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbInOrden.Name = "rbInOrden";
            this.rbInOrden.Size = new System.Drawing.Size(86, 22);
            this.rbInOrden.TabIndex = 0;
            this.rbInOrden.TabStop = true;
            this.rbInOrden.Text = "In-Orden";
            this.rbInOrden.UseVisualStyleBackColor = true;
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquilibrar.Location = new System.Drawing.Point(653, 210);
            this.btnEquilibrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(211, 39);
            this.btnEquilibrar.TabIndex = 13;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // gbEliminar
            // 
            this.gbEliminar.Controls.Add(this.cmbCodigo);
            this.gbEliminar.Controls.Add(this.btnEliminar);
            this.gbEliminar.Controls.Add(this.lblCodigo2);
            this.gbEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEliminar.Location = new System.Drawing.Point(643, 33);
            this.gbEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEliminar.Name = "gbEliminar";
            this.gbEliminar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEliminar.Size = new System.Drawing.Size(237, 151);
            this.gbEliminar.TabIndex = 12;
            this.gbEliminar.TabStop = false;
            this.gbEliminar.Text = "Elemento a Eliminar";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(84, 39);
            this.cmbCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(147, 26);
            this.cmbCodigo.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(21, 89);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(211, 39);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(19, 43);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(60, 18);
            this.lblCodigo2.TabIndex = 0;
            this.lblCodigo2.Text = "Código:";
            // 
            // gbNuevoElemento
            // 
            this.gbNuevoElemento.Controls.Add(this.btnAgregar);
            this.gbNuevoElemento.Controls.Add(this.txtTramite);
            this.gbNuevoElemento.Controls.Add(this.txtNombre);
            this.gbNuevoElemento.Controls.Add(this.txtCodigo);
            this.gbNuevoElemento.Controls.Add(this.lblTramite);
            this.gbNuevoElemento.Controls.Add(this.lblNombre);
            this.gbNuevoElemento.Controls.Add(this.lblCod);
            this.gbNuevoElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNuevoElemento.Location = new System.Drawing.Point(361, 32);
            this.gbNuevoElemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbNuevoElemento.Size = new System.Drawing.Size(237, 235);
            this.gbNuevoElemento.TabIndex = 10;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(21, 178);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(211, 39);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(99, 126);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(133, 24);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 81);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 24);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(99, 38);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(133, 24);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(19, 132);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(62, 18);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 87);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(19, 43);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(60, 18);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryEdGaidoL.Properties.Resources.arbol;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.gbEliminar);
            this.Controls.Add(this.gbNuevoElemento);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmArbol";
            this.Text = "Estructura Ramificada- Arbol Binario";
            this.gbListado.ResumeLayout(false);
            this.gbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.gbEliminar.ResumeLayout(false);
            this.gbEliminar.PerformLayout();
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTramite;
        private System.Windows.Forms.RadioButton rbPostOrden;
        private System.Windows.Forms.RadioButton rbPreOrden;
        private System.Windows.Forms.RadioButton rbInOrden;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.GroupBox gbEliminar;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}