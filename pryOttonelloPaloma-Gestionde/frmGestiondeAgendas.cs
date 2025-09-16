using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryOttonelloPaloma_Gestionde
{
    public partial class frmGestiondeAgendas : Form
    {
        public frmGestiondeAgendas()
        {
            InitializeComponent();
        }

        private void grbGestion_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void txtNumerodeTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNombredelContacto_TextChanged(object sender, EventArgs e)
        {

        }
        //Variables Globales
        string vContacto = "";
        string vNumero = "";
        

        //Vectores Globales
        public string[] VecTelefono = new string[5];
        public string[] VecContacto = new string[5];

        //Indice
        int indice = 0;
        DateTime vFecha = DateTime.Now;

        private void btmRegistrar_Click(object sender, EventArgs e)
        {
            vContacto = txtNombredelContacto.Text;
            vNumero = mtbNumerodeTelefono.Text;

            lstResultados.Items.Add("Contacto: " + vContacto + "Numero:"
                + vNumero + '\n');
            //Borro los datos
            txtNombredelContacto.Text = "";
            mtbNumerodeTelefono.Text = "";
        }

        private void mtbNumerodeTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btmBorrar_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Add("");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            frmContactos verContactos = new frmContactos(vContacto, vNumero);
        }
    }
}
