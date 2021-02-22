using System;
using System.Windows.Forms;
using Taller_1_Nodos.Capa_Estructural;
using Taller_1_Nodos.Capa_Lógica;

namespace Taller_1_Nodos.Capa_Gráfica
{
    public partial class InsertarNodoPorPosicion : Form
    {
        public InsertarNodoPorPosicion()
        {
            InitializeComponent();
        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
        }

        private void BtnAñadirPosicion_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtNumeroDocumento.Text == "" || comboBoxTipoDocumento.SelectedItem == null || txtPos.Text == "")
            {
                MessageBox.Show("Rellene los campos antes de continuar");
            }
            else
            {
                String nombre;
                String apellido;
                String tipoDocumento;
                int numeroDocumento;
                DateTime fechaNacimiento;
                int posicion = -1;

                Huesped huesped;

                nombre = txtNombre.Text.Trim();
                apellido = txtApellido.Text.Trim();
                tipoDocumento = Convert.ToString(comboBoxTipoDocumento.SelectedItem);
                numeroDocumento = Convert.ToInt32(txtNumeroDocumento.Text);
                fechaNacimiento = dtFechaNac.Value;
                posicion = Convert.ToInt32(txtPos.Text.Trim());

                huesped = new Huesped(nombre, apellido, tipoDocumento, numeroDocumento, fechaNacimiento);

                try
                {
                    ServicioLista.AdicionarNodoPosicionLista(huesped, posicion);
                    MessageBox.Show("Estudiante adicionado!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtNombre.Text = "";
                txtApellido.Text = "";
                tipoDocumento.Trim();
                txtNumeroDocumento.Text = "";
                txtPos.Text = "";

                txtNombre.Focus();
            }
        }
    }
}