namespace pryTrabajoPracticoLab3
{
    partial class frmMinMaxLocalidad
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMinima = new System.Windows.Forms.Label();
            this.lblMaxima = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtMinima = new System.Windows.Forms.TextBox();
            this.txtMaxima = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(38, 31);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 0;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(38, 78);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblMinima
            // 
            this.lblMinima.AutoSize = true;
            this.lblMinima.Location = new System.Drawing.Point(38, 122);
            this.lblMinima.Name = "lblMinima";
            this.lblMinima.Size = new System.Drawing.Size(43, 13);
            this.lblMinima.TabIndex = 2;
            this.lblMinima.Text = "Minima:";
            // 
            // lblMaxima
            // 
            this.lblMaxima.AutoSize = true;
            this.lblMaxima.Location = new System.Drawing.Point(38, 168);
            this.lblMaxima.Name = "lblMaxima";
            this.lblMaxima.Size = new System.Drawing.Size(46, 13);
            this.lblMaxima.TabIndex = 3;
            this.lblMaxima.Text = "Maxima:";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(128, 31);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbLocalidad.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(128, 71);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // txtMinima
            // 
            this.txtMinima.Location = new System.Drawing.Point(128, 119);
            this.txtMinima.Name = "txtMinima";
            this.txtMinima.Size = new System.Drawing.Size(100, 20);
            this.txtMinima.TabIndex = 6;
            // 
            // txtMaxima
            // 
            this.txtMaxima.Location = new System.Drawing.Point(128, 161);
            this.txtMaxima.Name = "txtMaxima";
            this.txtMaxima.Size = new System.Drawing.Size(100, 20);
            this.txtMaxima.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(208, 194);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmMinMaxLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(295, 229);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtMaxima);
            this.Controls.Add(this.txtMinima);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.lblMaxima);
            this.Controls.Add(this.lblMinima);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblLocalidad);
            this.Name = "frmMinMaxLocalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minima y Maxima por Localidad";
            this.Load += new System.EventHandler(this.frmMinMaxLocalidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMinima;
        private System.Windows.Forms.Label lblMaxima;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtMinima;
        private System.Windows.Forms.TextBox txtMaxima;
        private System.Windows.Forms.Button btnBuscar;
    }
}

