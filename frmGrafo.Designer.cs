namespace PryEdGaidoL
{
    partial class frmGrafo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrafo));
            this.gbListar = new System.Windows.Forms.GroupBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.clOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCordoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMendoza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSantaFe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBuenosAires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSalta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.btnListarDestinos = new System.Windows.Forms.Button();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtPrecio2 = new System.Windows.Forms.TextBox();
            this.cmbDestino2 = new System.Windows.Forms.ComboBox();
            this.cmbOrigen2 = new System.Windows.Forms.ComboBox();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblDestino2 = new System.Windows.Forms.Label();
            this.lblOrigen2 = new System.Windows.Forms.Label();
            this.gbCargaDatos = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.gbConsulta.SuspendLayout();
            this.gbCargaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListar
            // 
            this.gbListar.Controls.Add(this.dgvGrilla);
            this.gbListar.Controls.Add(this.btnVerTodo);
            this.gbListar.Controls.Add(this.btnListarOrigenes);
            this.gbListar.Controls.Add(this.btnListarDestinos);
            this.gbListar.Controls.Add(this.cmbHasta);
            this.gbListar.Controls.Add(this.cmbDesde);
            this.gbListar.Controls.Add(this.lblHasta);
            this.gbListar.Controls.Add(this.lblDesde);
            this.gbListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListar.Location = new System.Drawing.Point(15, 270);
            this.gbListar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbListar.Name = "gbListar";
            this.gbListar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbListar.Size = new System.Drawing.Size(1025, 354);
            this.gbListar.TabIndex = 11;
            this.gbListar.TabStop = false;
            this.gbListar.Text = "Listar viajes ....";
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clOrigen,
            this.clCordoba,
            this.clMendoza,
            this.clSantaFe,
            this.clBuenosAires,
            this.clSalta});
            this.dgvGrilla.Location = new System.Drawing.Point(11, 92);
            this.dgvGrilla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.RowHeadersWidth = 51;
            this.dgvGrilla.RowTemplate.Height = 24;
            this.dgvGrilla.Size = new System.Drawing.Size(1009, 256);
            this.dgvGrilla.TabIndex = 9;
            // 
            // clOrigen
            // 
            this.clOrigen.HeaderText = "Origen";
            this.clOrigen.MinimumWidth = 6;
            this.clOrigen.Name = "clOrigen";
            this.clOrigen.Width = 110;
            // 
            // clCordoba
            // 
            this.clCordoba.HeaderText = "Córdoba";
            this.clCordoba.MinimumWidth = 6;
            this.clCordoba.Name = "clCordoba";
            this.clCordoba.Width = 125;
            // 
            // clMendoza
            // 
            this.clMendoza.HeaderText = "Mendoza";
            this.clMendoza.MinimumWidth = 6;
            this.clMendoza.Name = "clMendoza";
            this.clMendoza.Width = 125;
            // 
            // clSantaFe
            // 
            this.clSantaFe.HeaderText = "Santa Fe";
            this.clSantaFe.MinimumWidth = 6;
            this.clSantaFe.Name = "clSantaFe";
            this.clSantaFe.Width = 125;
            // 
            // clBuenosAires
            // 
            this.clBuenosAires.HeaderText = "Buenos Aires";
            this.clBuenosAires.MinimumWidth = 6;
            this.clBuenosAires.Name = "clBuenosAires";
            this.clBuenosAires.Width = 125;
            // 
            // clSalta
            // 
            this.clSalta.HeaderText = "Salta";
            this.clSalta.MinimumWidth = 6;
            this.clSalta.Name = "clSalta";
            this.clSalta.Width = 125;
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodo.Location = new System.Drawing.Point(804, 32);
            this.btnVerTodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(192, 26);
            this.btnVerTodo.TabIndex = 8;
            this.btnVerTodo.Text = "Ver todos los viajes";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarOrigenes.Location = new System.Drawing.Point(637, 30);
            this.btnListarOrigenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(143, 28);
            this.btnListarOrigenes.TabIndex = 7;
            this.btnListarOrigenes.Text = "Listar Origenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            this.btnListarOrigenes.Click += new System.EventHandler(this.btnListarOrigenes_Click);
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarDestinos.Location = new System.Drawing.Point(244, 30);
            this.btnListarDestinos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(131, 28);
            this.btnListarDestinos.TabIndex = 6;
            this.btnListarDestinos.Text = "Listar Destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            this.btnListarDestinos.Click += new System.EventHandler(this.btnListarDestinos_Click);
            // 
            // cmbHasta
            // 
            this.cmbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(464, 30);
            this.cmbHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(157, 26);
            this.cmbHasta.TabIndex = 4;
            // 
            // cmbDesde
            // 
            this.cmbDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(68, 30);
            this.cmbDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(157, 26);
            this.cmbDesde.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(396, 33);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(51, 18);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(5, 34);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(55, 18);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.btnBorrar);
            this.gbConsulta.Controls.Add(this.btnConsultar);
            this.gbConsulta.Controls.Add(this.txtPrecio2);
            this.gbConsulta.Controls.Add(this.cmbDestino2);
            this.gbConsulta.Controls.Add(this.cmbOrigen2);
            this.gbConsulta.Controls.Add(this.lblPrecio2);
            this.gbConsulta.Controls.Add(this.lblDestino2);
            this.gbConsulta.Controls.Add(this.lblOrigen2);
            this.gbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsulta.Location = new System.Drawing.Point(751, 14);
            this.gbConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbConsulta.Size = new System.Drawing.Size(267, 233);
            this.gbConsulta.TabIndex = 12;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta de Datos:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(141, 188);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(119, 39);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(9, 188);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(117, 39);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtPrecio2
            // 
            this.txtPrecio2.Location = new System.Drawing.Point(84, 134);
            this.txtPrecio2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio2.Name = "txtPrecio2";
            this.txtPrecio2.Size = new System.Drawing.Size(157, 24);
            this.txtPrecio2.TabIndex = 5;
            // 
            // cmbDestino2
            // 
            this.cmbDestino2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino2.FormattingEnabled = true;
            this.cmbDestino2.Location = new System.Drawing.Point(84, 86);
            this.cmbDestino2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDestino2.Name = "cmbDestino2";
            this.cmbDestino2.Size = new System.Drawing.Size(157, 26);
            this.cmbDestino2.TabIndex = 4;
            // 
            // cmbOrigen2
            // 
            this.cmbOrigen2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen2.FormattingEnabled = true;
            this.cmbOrigen2.Location = new System.Drawing.Point(84, 39);
            this.cmbOrigen2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOrigen2.Name = "cmbOrigen2";
            this.cmbOrigen2.Size = new System.Drawing.Size(157, 26);
            this.cmbOrigen2.TabIndex = 3;
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Location = new System.Drawing.Point(5, 139);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(55, 18);
            this.lblPrecio2.TabIndex = 2;
            this.lblPrecio2.Text = "Precio:";
            // 
            // lblDestino2
            // 
            this.lblDestino2.AutoSize = true;
            this.lblDestino2.Location = new System.Drawing.Point(5, 94);
            this.lblDestino2.Name = "lblDestino2";
            this.lblDestino2.Size = new System.Drawing.Size(63, 18);
            this.lblDestino2.TabIndex = 1;
            this.lblDestino2.Text = "Destino:";
            // 
            // lblOrigen2
            // 
            this.lblOrigen2.AutoSize = true;
            this.lblOrigen2.Location = new System.Drawing.Point(5, 47);
            this.lblOrigen2.Name = "lblOrigen2";
            this.lblOrigen2.Size = new System.Drawing.Size(56, 18);
            this.lblOrigen2.TabIndex = 0;
            this.lblOrigen2.Text = "Origen:";
            // 
            // gbCargaDatos
            // 
            this.gbCargaDatos.Controls.Add(this.btnCargar);
            this.gbCargaDatos.Controls.Add(this.btnBorrarTodo);
            this.gbCargaDatos.Controls.Add(this.txtPrecio);
            this.gbCargaDatos.Controls.Add(this.cmbDestino);
            this.gbCargaDatos.Controls.Add(this.cmbOrigen);
            this.gbCargaDatos.Controls.Add(this.lblPrecio);
            this.gbCargaDatos.Controls.Add(this.lblDestino);
            this.gbCargaDatos.Controls.Add(this.lblOrigen);
            this.gbCargaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCargaDatos.Location = new System.Drawing.Point(415, 7);
            this.gbCargaDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCargaDatos.Name = "gbCargaDatos";
            this.gbCargaDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCargaDatos.Size = new System.Drawing.Size(267, 233);
            this.gbCargaDatos.TabIndex = 10;
            this.gbCargaDatos.TabStop = false;
            this.gbCargaDatos.Text = "Carga de Datos:";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(141, 188);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(119, 39);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTodo.Location = new System.Drawing.Point(9, 188);
            this.btnBorrarTodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(117, 39);
            this.btnBorrarTodo.TabIndex = 6;
            this.btnBorrarTodo.Text = "Borrar ";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(84, 134);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(157, 24);
            this.txtPrecio.TabIndex = 5;
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(84, 86);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(157, 26);
            this.cmbDestino.TabIndex = 4;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(84, 39);
            this.cmbOrigen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(157, 26);
            this.cmbOrigen.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(5, 139);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 18);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(5, 94);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(63, 18);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(5, 43);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(56, 18);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryEdGaidoL.Properties.Resources.grafo;
            this.pictureBox1.Location = new System.Drawing.Point(15, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 634);
            this.Controls.Add(this.gbListar);
            this.Controls.Add(this.gbConsulta);
            this.Controls.Add(this.gbCargaDatos);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGrafo";
            this.Text = "Grafo";
            this.Load += new System.EventHandler(this.frmGrafo_Load);
            this.gbListar.ResumeLayout(false);
            this.gbListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            this.gbCargaDatos.ResumeLayout(false);
            this.gbCargaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListar;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCordoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMendoza;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSantaFe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBuenosAires;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSalta;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.Button btnListarOrigenes;
        private System.Windows.Forms.Button btnListarDestinos;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtPrecio2;
        private System.Windows.Forms.ComboBox cmbDestino2;
        private System.Windows.Forms.ComboBox cmbOrigen2;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.Label lblDestino2;
        private System.Windows.Forms.Label lblOrigen2;
        private System.Windows.Forms.GroupBox gbCargaDatos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}