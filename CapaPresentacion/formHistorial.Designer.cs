namespace CapaPresentacion
{
    partial class formHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHistorial));
            this.lblHistorico = new System.Windows.Forms.Label();
            this.dataListadoHistorico = new System.Windows.Forms.DataGridView();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblTotalHistorico = new System.Windows.Forms.Label();
            this.btnEditarTrabajo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorico.Location = new System.Drawing.Point(36, 9);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(191, 48);
            this.lblHistorico.TabIndex = 16;
            this.lblHistorico.Text = "Historico : ";
            // 
            // dataListadoHistorico
            // 
            this.dataListadoHistorico.AllowUserToAddRows = false;
            this.dataListadoHistorico.AllowUserToDeleteRows = false;
            this.dataListadoHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoHistorico.Location = new System.Drawing.Point(44, 104);
            this.dataListadoHistorico.Name = "dataListadoHistorico";
            this.dataListadoHistorico.Size = new System.Drawing.Size(921, 384);
            this.dataListadoHistorico.TabIndex = 17;
            this.dataListadoHistorico.SelectionChanged += new System.EventHandler(this.dataListadoHistorico_SelectionChanged);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(796, 494);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 18;
            this.btnAnterior.Text = "<< Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(890, 494);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 19;
            this.btnSiguiente.Text = "Siguiente >>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblTotalHistorico
            // 
            this.lblTotalHistorico.AutoSize = true;
            this.lblTotalHistorico.Location = new System.Drawing.Point(832, 88);
            this.lblTotalHistorico.Name = "lblTotalHistorico";
            this.lblTotalHistorico.Size = new System.Drawing.Size(68, 13);
            this.lblTotalHistorico.TabIndex = 20;
            this.lblTotalHistorico.Text = "totalHistorico";
            // 
            // btnEditarTrabajo
            // 
            this.btnEditarTrabajo.Location = new System.Drawing.Point(45, 75);
            this.btnEditarTrabajo.Name = "btnEditarTrabajo";
            this.btnEditarTrabajo.Size = new System.Drawing.Size(134, 23);
            this.btnEditarTrabajo.TabIndex = 40;
            this.btnEditarTrabajo.Text = "Editar trabajo";
            this.btnEditarTrabajo.UseVisualStyleBackColor = true;
            this.btnEditarTrabajo.Click += new System.EventHandler(this.btnEditarTrabajo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(185, 75);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(134, 23);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "Eliminar trabajo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btnRefrescar.Location = new System.Drawing.Point(934, 46);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(31, 32);
            this.btnRefrescar.TabIndex = 42;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // formHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 529);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditarTrabajo);
            this.Controls.Add(this.lblTotalHistorico);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.dataListadoHistorico);
            this.Controls.Add(this.lblHistorico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formHistorial";
            this.Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.DataGridView dataListadoHistorico;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblTotalHistorico;
        private System.Windows.Forms.Button btnEditarTrabajo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRefrescar;
    }
}