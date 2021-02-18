using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_1_Nodos.Capa_Gráfica
{
    public partial class InsertarNodoPorPosicion : Form
    {
        public InsertarNodoPorPosicion()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estudiante adicionado!");
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPosicion.Text = "";

            txtCodigo.Focus();
        }
    }
}
