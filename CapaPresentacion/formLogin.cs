using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string Datos = CapaNegocio.CN_Usuarios.Login(this.txtUsuario.Text, this.txtPassword.Text);
            //Evaluar si existe el Usuario
            if (Datos != "Ok")
            {
                MessageBox.Show("Error de login", "Wilkin Lubricentro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                formClientes frm = new formClientes();
                frm.Show();
                this.Hide();

            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            formInformacion frm = new formInformacion();
            frm.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.ttAyuda.SetToolTip(btnAyuda, "Ayuda");
        }
    }
}
