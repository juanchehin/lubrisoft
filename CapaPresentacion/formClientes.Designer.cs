namespace CapaPresentacion
{
    partial class formClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.dataListadoClientes = new System.Windows.Forms.DataGridView();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.txtBuscarApellido = new System.Windows.Forms.TextBox();
            this.botonEditarListado = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscarApNom = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.btnBuscarPatente = new System.Windows.Forms.Button();
            this.btnAgregarTrabajo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.txtBuscarNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 91);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clientes";
            // 
            // dataListadoClientes
            // 
            this.dataListadoClientes.AllowUserToAddRows = false;
            this.dataListadoClientes.AllowUserToDeleteRows = false;
            this.dataListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoClientes.Location = new System.Drawing.Point(12, 271);
            this.dataListadoClientes.MultiSelect = false;
            this.dataListadoClientes.Name = "dataListadoClientes";
            this.dataListadoClientes.ReadOnly = true;
            this.dataListadoClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoClientes.Size = new System.Drawing.Size(894, 326);
            this.dataListadoClientes.TabIndex = 10;
            this.dataListadoClientes.SelectionChanged += new System.EventHandler(this.dataListadoClientes_SelectionChanged);
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.AutoSize = true;
            this.lblTotalClientes.Location = new System.Drawing.Point(789, 255);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(35, 13);
            this.lblTotalClientes.TabIndex = 16;
            this.lblTotalClientes.Text = "label2";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(417, 204);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(123, 23);
            this.btnNuevoCliente.TabIndex = 15;
            this.btnNuevoCliente.Text = "Nuevo cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // txtBuscarApellido
            // 
            this.txtBuscarApellido.Location = new System.Drawing.Point(76, 19);
            this.txtBuscarApellido.Name = "txtBuscarApellido";
            this.txtBuscarApellido.Size = new System.Drawing.Size(136, 20);
            this.txtBuscarApellido.TabIndex = 12;
            this.txtBuscarApellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // botonEditarListado
            // 
            this.botonEditarListado.Location = new System.Drawing.Point(668, 204);
            this.botonEditarListado.Name = "botonEditarListado";
            this.botonEditarListado.Size = new System.Drawing.Size(75, 23);
            this.botonEditarListado.TabIndex = 14;
            this.botonEditarListado.Text = "Ver ficha";
            this.botonEditarListado.UseVisualStyleBackColor = true;
            this.botonEditarListado.Click += new System.EventHandler(this.botonEditarListado_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(749, 204);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnBuscarApNom
            // 
            this.btnBuscarApNom.Location = new System.Drawing.Point(232, 19);
            this.btnBuscarApNom.Name = "btnBuscarApNom";
            this.btnBuscarApNom.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarApNom.TabIndex = 11;
            this.btnBuscarApNom.Text = "Buscar";
            this.btnBuscarApNom.UseVisualStyleBackColor = true;
            this.btnBuscarApNom.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btnRefrescar.Location = new System.Drawing.Point(866, 204);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(31, 32);
            this.btnRefrescar.TabIndex = 30;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(866, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 74);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.logo4;
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Patente : ";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(67, 37);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(136, 20);
            this.txtPatente.TabIndex = 32;
            this.txtPatente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPatente_KeyDown);
            // 
            // btnBuscarPatente
            // 
            this.btnBuscarPatente.Location = new System.Drawing.Point(223, 35);
            this.btnBuscarPatente.Name = "btnBuscarPatente";
            this.btnBuscarPatente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPatente.TabIndex = 34;
            this.btnBuscarPatente.Text = "Buscar";
            this.btnBuscarPatente.UseVisualStyleBackColor = true;
            this.btnBuscarPatente.Click += new System.EventHandler(this.btnBuscarPatente_Click);
            // 
            // btnAgregarTrabajo
            // 
            this.btnAgregarTrabajo.Location = new System.Drawing.Point(546, 204);
            this.btnAgregarTrabajo.Name = "btnAgregarTrabajo";
            this.btnAgregarTrabajo.Size = new System.Drawing.Size(116, 23);
            this.btnAgregarTrabajo.TabIndex = 35;
            this.btnAgregarTrabajo.Text = "Agregar Trabajo";
            this.btnAgregarTrabajo.UseVisualStyleBackColor = true;
            this.btnAgregarTrabajo.Click += new System.EventHandler(this.btnAgregarTrabajo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(749, 603);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 37;
            this.btnAnterior.Text = "<< Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(833, 603);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 36;
            this.btnSiguiente.Text = "Siguiente >>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = global::CapaPresentacion.Properties.Resources.info;
            this.btnAyuda.Location = new System.Drawing.Point(12, 603);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(45, 42);
            this.btnAyuda.TabIndex = 31;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(288, 204);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(123, 23);
            this.btnHistorial.TabIndex = 38;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // txtBuscarNombres
            // 
            this.txtBuscarNombres.Location = new System.Drawing.Point(76, 58);
            this.txtBuscarNombres.Name = "txtBuscarNombres";
            this.txtBuscarNombres.Size = new System.Drawing.Size(136, 20);
            this.txtBuscarNombres.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Apellidos :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Nombres : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscarApellido);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnBuscarApNom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBuscarNombres);
            this.groupBox1.Location = new System.Drawing.Point(31, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 100);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda por apellido y nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPatente);
            this.groupBox2.Controls.Add(this.btnBuscarPatente);
            this.groupBox2.Location = new System.Drawing.Point(492, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 100);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda por patente";
            // 
            // formClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 657);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAgregarTrabajo);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.lblTotalClientes);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.botonEditarListado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataListadoClientes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formClientes";
            this.Text = "                                                                                 " +
    "                                 ..:: Clientes ::..";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClientes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataListadoClientes;
        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.TextBox txtBuscarApellido;
        private System.Windows.Forms.Button botonEditarListado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscarApNom;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Button btnBuscarPatente;
        private System.Windows.Forms.Button btnAgregarTrabajo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.TextBox txtBuscarNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}