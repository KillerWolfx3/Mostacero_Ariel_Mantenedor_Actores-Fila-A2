using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MostaceroEntidad;
using MostaceroLogica;

namespace Mostacero_Ariel_Mantenedor_Actores
{
    public partial class MantenedorActores : Form
    {
        public MantenedorActores()
        {
            InitializeComponent();
            ListarActor();
            PnModificar.Enabled = false;
            txtIdActor.Enabled = false;

        }
        public void ListarActor()
        {
            dgvActor.DataSource = LogActor.Instancia.ListarActor();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvActor.Rows[e.RowIndex]; //
            txtNombre.Text = filaActual.Cells[0].Value.ToString();
            txtApellido.Text = filaActual.Cells[1].Value.ToString();
            txtIdActor.Text = filaActual.Cells[2].Value.ToString();
            txtPelicula.Text = filaActual.Cells[3].Value.ToString();
           

        }

        private void lbPel_Click(object sender, EventArgs e)
        {

        }

        private void MantenedorActores_Load(object sender, EventArgs e)
        {

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            PnModificar.Enabled = true;
            btModificar.Visible = true;
            LimpiarVariables();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            PnModificar.Enabled = false;
        }
        private void LimpiarVariables()
        {
            txtNombre.Text = "";
            txtApellido.Text = " ";
            txtPelicula.Text = " ";
        }
        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entidadActor a = new entidadActor();
                a.Nombre = txtNombre.Text.Trim();
                a.Apellido = txtApellido.Text.Trim();
                a.IdActor = int.Parse(txtIdActor.Text.Trim());
                a.Pelicula = txtApellido.Text.Trim();
                LogActor.Instancia.EditarActor(a);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            PnModificar.Enabled = false;
            ListarActor();
        }
    }
}
