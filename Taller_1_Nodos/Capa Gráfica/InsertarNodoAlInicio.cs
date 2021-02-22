using System;
using System.Windows.Forms;
using Taller_1_Nodos.Capa_Estructural;
using Taller_1_Nodos.Capa_Lógica;

namespace Taller_1_Nodos.Capa_Gráfica
{
    public partial class InsertarNodoAlInicio : Form
    {
        public InsertarNodoAlInicio()
        {
            InitializeComponent();
        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtNumeroDocumento.Text == "" || comboBoxTipoDocumento.SelectedItem == null || dtFechaNac.Value == null)
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

                Huesped huesped;

                nombre = txtNombre.Text.Trim();
                apellido = txtApellido.Text.Trim();
                tipoDocumento = Convert.ToString(comboBoxTipoDocumento.SelectedItem);
                numeroDocumento = Convert.ToInt32(txtNumeroDocumento.Text);
                fechaNacimiento = dtFechaNac.Value;

                huesped = new Huesped(nombre, apellido, tipoDocumento, numeroDocumento, fechaNacimiento);

                ServicioLista.AdicionarNodoInicioLista(huesped);

                MessageBox.Show("Estudiante adicionado!");
                txtNombre.Text = "";
                txtApellido.Text = "";
                tipoDocumento.Trim();
                txtNumeroDocumento.Text = "";

                txtNombre.Focus();
            }
        }

        private void BtnAñadirFinal_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtNumeroDocumento.Text == "" || comboBoxTipoDocumento.SelectedItem == null)
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

                Huesped huesped;

                nombre = txtNombre.Text.Trim();
                apellido = txtApellido.Text.Trim();
                tipoDocumento = Convert.ToString(comboBoxTipoDocumento.SelectedItem);
                numeroDocumento = Convert.ToInt32(txtNumeroDocumento.Text);
                fechaNacimiento = dtFechaNac.Value;

                huesped = new Huesped(nombre, apellido, tipoDocumento, numeroDocumento, fechaNacimiento);

                ServicioLista.AdicionarNodoFinalLista(huesped);

                MessageBox.Show("Estudiante adicionado!");
                txtNombre.Text = "";
                txtApellido.Text = "";
                tipoDocumento.Trim();
                txtNumeroDocumento.Text = "";

                txtNombre.Focus();
            }
        }

        private void ComboBoxTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void InsertarNodoAlInicio_Load(object sender, EventArgs e)
        {
        }
    }
}