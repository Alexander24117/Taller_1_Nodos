
namespace Taller_1_Nodos
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarNodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPosiciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarNodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alInicioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alFinalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porPosiciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarNodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarNodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionesToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // funcionesToolStripMenuItem
            // 
            this.funcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarNodosToolStripMenuItem,
            this.eliminarNodosToolStripMenuItem,
            this.buscarNodoToolStripMenuItem,
            this.actualizarNodoToolStripMenuItem,
            this.mostrarListaToolStripMenuItem});
            this.funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            this.funcionesToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.funcionesToolStripMenuItem.Text = "Funciones";
            // 
            // insertarNodosToolStripMenuItem
            // 
            this.insertarNodosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alInicioToolStripMenuItem,
            this.porPosiciónToolStripMenuItem});
            this.insertarNodosToolStripMenuItem.Name = "insertarNodosToolStripMenuItem";
            this.insertarNodosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.insertarNodosToolStripMenuItem.Text = "Insertar Nodos";
            // 
            // alInicioToolStripMenuItem
            // 
            this.alInicioToolStripMenuItem.Name = "alInicioToolStripMenuItem";
            this.alInicioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.alInicioToolStripMenuItem.Text = "Al inicio o al final";
            this.alInicioToolStripMenuItem.Click += new System.EventHandler(this.alInicioToolStripMenuItem_Click);
            // 
            // porPosiciónToolStripMenuItem
            // 
            this.porPosiciónToolStripMenuItem.Name = "porPosiciónToolStripMenuItem";
            this.porPosiciónToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.porPosiciónToolStripMenuItem.Text = "Por posición";
            this.porPosiciónToolStripMenuItem.Click += new System.EventHandler(this.porPosiciónToolStripMenuItem_Click);
            // 
            // eliminarNodosToolStripMenuItem
            // 
            this.eliminarNodosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alInicioToolStripMenuItem1,
            this.alFinalToolStripMenuItem1,
            this.porPosiciónToolStripMenuItem1});
            this.eliminarNodosToolStripMenuItem.Name = "eliminarNodosToolStripMenuItem";
            this.eliminarNodosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarNodosToolStripMenuItem.Text = "Eliminar Nodos";
            // 
            // alInicioToolStripMenuItem1
            // 
            this.alInicioToolStripMenuItem1.Name = "alInicioToolStripMenuItem1";
            this.alInicioToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.alInicioToolStripMenuItem1.Text = "Al inicio ";
            this.alInicioToolStripMenuItem1.Click += new System.EventHandler(this.alInicioToolStripMenuItem1_Click);
            // 
            // alFinalToolStripMenuItem1
            // 
            this.alFinalToolStripMenuItem1.Name = "alFinalToolStripMenuItem1";
            this.alFinalToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.alFinalToolStripMenuItem1.Text = "Al final";
            this.alFinalToolStripMenuItem1.Click += new System.EventHandler(this.alFinalToolStripMenuItem1_Click);
            // 
            // porPosiciónToolStripMenuItem1
            // 
            this.porPosiciónToolStripMenuItem1.Name = "porPosiciónToolStripMenuItem1";
            this.porPosiciónToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.porPosiciónToolStripMenuItem1.Text = "Por posición";
            this.porPosiciónToolStripMenuItem1.Click += new System.EventHandler(this.porPosiciónToolStripMenuItem1_Click);
            // 
            // buscarNodoToolStripMenuItem
            // 
            this.buscarNodoToolStripMenuItem.Name = "buscarNodoToolStripMenuItem";
            this.buscarNodoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.buscarNodoToolStripMenuItem.Text = "Buscar Nodo";
            // 
            // actualizarNodoToolStripMenuItem
            // 
            this.actualizarNodoToolStripMenuItem.Name = "actualizarNodoToolStripMenuItem";
            this.actualizarNodoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.actualizarNodoToolStripMenuItem.Text = "Actualizar Nodo";
            // 
            // mostrarListaToolStripMenuItem
            // 
            this.mostrarListaToolStripMenuItem.Name = "mostrarListaToolStripMenuItem";
            this.mostrarListaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mostrarListaToolStripMenuItem.Text = "Mostrar Lista";
            this.mostrarListaToolStripMenuItem.Click += new System.EventHandler(this.mostrarListaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(533, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem funcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarNodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alInicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPosiciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarNodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alInicioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alFinalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porPosiciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarNodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarNodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarListaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

