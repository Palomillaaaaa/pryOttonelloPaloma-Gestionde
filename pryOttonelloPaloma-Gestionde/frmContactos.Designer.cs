namespace pryOttonelloPaloma_Gestionde
{
    partial class frmContactos
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
            this.lblMostrar = new System.Windows.Forms.Label();
            this.btmAtras = new System.Windows.Forms.Button();
            this.btmSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMostrar
            // 
            this.lblMostrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrar.Location = new System.Drawing.Point(0, 0);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(632, 267);
            this.lblMostrar.TabIndex = 0;
            this.lblMostrar.Text = "-";
            this.lblMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMostrar.Click += new System.EventHandler(this.lblMostrar_Click);
            // 
            // btmAtras
            // 
            this.btmAtras.Location = new System.Drawing.Point(12, 283);
            this.btmAtras.Name = "btmAtras";
            this.btmAtras.Size = new System.Drawing.Size(261, 80);
            this.btmAtras.TabIndex = 1;
            this.btmAtras.Text = "Atrás";
            this.btmAtras.UseVisualStyleBackColor = true;
            this.btmAtras.Click += new System.EventHandler(this.button1_Click);
            // 
            // btmSiguiente
            // 
            this.btmSiguiente.Location = new System.Drawing.Point(371, 283);
            this.btmSiguiente.Name = "btmSiguiente";
            this.btmSiguiente.Size = new System.Drawing.Size(261, 80);
            this.btmSiguiente.TabIndex = 2;
            this.btmSiguiente.Text = "Siguiente";
            this.btmSiguiente.UseVisualStyleBackColor = true;
            this.btmSiguiente.Click += new System.EventHandler(this.btmSiguiente_Click);
            // 
            // frmContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmSiguiente);
            this.Controls.Add(this.btmAtras);
            this.Controls.Add(this.lblMostrar);
            this.Name = "frmContactos";
            this.Text = "frmContactos";
            this.Load += new System.EventHandler(this.frmContactos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Button btmAtras;
        private System.Windows.Forms.Button btmSiguiente;
    }
}