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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btmRegistrar = new System.Windows.Forms.Button();
            this.btmBorrar = new System.Windows.Forms.Button();
            this.mtbNumerodeTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtNombredelContacto = new System.Windows.Forms.TextBox();
            this.lstResultados = new System.Windows.Forms.ListView();
            this.lblContactos = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.grbGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGestion
            // 
            this.grbGestion.Controls.Add(this.mtbNumerodeTelefono);
            this.grbGestion.Controls.Add(this.lblNumero);
            this.grbGestion.Controls.Add(this.txtNombredelContacto);
            this.grbGestion.Controls.Add(this.dtpFecha);
            this.grbGestion.Controls.Add(this.label2);
            this.grbGestion.Controls.Add(this.label1);
            this.grbGestion.Location = new System.Drawing.Point(67, 42);
            this.grbGestion.Name = "grbGestion";
            this.grbGestion.Size = new System.Drawing.Size(313, 208);
            this.grbGestion.TabIndex = 4;
            this.grbGestion.TabStop = false;
            this.grbGestion.Text = "Gestión de Agenda";
            this.grbGestion.Enter += new System.EventHandler(this.grbGestion_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agenda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contacto";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(76, 30);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 2;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(17, 122);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(104, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número de Teléfono";
            this.lblNumero.Click += new System.EventHandler(this.lblNumero_Click);
            // 
            // btmRegistrar
            // 
            this.btmRegistrar.Location = new System.Drawing.Point(301, 256);
            this.btmRegistrar.Name = "btmRegistrar";
            this.btmRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btmRegistrar.TabIndex = 1;
            this.btmRegistrar.Text = "Registrar";
            this.btmRegistrar.UseVisualStyleBackColor = true;
            this.btmRegistrar.Click += new System.EventHandler(this.btmRegistrar_Click);
            // 
            // btmBorrar
            // 
            this.btmBorrar.Location = new System.Drawing.Point(220, 256);
            this.btmBorrar.Name = "btmBorrar";
            this.btmBorrar.Size = new System.Drawing.Size(75, 23);
            this.btmBorrar.TabIndex = 3;
            this.btmBorrar.Text = "Borrar";
            this.btmBorrar.UseVisualStyleBackColor = true;
            this.btmBorrar.Click += new System.EventHandler(this.btmBorrar_Click);
            // 
            // mtbNumerodeTelefono
            // 
            this.mtbNumerodeTelefono.Location = new System.Drawing.Point(20, 138);
            this.mtbNumerodeTelefono.Mask = "000-000-0000";
            this.mtbNumerodeTelefono.Name = "mtbNumerodeTelefono";
            this.mtbNumerodeTelefono.Size = new System.Drawing.Size(226, 20);
            this.mtbNumerodeTelefono.TabIndex = 4;
            this.mtbNumerodeTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbNumerodeTelefono_MaskInputRejected);
            // 
            // txtNombredelContacto
            // 
            this.txtNombredelContacto.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombredelContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombredelContacto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNombredelContacto.Location = new System.Drawing.Point(20, 86);
            this.txtNombredelContacto.MaxLength = 20;
            this.txtNombredelContacto.Name = "txtNombredelContacto";
            this.txtNombredelContacto.Size = new System.Drawing.Size(226, 20);
            this.txtNombredelContacto.TabIndex = 3;
            this.txtNombredelContacto.TextChanged += new System.EventHandler(this.txtNombredelContacto_TextChanged);
            // 
            // lstResultados
            // 
            this.lstResultados.HideSelection = false;
            this.lstResultados.Location = new System.Drawing.Point(67, 285);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(309, 97);
            this.lstResultados.TabIndex = 2;
            this.lstResultados.UseCompatibleStateImageBehavior = false;
            // 
            // lblContactos
            // 
            this.lblContactos.AutoSize = true;
            this.lblContactos.Location = new System.Drawing.Point(64, 397);
            this.lblContactos.Name = "lblContactos";
            this.lblContactos.Size = new System.Drawing.Size(121, 13);
            this.lblContactos.TabIndex = 5;
            this.lblContactos.Text = "Cantidad de Contadores";
            this.lblContactos.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(298, 397);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(71, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha y Hora";
            // 
            // frmGestiondeAgendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblContactos);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btmBorrar);
            this.Controls.Add(this.btmRegistrar);
            this.Controls.Add(this.grbGestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestiondeAgendas";
            this.Text = "frmGestiondeAgendas";
            this.grbGestion.ResumeLayout(false);
            this.grbGestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmRegistrar;
        private System.Windows.Forms.Button btmBorrar;
        private System.Windows.Forms.MaskedTextBox mtbNumerodeTelefono;
        private System.Windows.Forms.TextBox txtNombredelContacto;
        private System.Windows.Forms.ListView lstResultados;
        private System.Windows.Forms.Label lblContactos;
        private System.Windows.Forms.Label lblFecha;
    }
}