using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class formNuevoTrabajo : Form
    {
        CN_Clientes objetoCN = new CN_Clientes();
        DataTable respuesta;
        int IdCliente;
        public formNuevoTrabajo(int IdCliente)
        {
            InitializeComponent();
            this.IdCliente = IdCliente;
            dameCliente(IdCliente);
            rellenarComboxs();
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void dameCliente(int IdCliente)
        {
            respuesta = objetoCN.MostrarCliente(IdCliente);

            foreach (DataRow row in respuesta.Rows)
            {
                lblApellidosNomb.Text = Convert.ToString(row["Apellidos"]) + " " + Convert.ToString(row["Nombres"]);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                //rpta = CN_Clientes.NuevoTrabajo(
                //    this.IdCliente,txtAceite.Text.Trim(), txtFiltroAire.Text.Trim(), txtFiltroAceite.Text.Trim(), cbCorreaDist.Text,cbAlternador.Text, cbTensorDist.Text, cbBombaAgua.Text
                //    , cbPastillaFreno.Text, cbRefrigerante.Text, txtCambioBujia.Text, txtCableBujia.Text, txtComb.Text, txtAA.Text, txtKm.Text.Trim(),rtbObservaciones.Text.Trim());                    
                //if (rpta.Equals("Ok"))
                //{
                       
                //    this.MensajeOk("Se Insertó de forma correcta el registro");
                        
                //}
                //else
                //{
                //    this.MensajeError(rpta);
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            this.Close();
        }

        private void rellenarComboxs()
        {
            cbAlternador.Items.Add("Si");
            cbAlternador.Items.Add("No");
            cbAlternador.SelectedItem = "No";

            cbBombaAgua.Items.Add("Si");
            cbBombaAgua.Items.Add("No");
            cbBombaAgua.SelectedItem = "No";

            cbCorreaDist.Items.Add("Si");
            cbCorreaDist.Items.Add("No");
            cbCorreaDist.SelectedItem = "No";

            cbPastillaFreno.Items.Add("Si");
            cbPastillaFreno.Items.Add("No");
            cbPastillaFreno.SelectedItem = "No";

            cbRefrigerante.Items.Add("Si");
            cbRefrigerante.Items.Add("No");
            cbRefrigerante.SelectedItem = "No";

            cbTensorDist.Items.Add("Si");
            cbTensorDist.Items.Add("No");
            cbTensorDist.SelectedItem = "No";

        }

        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Wilkin Lubricentro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Wilkin Lubricentro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAceite_TextChanged(object sender, EventArgs e)
        {
            if (txtAceite.Text.Length > 200)
            {
                MensajeError("Maximo numero de caracteres");
            }
        }

        private void txtFiltroAire_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltroAire.Text.Length > 200)
            {
                MensajeError("Maximo numero de caracteres");
            }
        }

        private void txtFiltroAceite_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltroAceite.Text.Length > 200)
            {
                MensajeError("Maximo numero de caracteres");
            }
        }

        private void txtComb_TextChanged(object sender, EventArgs e)
        {
            if (txtComb.Text.Length > 200)
            {
                MensajeError("Maximo numero de caracteres");
            }
        }

        private void txtAA_TextChanged(object sender, EventArgs e)
        {
            if (txtAA.Text.Length > 200)
            {
                MensajeError("Maximo numero de caracteres");
            }
        }

        private void txtCambioBujia_TextChanged(object sender, EventArgs e)
        {
            if (txtCambioBujia.Text.Length > 200)
            {
                MensajeError("Maximo numero de caracteres");
            }
        }

        private void txtCableBujia_TextChanged(object sender, EventArgs e)
        {
            if (txtCableBujia.Text.Length > 20)
            {
                MensajeError("Maximo numero de caracteres");
            }
        }
    }
}
