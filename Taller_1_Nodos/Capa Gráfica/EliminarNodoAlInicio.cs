using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_1_Nodos.Capa_Estructural;

namespace Taller_1_Nodos.Capa_Gráfica
{
    public partial class EliminarNodoAlInicio : Form
    {
        public EliminarNodoAlInicio()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ServicioLista.EliminarInicio();
            MessageBox.Show("Se ha eliminado exitosamente");
        }
    }
}
