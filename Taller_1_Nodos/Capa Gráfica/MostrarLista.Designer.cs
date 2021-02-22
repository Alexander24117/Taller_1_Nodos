
namespace Taller_1_Nodos.Capa_Gráfica
{
    partial class MostrarLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarLista));
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnInsertarPosicion = new System.Windows.Forms.Button();
            this.btnEliminarInicio = new System.Windows.Forms.Button();
            this.btnEliminarFinal = new System.Windows.Forms.Button();
            this.btnEliminarPosicion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.Grilla.Location = new System.Drawing.Point(12, 12);
            this.Grilla.Name = "Grilla";
            this.Grilla.RowHeadersWidth = 51;
            this.Grilla.RowTemplate.Height = 24;
            this.Grilla.Size = new System.Drawing.Size(896, 214);
            this.Grilla.TabIndex = 0;
            this.Grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo de documento";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Número de documento";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 170;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha de nacimiento";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 160;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(783, 247);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(125, 43);
            this.btnRefrescar.TabIndex = 1;
            this.btnRefrescar.Text = "Refrescar lista";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(12, 247);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(125, 43);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar Al inicio o final";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInsertarPosicion
            // 
            this.btnInsertarPosicion.Location = new System.Drawing.Point(143, 247);
            this.btnInsertarPosicion.Name = "btnInsertarPosicion";
            this.btnInsertarPosicion.Size = new System.Drawing.Size(125, 43);
            this.btnInsertarPosicion.TabIndex = 3;
            this.btnInsertarPosicion.Text = "Insertar por posición";
            this.btnInsertarPosicion.UseVisualStyleBackColor = true;
            this.btnInsertarPosicion.Click += new System.EventHandler(this.btnInsertarPosicion_Click);
            // 
            // btnEliminarInicio
            // 
            this.btnEliminarInicio.Location = new System.Drawing.Point(316, 247);
            this.btnEliminarInicio.Name = "btnEliminarInicio";
            this.btnEliminarInicio.Size = new System.Drawing.Size(125, 43);
            this.btnEliminarInicio.TabIndex = 4;
            this.btnEliminarInicio.Text = "Eliminar al inicio";
            this.btnEliminarInicio.UseVisualStyleBackColor = true;
            this.btnEliminarInicio.Click += new System.EventHandler(this.btnEliminarInicio_Click);
            // 
            // btnEliminarFinal
            // 
            this.btnEliminarFinal.Location = new System.Drawing.Point(447, 247);
            this.btnEliminarFinal.Name = "btnEliminarFinal";
            this.btnEliminarFinal.Size = new System.Drawing.Size(125, 43);
            this.btnEliminarFinal.TabIndex = 5;
            this.btnEliminarFinal.Text = "Eliminar al final";
            this.btnEliminarFinal.UseVisualStyleBackColor = true;
            this.btnEliminarFinal.Click += new System.EventHandler(this.btnEliminarFinal_Click);
            // 
            // btnEliminarPosicion
            // 
            this.btnEliminarPosicion.Location = new System.Drawing.Point(578, 247);
            this.btnEliminarPosicion.Name = "btnEliminarPosicion";
            this.btnEliminarPosicion.Size = new System.Drawing.Size(125, 43);
            this.btnEliminarPosicion.TabIndex = 6;
            this.btnEliminarPosicion.Text = "Eliminar por posición";
            this.btnEliminarPosicion.UseVisualStyleBackColor = true;
            this.btnEliminarPosicion.Click += new System.EventHandler(this.btnEliminarPosicion_Click);
            // 
            // MostrarLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 354);
            this.Controls.Add(this.btnEliminarPosicion);
            this.Controls.Add(this.btnEliminarFinal);
            this.Controls.Add(this.btnEliminarInicio);
            this.Controls.Add(this.btnInsertarPosicion);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.Grilla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MostrarLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar lista";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnInsertarPosicion;
        private System.Windows.Forms.Button btnEliminarInicio;
        private System.Windows.Forms.Button btnEliminarFinal;
        private System.Windows.Forms.Button btnEliminarPosicion;
    }
}