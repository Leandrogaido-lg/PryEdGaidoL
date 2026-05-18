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
            this.gbListar = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.cbDestino2 = new System.Windows.Forms.ComboBox();
            this.cbOrigen2 = new System.Windows.Forms.ComboBox();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblDestino2 = new System.Windows.Forms.Label();
            this.lblOrigen2 = new System.Windows.Forms.Label();
            this.gbCargaDatos = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbConsulta.SuspendLayout();
            this.gbCargaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListar
            // 
            this.gbListar.Controls.Add(this.dataGridView1);
            this.gbListar.Controls.Add(this.btnVerTodo);
            this.gbListar.Controls.Add(this.btnListarOrigenes);
            this.gbListar.Controls.Add(this.btnListarDestinos);
            this.gbListar.Controls.Add(this.cmbHasta);
            this.gbListar.Controls.Add(this.cmbDesde);
            this.gbListar.Controls.Add(this.lblHasta);
            this.gbListar.Controls.Add(this.lblDesde);
            this.gbListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListar.Location = new System.Drawing.Point(11, 219);
            this.gbListar.Margin = new System.Windows.Forms.Padding(2);
            this.gbListar.Name = "gbListar";
            this.gbListar.Padding = new System.Windows.Forms.Padding(2);
            this.gbListar.Size = new System.Drawing.Size(769, 288);
            this.gbListar.TabIndex = 11;
            this.gbListar.TabStop = false;
            this.gbListar.Text = "Listar viajes ....";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clOrigen,
            this.clCordoba,
            this.clMendoza,
            this.clSantaFe,
            this.clBuenosAires,
            this.clSalta});
            this.dataGridView1.Location = new System.Drawing.Point(8, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 208);
            this.dataGridView1.TabIndex = 9;
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
            this.btnVerTodo.Location = new System.Drawing.Point(603, 26);
            this.btnVerTodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(144, 21);
            this.btnVerTodo.TabIndex = 8;
            this.btnVerTodo.Text = "Ver todos los viajes";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarOrigenes.Location = new System.Drawing.Point(478, 24);
            this.btnListarOrigenes.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(107, 23);
            this.btnListarOrigenes.TabIndex = 7;
            this.btnListarOrigenes.Text = "Listar Origenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarDestinos.Location = new System.Drawing.Point(183, 24);
            this.btnListarDestinos.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(98, 23);
            this.btnListarDestinos.TabIndex = 6;
            this.btnListarDestinos.Text = "Listar Destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            // 
            // cmbHasta
            // 
            this.cmbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(348, 24);
            this.cmbHasta.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(119, 23);
            this.cmbHasta.TabIndex = 4;
            // 
            // cmbDesde
            // 
            this.cmbDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(51, 24);
            this.cmbDesde.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(119, 23);
            this.cmbDesde.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(297, 27);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(42, 15);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(4, 28);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(46, 15);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.btnBorrar);
            this.gbConsulta.Controls.Add(this.btnConsultar);
            this.gbConsulta.Controls.Add(this.txtPrecio2);
            this.gbConsulta.Controls.Add(this.cbDestino2);
            this.gbConsulta.Controls.Add(this.cbOrigen2);
            this.gbConsulta.Controls.Add(this.lblPrecio2);
            this.gbConsulta.Controls.Add(this.lblDestino2);
            this.gbConsulta.Controls.Add(this.lblOrigen2);
            this.gbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsulta.Location = new System.Drawing.Point(563, 11);
            this.gbConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Padding = new System.Windows.Forms.Padding(2);
            this.gbConsulta.Size = new System.Drawing.Size(200, 189);
            this.gbConsulta.TabIndex = 12;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta de Datos:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(106, 153);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(89, 32);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(7, 153);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(88, 32);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtPrecio2
            // 
            this.txtPrecio2.Location = new System.Drawing.Point(63, 109);
            this.txtPrecio2.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio2.Name = "txtPrecio2";
            this.txtPrecio2.Size = new System.Drawing.Size(119, 21);
            this.txtPrecio2.TabIndex = 5;
            // 
            // cbDestino2
            // 
            this.cbDestino2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestino2.FormattingEnabled = true;
            this.cbDestino2.Location = new System.Drawing.Point(63, 70);
            this.cbDestino2.Margin = new System.Windows.Forms.Padding(2);
            this.cbDestino2.Name = "cbDestino2";
            this.cbDestino2.Size = new System.Drawing.Size(119, 23);
            this.cbDestino2.TabIndex = 4;
            // 
            // cbOrigen2
            // 
            this.cbOrigen2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigen2.FormattingEnabled = true;
            this.cbOrigen2.Location = new System.Drawing.Point(63, 32);
            this.cbOrigen2.Margin = new System.Windows.Forms.Padding(2);
            this.cbOrigen2.Name = "cbOrigen2";
            this.cbOrigen2.Size = new System.Drawing.Size(119, 23);
            this.cbOrigen2.TabIndex = 3;
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Location = new System.Drawing.Point(4, 113);
            this.lblPrecio2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(45, 15);
            this.lblPrecio2.TabIndex = 2;
            this.lblPrecio2.Text = "Precio:";
            // 
            // lblDestino2
            // 
            this.lblDestino2.AutoSize = true;
            this.lblDestino2.Location = new System.Drawing.Point(4, 76);
            this.lblDestino2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestino2.Name = "lblDestino2";
            this.lblDestino2.Size = new System.Drawing.Size(52, 15);
            this.lblDestino2.TabIndex = 1;
            this.lblDestino2.Text = "Destino:";
            // 
            // lblOrigen2
            // 
            this.lblOrigen2.AutoSize = true;
            this.lblOrigen2.Location = new System.Drawing.Point(4, 38);
            this.lblOrigen2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrigen2.Name = "lblOrigen2";
            this.lblOrigen2.Size = new System.Drawing.Size(47, 15);
            this.lblOrigen2.TabIndex = 0;
            this.lblOrigen2.Text = "Origen:";
            // 
            // gbCargaDatos
            // 
            this.gbCargaDatos.Controls.Add(this.btnCargar);
            this.gbCargaDatos.Controls.Add(this.btnBorrarTodo);
            this.gbCargaDatos.Controls.Add(this.txtPrecio);
            this.gbCargaDatos.Controls.Add(this.cbDestino);
            this.gbCargaDatos.Controls.Add(this.cbOrigen);
            this.gbCargaDatos.Controls.Add(this.lblPrecio);
            this.gbCargaDatos.Controls.Add(this.lblDestino);
            this.gbCargaDatos.Controls.Add(this.lblOrigen);
            this.gbCargaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCargaDatos.Location = new System.Drawing.Point(311, 6);
            this.gbCargaDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gbCargaDatos.Name = "gbCargaDatos";
            this.gbCargaDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gbCargaDatos.Size = new System.Drawing.Size(200, 189);
            this.gbCargaDatos.TabIndex = 10;
            this.gbCargaDatos.TabStop = false;
            this.gbCargaDatos.Text = "Carga de Datos:";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(106, 153);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(89, 32);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTodo.Location = new System.Drawing.Point(7, 153);
            this.btnBorrarTodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(88, 32);
            this.btnBorrarTodo.TabIndex = 6;
            this.btnBorrarTodo.Text = "Borrar ";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(63, 109);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(119, 21);
            this.txtPrecio.TabIndex = 5;
            // 
            // cbDestino
            // 
            this.cbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(63, 70);
            this.cbDestino.Margin = new System.Windows.Forms.Padding(2);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(119, 23);
            this.cbDestino.TabIndex = 4;
            // 
            // cbOrigen
            // 
            this.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(63, 32);
            this.cbOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(119, 23);
            this.cbOrigen.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(4, 113);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(45, 15);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(4, 76);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(52, 15);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(4, 35);
            this.lblOrigen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(47, 15);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryEdGaidoL.Properties.Resources.grafo;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 515);
            this.Controls.Add(this.gbListar);
            this.Controls.Add(this.gbConsulta);
            this.Controls.Add(this.gbCargaDatos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmGrafo";
            this.Text = "Grafo";
            this.gbListar.ResumeLayout(false);
            this.gbListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            this.gbCargaDatos.ResumeLayout(false);
            this.gbCargaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListar;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.ComboBox cbDestino2;
        private System.Windows.Forms.ComboBox cbOrigen2;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.Label lblDestino2;
        private System.Windows.Forms.Label lblOrigen2;
        private System.Windows.Forms.GroupBox gbCargaDatos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}