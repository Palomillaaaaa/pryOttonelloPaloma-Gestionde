namespace pryOttonelloPaloma_Gestionde
{
    partial class frmGestiondeAgendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestiondeAgendas));
            this.grbGestion = new System.Windows.Forms.GroupBox();
            this.mtbNumerodeTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNombredelContacto = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblAgenda = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListView();
            this.lblContactos = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.gpbRegistroContacto = new System.Windows.Forms.GroupBox();
            this.grbGestion.SuspendLayout();
            this.gpbRegistroContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGestion
            // 
            this.grbGestion.Controls.Add(this.mtbNumerodeTelefono);
            this.grbGestion.Controls.Add(this.lblNumero);
            this.grbGestion.Controls.Add(this.txtNombredelContacto);
            this.grbGestion.Controls.Add(this.dtpFecha);
            this.grbGestion.Controls.Add(this.lblContacto);
            this.grbGestion.Controls.Add(this.lblAgenda);
            this.grbGestion.Location = new System.Drawing.Point(100, 65);
            this.grbGestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbGestion.Name = "grbGestion";
            this.grbGestion.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbGestion.Size = new System.Drawing.Size(470, 320);
            this.grbGestion.TabIndex = 4;
            this.grbGestion.TabStop = false;
            this.grbGestion.Text = "Gestión de Agenda";
            this.grbGestion.Enter += new System.EventHandler(this.grbGestion_Enter);
            // 
            // mtbNumerodeTelefono
            // 
            this.mtbNumerodeTelefono.Location = new System.Drawing.Point(30, 212);
            this.mtbNumerodeTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbNumerodeTelefono.Mask = "(999)000-0000";
            this.mtbNumerodeTelefono.Name = "mtbNumerodeTelefono";
            this.mtbNumerodeTelefono.Size = new System.Drawing.Size(337, 26);
            this.mtbNumerodeTelefono.TabIndex = 4;
            this.mtbNumerodeTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbNumerodeTelefono_MaskInputRejected);
            this.mtbNumerodeTelefono.TextChanged += new System.EventHandler(this.txtNumerodeTelefono_TextChanged);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(26, 188);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(153, 20);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número de Teléfono";
            this.lblNumero.Click += new System.EventHandler(this.lblNumero_Click);
            // 
            // txtNombredelContacto
            // 
            this.txtNombredelContacto.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombredelContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombredelContacto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNombredelContacto.Location = new System.Drawing.Point(30, 132);
            this.txtNombredelContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombredelContacto.MaxLength = 20;
            this.txtNombredelContacto.Name = "txtNombredelContacto";
            this.txtNombredelContacto.Size = new System.Drawing.Size(337, 26);
            this.txtNombredelContacto.TabIndex = 3;
            this.txtNombredelContacto.TextChanged += new System.EventHandler(this.txtNombredelContacto_TextChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(114, 46);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(298, 26);
            this.dtpFecha.TabIndex = 2;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(26, 108);
            this.lblContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(74, 20);
            this.lblContacto.TabIndex = 2;
            this.lblContacto.Text = "Contacto";
            // 
            // lblAgenda
            // 
            this.lblAgenda.AutoSize = true;
            this.lblAgenda.Location = new System.Drawing.Point(26, 49);
            this.lblAgenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(65, 20);
            this.lblAgenda.TabIndex = 1;
            this.lblAgenda.Text = "Agenda";
            this.lblAgenda.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(452, 394);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 35);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(330, 394);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(112, 35);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btmBorrar_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.BackColor = System.Drawing.SystemColors.Menu;
            this.lstResultados.HideSelection = false;
            this.lstResultados.Location = new System.Drawing.Point(20, 27);
            this.lstResultados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(424, 167);
            this.lstResultados.TabIndex = 2;
            this.lstResultados.UseCompatibleStateImageBehavior = false;
            this.lstResultados.SelectedIndexChanged += new System.EventHandler(this.lstResultados_SelectedIndexChanged);
            // 
            // lblContactos
            // 
            this.lblContactos.AutoSize = true;
            this.lblContactos.Location = new System.Drawing.Point(16, 219);
            this.lblContactos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactos.Name = "lblContactos";
            this.lblContactos.Size = new System.Drawing.Size(182, 20);
            this.lblContactos.TabIndex = 5;
            this.lblContactos.Text = "Cantidad de Contadores";
            this.lblContactos.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(332, 233);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(112, 35);
            this.btnVer.TabIndex = 7;
            this.btnVer.Text = "Ver Contactos";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // gpbRegistroContacto
            // 
            this.gpbRegistroContacto.Controls.Add(this.lstResultados);
            this.gpbRegistroContacto.Controls.Add(this.btnVer);
            this.gpbRegistroContacto.Controls.Add(this.lblContactos);
            this.gpbRegistroContacto.Location = new System.Drawing.Point(100, 453);
            this.gpbRegistroContacto.Name = "gpbRegistroContacto";
            this.gpbRegistroContacto.Size = new System.Drawing.Size(470, 291);
            this.gpbRegistroContacto.TabIndex = 8;
            this.gpbRegistroContacto.TabStop = false;
            this.gpbRegistroContacto.Text = "Registros";
            // 
            // frmGestiondeAgendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 904);
            this.Controls.Add(this.gpbRegistroContacto);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.grbGestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGestiondeAgendas";
            this.Text = "frmGestiondeAgendas";
            this.grbGestion.ResumeLayout(false);
            this.grbGestion.PerformLayout();
            this.gpbRegistroContacto.ResumeLayout(false);
            this.gpbRegistroContacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGestion;
        private System.Windows.Forms.Label lblAgenda;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.MaskedTextBox mtbNumerodeTelefono;
        private System.Windows.Forms.TextBox txtNombredelContacto;
        private System.Windows.Forms.ListView lstResultados;
        private System.Windows.Forms.Label lblContactos;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.GroupBox gpbRegistroContacto;
    }
}