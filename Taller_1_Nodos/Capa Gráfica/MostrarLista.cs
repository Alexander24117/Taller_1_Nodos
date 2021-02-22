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
using Taller_1_Nodos.Capa_Lógica;

namespace Taller_1_Nodos.Capa_Gráfica
{
    public partial class MostrarLista : Form
    {
        public MostrarLista()
        {
            InitializeComponent();
        }

        private void Grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarNodoAlInicio gui = new InsertarNodoAlInicio();
            gui.Show();
        }

        private void btnInsertarPosicion_Click(object sender, EventArgs e)
        {
            InsertarNodoPorPosicion gui = new InsertarNodoPorPosicion();
            gui.Show();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
          
                Huesped tem;
                int numFila;

                tem = ServicioLista.GetCabecera();
                Grilla.Rows.Clear();

                if (tem == null)
                {
                    MessageBox.Show("La lista esta vacía!");
                    return;
                }

                while (tem != null)
                {
                    numFila = Grilla.Rows.Add();
                Grilla.Rows[numFila].Cells[0].Value = tem.GetNombre();
                Grilla.Rows[numFila].Cells[1].Value = tem.GetApellido();
                Grilla.Rows[numFila].Cells[2].Value = tem.GetTipoDocumento();
                Grilla.Rows[numFila].Cells[3].Value = tem.GetNumeroDocumento();
                Grilla.Rows[numFila].Cells[4].Value = tem.GetFechaNacimiento().ToString("MM/dd/yyyy");


                tem = tem.GetSiguiente();
                }

            }

        private void btnEliminarInicio_Click(object sender, EventArgs e)
        {
            ServicioLista.EliminarInicio();
            MessageBox.Show("Se ha eliminado exitosamente");
        }

        private void btnEliminarFinal_Click(object sender, EventArgs e)
        {
            ServicioLista.EliminarFinal();
            MessageBox.Show("Se ha eliminado exitosamente");
        }

        private void btnEliminarPosicion_Click(object sender, EventArgs e)
        {
            EliminarNodoPorPosicion gui = new EliminarNodoPorPosicion();
            gui.Show();
        }
    }
    }

