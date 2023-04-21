using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class formNuevoEditarTrabajo : Form
    {
        CN_Clientes objetoCN = new CN_Clientes();
        DataTable respuesta;
        string resp1;
        bool bandera;
        bool IsNuevo = false;
        bool IsEditar = false;

        private int IdCliente;
        private int IdTrabajo;
        public formNuevoEditarTrabajo(int IdCliente, int IdTrabajo, bool IsNuevoEditar)
        {
            InitializeComponent();
            this.IdCliente = IdCliente;
            this.IdTrabajo = IdTrabajo;
            this.bandera = IsNuevoEditar;
        }
        private void formNuevoEditarTrabajo_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtKm;
            if (this.bandera)
            {
                lblEditarNuevo.Text = "Nuevo Trabajo";
                // this.MostrarProducto(this.IdProducto);
                this.IsNuevo = true;
                this.IsEditar = false;
                this.dameCliente(this.IdCliente);
                rellenarComboxs();
            }
            else
            {
                lblEditarNuevo.Text = "Editar Trabajo";
                this.IsNuevo = false;
                this.IsEditar = true;
                rellenarComboxs();
                this.dameCliente(this.IdCliente);
                this.dameTrabajo(this.IdTrabajo);
            }
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

        private void dameCliente(int IdCliente)
        {
            respuesta = objetoCN.MostrarCliente(IdCliente);

            foreach (DataRow row in respuesta.Rows)
            {
                lblApellidosNomb.Text = Convert.ToString(row["Apellidos"]) + " " + Convert.ToString(row["Nombres"]);
            }
        }

        private void dameTrabajo(int IdTrabajo)
        {
            respuesta = objetoCN.dameTrabajo(IdTrabajo);

            if(respuesta.Rows[0][0] is string)
            {
                this.resp1 = (String)respuesta.Rows[0][0];
            }
            else
            {
                this.resp1 = "";
            }

            if (respuesta != null && this.resp1 != "Trabajo inexistente")
            {
                foreach (DataRow row in respuesta.Rows)
                {
                    IdTrabajo = Convert.ToInt32(row["IdTrabajo"]);

                    txtKm.Text = Convert.ToString(row["Kilometros"]);
                    txtAceite.Text = Convert.ToString(row["Aceite"]);
                    txtFiltroAceite.Text = Convert.ToString(row["FiltroAceite"]);
                    txtFiltroAire.Text = Convert.ToString(row["FiltroAire"]);

                    cbCorreaDist.Text = Convert.ToString(row["CorreaDist"]) != "S" ? "No" : "Si";
                    cbAlternador.Text = Convert.ToString(row["Alternador"]) != "S" ? "No" : "Si";
                    cbTensorDist.Text = Convert.ToString(row["TensorDist"]) != "S" ? "No" : "Si";
                    cbBombaAgua.Text = Convert.ToString(row["BombaAgua"]) != "S" ? "No" : "Si";
                    cbPastillaFreno.Text = Convert.ToString(row["PastillaFreno"]) != "S" ? "No" : "Si";
                    cbRefrigerante.Text = Convert.ToString(row["CambioRef"]) != "S" ? "No" : "Si"; ;

                    txtCambioBujia.Text = Convert.ToString(row["CambioBujia"]);
                    txtCableBujia.Text = Convert.ToString(row["CableBujia"]);
                    txtComb.Text = Convert.ToString(row["CambioComb"]);
                    txtAA.Text = Convert.ToString(row["CambioAA"]);
                    dtpFecha.Text = Convert.ToString(row["Fecha"]);

                    rtbObservaciones.Text = Convert.ToString(row["Observaciones"]);
                }
            }
            else
            {
                MensajeError("Ocurrio un problema.Contactese con el administrador");
                this.Close();
            }         

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

        private void rtbObservaciones_TextChanged(object sender, EventArgs e)
        {
            if (rtbObservaciones.Text.Length > 200)
            {
                MensajeError("Maximo numero de caracteres");
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                var añoInicio = dtpFecha.Value.Year;
                var mesInicio = dtpFecha.Value.Month;
                var diaInicio = dtpFecha.Value.Day;
                var Fecha = añoInicio + "-" + mesInicio + "-" + diaInicio;

                if (this.IsNuevo)
                {
                    rpta = CN_Clientes.NuevoTrabajo(
                   this.IdCliente, txtAceite.Text.Trim(), txtFiltroAceite.Text.Trim(), txtFiltroAire.Text.Trim(), cbCorreaDist.Text, cbAlternador.Text, cbTensorDist.Text, cbBombaAgua.Text
                   , cbPastillaFreno.Text, cbRefrigerante.Text, txtCambioBujia.Text, txtCableBujia.Text, txtComb.Text, txtAA.Text, txtKm.Text.Trim(), Fecha, rtbObservaciones.Text.Trim());

                }
                else
                {
                    rpta = CN_Clientes.EditarTrabajo(this.IdTrabajo, txtAceite.Text.Trim(), txtFiltroAceite.Text.Trim(), txtFiltroAire.Text.Trim(), cbCorreaDist.Text, cbAlternador.Text, cbTensorDist.Text, cbBombaAgua.Text
                   , cbPastillaFreno.Text, cbRefrigerante.Text, txtCambioBujia.Text, txtCableBujia.Text, txtComb.Text, txtAA.Text, txtKm.Text.Trim(), Fecha, rtbObservaciones.Text.Trim());
                }

                if (rpta.Equals("Ok"))
                {
                    if (this.IsNuevo)
                    {
                        this.MensajeOk("Se Insertó de forma correcta el registro");
                    }
                    else
                    {
                        this.MensajeOk("Se Actualizó de forma correcta el registro");
                    }
                }
                else
                {
                    this.MensajeError(rpta);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
