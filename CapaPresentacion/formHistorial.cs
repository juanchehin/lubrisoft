using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class formHistorial : Form
    {
        CN_Clientes objetoCN = new CN_Clientes();
        DataTable respuesta;
        int desde = 0;
        int IdCliente;
        int IdTrabajo;
        DataSet ds = new DataSet();
        string totalHistorico;

        public formHistorial(int IdCliente)
        {
            InitializeComponent();
            dameCliente(IdCliente);
            dameHistoricoClientePaginado(IdCliente,desde);
            this.IdCliente = IdCliente;
        }
        private void dameCliente(int IdCliente)
        {
            respuesta = objetoCN.MostrarCliente(IdCliente);

            foreach (DataRow row in respuesta.Rows)
            {
                lblHistorico.Text = "Historico de : " + Convert.ToString(row["Apellidos"]) + " " + Convert.ToString(row["Nombres"]);
            }
        }

        public void dameHistoricoClientePaginado(int IdCliente,int desde)
        {
            try
            {
                ds = objetoCN.dameHistoricoClientePaginado(IdCliente, desde);
                dataListadoHistorico.DataSource = ds.Tables[0];
                totalHistorico = ds.Tables[1].Rows[0][0].ToString();
                lblTotalHistorico.Text = "Total de Registros: " + totalHistorico;
                dataListadoHistorico.Columns[0].Visible = false;
            }
            catch(Exception e)
            {
                MensajeError("El cliente no posee trabajos cargados");
                return;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if ((desde + 20) >= Convert.ToInt32(totalHistorico))
            {
                return;
            }

            if (desde < 0)
            {
                return;
            }

            this.desde += 20;
            this.dameHistoricoClientePaginado(IdCliente,this.desde);

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (desde <= 0)
            {
                this.desde = 0;
                return;
            }

            this.desde -= 20;
            this.dameHistoricoClientePaginado(IdCliente,this.desde);

        }

        private void btnEditarTrabajo_Click(object sender, EventArgs e)
        {
            formNuevoEditarTrabajo frm = new formNuevoEditarTrabajo(this.IdCliente,this.IdTrabajo, false);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void dataListadoHistorico_SelectionChanged(object sender, EventArgs e)
        {
            if (dataListadoHistorico.SelectedCells.Count > 0 && Convert.ToInt32(totalHistorico) > 0)
            {
                int selectedrowindex = dataListadoHistorico.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataListadoHistorico.Rows[selectedrowindex];
                this.IdTrabajo = Convert.ToInt32(selectedRow.Cells["IdTrabajo"].Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar el trabajo", "Wilkin Lubricentro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    CN_Clientes.EliminarTrabajo(this.IdTrabajo);
                    dameHistoricoClientePaginado(this.IdCliente,0);
                    MensajeOk("Se elimino de forma correcta el registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Wilkin Lubricentro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Wilkin Lubricentro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            dameHistoricoClientePaginado(IdCliente, 0);
        }
    }
}
