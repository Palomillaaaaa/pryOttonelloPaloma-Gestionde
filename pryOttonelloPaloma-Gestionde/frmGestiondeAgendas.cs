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

        //Variables Globales
        string vContacto = "";
        string vNumero = "";
        DateTime vFecha = DateTime.Now;


        //Vectores Globales
        public string[] VecTelefono = new string[5];
        public string[] VecContacto = new string[5];
        public static string[] vecContactos = new string[5];
        int indice;
        int vContador = 0;

        
        
        
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
            if (mtbNumerodeTelefono.MaskFull) 
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled=false;
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            
        }

        // += le agregamos algo a la variable que está ahi

        private void txtNombredelContacto_TextChanged(object sender, EventArgs e)
        {
            if (txtNombredelContacto.Text == "")
            {
                btnRegistrar.Enabled = false;
            }
            else
            {
                btnRegistrar.Enabled = true;
            }
        }

        //! es una negación, es decir, esta haciendo la misma operación que == false
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombredelContacto.Text == "")
            {
                MessageBox.Show("Complete el campo Contacto");
            }
            else if (!mtbNumerodeTelefono.MaskFull)
            {
                MessageBox.Show("Complete el campo");
            }
            else
            {


                vContacto = txtNombredelContacto.Text;
                vNumero = mtbNumerodeTelefono.Text;
                //vFecha = dtpFecha.Value;



                lstResultados.Items.Add("Contacto: " + vContacto
                    + "Numero:"
                    + vNumero + '\n');
                //Borro los datos
                txtNombredelContacto.Text = "";
                mtbNumerodeTelefono.Text = "";

                MessageBox.Show(vContacto + vNumero);
            }
        }


        private void mtbNumerodeTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btmBorrar_Click(object sender, EventArgs e)
        {
            txtNombredelContacto.Text = "";
            mtbNumerodeTelefono.Text = "";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            frmContactos verContactos = new frmContactos(VecContacto, VecTelefono);
        }
    }
}
