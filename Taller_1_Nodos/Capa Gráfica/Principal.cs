using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_1_Nodos.Capa_Gráfica;

namespace Taller_1_Nodos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación desarrollada por:" +
                "Camilo Campos - 2220191028" +
                "Elverth Pulido - 2220181048" +
                "Rafael Acosta - 22...");
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void alInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarNodoAlInicio gui = new InsertarNodoAlInicio();
            gui.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarNodoAlFinal gui = new InsertarNodoAlFinal();
            gui.Show();
        }

        private void porPosiciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarNodoPorPosicion gui = new InsertarNodoPorPosicion();
            gui.Show();
        }

        private void alInicioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarNodoAlInicio gui = new EliminarNodoAlInicio();
            gui.Show();
        }

        private void alFinalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarNodoAlFinal gui = new EliminarNodoAlFinal();
            gui.Show();
        }

        private void porPosiciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarNodoPorPosicion gui = new EliminarNodoPorPosicion();
            gui.Show();
        }

        private void mostrarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarLista gui = new MostrarLista();
            gui.Show();
        }
    }
}
