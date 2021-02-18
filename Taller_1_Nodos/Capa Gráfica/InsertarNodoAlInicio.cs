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
    public partial class InsertarNodoAlInicio : Form
    {
        public InsertarNodoAlInicio()
        {
            InitializeComponent();
        }

        private void InsertarNodoAlInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estudiante adicionado!");
            txtCodigo.Text = "";
            txtNombre.Text = "";

            txtCodigo.Focus();
        }
    }
}
