namespace PryEdGaidoL
{
    partial class frmBdOperaciones
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
            this.gbAlgebraicas = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.gbSeleccion = new System.Windows.Forms.GroupBox();
            this.btnSelecConv = new System.Windows.Forms.Button();
            this.btnSelecMulti = new System.Windows.Forms.Button();
            this.btnSelecSimple = new System.Windows.Forms.Button();
            this.gbProyeccion = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProyMulti = new System.Windows.Forms.Button();
            this.btnProySimple = new System.Windows.Forms.Button();
            this.dgvBaseDatos = new System.Windows.Forms.DataGridView();
            this.gbAlgebraicas.SuspendLayout();
            this.gbSeleccion.SuspendLayout();
            this.gbProyeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAlgebraicas
            // 
            this.gbAlgebraicas.Controls.Add(this.btnDiferencia);
            this.gbAlgebraicas.Controls.Add(this.btnInterseccion);
            this.gbAlgebraicas.Controls.Add(this.btnUnion);
            this.gbAlgebraicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlgebraicas.Location = new System.Drawing.Point(515, 299);
            this.gbAlgebraicas.Margin = new System.Windows.Forms.Padding(2);
            this.gbAlgebraicas.Name = "gbAlgebraicas";
            this.gbAlgebraicas.Padding = new System.Windows.Forms.Padding(2);
            this.gbAlgebraicas.Size = new System.Drawing.Size(213, 137);
            this.gbAlgebraicas.TabIndex = 8;
            this.gbAlgebraicas.TabStop = false;
            this.gbAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(11, 110);
            this.btnDiferencia.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(188, 23);
            this.btnDiferencia.TabIndex = 2;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(11, 69);
            this.btnInterseccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(188, 23);
            this.btnInterseccion.TabIndex = 1;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(11, 32);
            this.btnUnion.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(188, 23);
            this.btnUnion.TabIndex = 0;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // gbSeleccion
            // 
            this.gbSeleccion.Controls.Add(this.btnSelecConv);
            this.gbSeleccion.Controls.Add(this.btnSelecMulti);
            this.gbSeleccion.Controls.Add(this.btnSelecSimple);
            this.gbSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSeleccion.Location = new System.Drawing.Point(268, 299);
            this.gbSeleccion.Margin = new System.Windows.Forms.Padding(2);
            this.gbSeleccion.Name = "gbSeleccion";
            this.gbSeleccion.Padding = new System.Windows.Forms.Padding(2);
            this.gbSeleccion.Size = new System.Drawing.Size(227, 137);
            this.gbSeleccion.TabIndex = 7;
            this.gbSeleccion.TabStop = false;
            this.gbSeleccion.Text = "Operaciones de Selección - WHERE";
            // 
            // btnSelecConv
            // 
            this.btnSelecConv.Location = new System.Drawing.Point(11, 110);
            this.btnSelecConv.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelecConv.Name = "btnSelecConv";
            this.btnSelecConv.Size = new System.Drawing.Size(188, 23);
            this.btnSelecConv.TabIndex = 2;
            this.btnSelecConv.Text = "Selección por convolución";
            this.btnSelecConv.UseVisualStyleBackColor = true;
            // 
            // btnSelecMulti
            // 
            this.btnSelecMulti.Location = new System.Drawing.Point(11, 69);
            this.btnSelecMulti.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelecMulti.Name = "btnSelecMulti";
            this.btnSelecMulti.Size = new System.Drawing.Size(188, 23);
            this.btnSelecMulti.TabIndex = 1;
            this.btnSelecMulti.Text = "Selección multiatributo";
            this.btnSelecMulti.UseVisualStyleBackColor = true;
            // 
            // btnSelecSimple
            // 
            this.btnSelecSimple.Location = new System.Drawing.Point(11, 32);
            this.btnSelecSimple.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelecSimple.Name = "btnSelecSimple";
            this.btnSelecSimple.Size = new System.Drawing.Size(188, 23);
            this.btnSelecSimple.TabIndex = 0;
            this.btnSelecSimple.Text = "Selección simple";
            this.btnSelecSimple.UseVisualStyleBackColor = true;
            // 
            // gbProyeccion
            // 
            this.gbProyeccion.Controls.Add(this.btnJuntar);
            this.gbProyeccion.Controls.Add(this.btnProyMulti);
            this.gbProyeccion.Controls.Add(this.btnProySimple);
            this.gbProyeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProyeccion.Location = new System.Drawing.Point(11, 299);
            this.gbProyeccion.Margin = new System.Windows.Forms.Padding(2);
            this.gbProyeccion.Name = "gbProyeccion";
            this.gbProyeccion.Padding = new System.Windows.Forms.Padding(2);
            this.gbProyeccion.Size = new System.Drawing.Size(235, 137);
            this.gbProyeccion.TabIndex = 6;
            this.gbProyeccion.TabStop = false;
            this.gbProyeccion.Text = "Operaciones de Proyección - SELECT";
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(11, 110);
            this.btnJuntar.Margin = new System.Windows.Forms.Padding(2);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(188, 23);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // btnProyMulti
            // 
            this.btnProyMulti.Location = new System.Drawing.Point(11, 69);
            this.btnProyMulti.Margin = new System.Windows.Forms.Padding(2);
            this.btnProyMulti.Name = "btnProyMulti";
            this.btnProyMulti.Size = new System.Drawing.Size(188, 23);
            this.btnProyMulti.TabIndex = 1;
            this.btnProyMulti.Text = "Proyección multiatributo";
            this.btnProyMulti.UseVisualStyleBackColor = true;
            // 
            // btnProySimple
            // 
            this.btnProySimple.Location = new System.Drawing.Point(11, 32);
            this.btnProySimple.Margin = new System.Windows.Forms.Padding(2);
            this.btnProySimple.Name = "btnProySimple";
            this.btnProySimple.Size = new System.Drawing.Size(188, 23);
            this.btnProySimple.TabIndex = 0;
            this.btnProySimple.Text = "Proyección simple";
            this.btnProySimple.UseVisualStyleBackColor = true;
            // 
            // dgvBaseDatos
            // 
            this.dgvBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatos.Location = new System.Drawing.Point(11, 11);
            this.dgvBaseDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBaseDatos.Name = "dgvBaseDatos";
            this.dgvBaseDatos.RowHeadersWidth = 51;
            this.dgvBaseDatos.RowTemplate.Height = 24;
            this.dgvBaseDatos.Size = new System.Drawing.Size(717, 271);
            this.dgvBaseDatos.TabIndex = 5;
            // 
            // frmBdOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.gbAlgebraicas);
            this.Controls.Add(this.gbSeleccion);
            this.Controls.Add(this.gbProyeccion);
            this.Controls.Add(this.dgvBaseDatos);
            this.Name = "frmBdOperaciones";
            this.Text = "Base de Datos";
            this.gbAlgebraicas.ResumeLayout(false);
            this.gbSeleccion.ResumeLayout(false);
            this.gbProyeccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAlgebraicas;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.GroupBox gbSeleccion;
        private System.Windows.Forms.Button btnSelecConv;
        private System.Windows.Forms.Button btnSelecMulti;
        private System.Windows.Forms.Button btnSelecSimple;
        private System.Windows.Forms.GroupBox gbProyeccion;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyMulti;
        private System.Windows.Forms.Button btnProySimple;
        private System.Windows.Forms.DataGridView dgvBaseDatos;
    }
}