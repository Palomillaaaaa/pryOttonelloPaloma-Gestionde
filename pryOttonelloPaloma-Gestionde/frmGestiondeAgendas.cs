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
        
        DateTime vFecha = DateTime.Now;


        //Vectores Globales

        
        public string[] VecTelefono = new string[5];
        public string[] VecContacto = new string[5];
        public static string[] vecContactos = new string[5];

        //static es que puede ser accedido sin la necesidad de crear una instancia de la clase. 
        //Va a estar compartir la misma información. 
        //Public lo pueden leer todos.

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
            else if (vContador < 5)
            {


                string Contacto = txtNombredelContacto.Text;
                string Telefono = mtbNumerodeTelefono.Text;
                VecTelefono[vContador] = Telefono;
                VecContacto[vContador] = Contacto;
                vContador++;
                //++ Recorre


                //vFecha = dtpFecha.Value;



                lstResultados.Items.Add("Contacto: " + Contacto
                    + "Número:"
                    + Telefono + '\n');
                //Borro los datos
                txtNombredelContacto.Text = "";
                mtbNumerodeTelefono.Text = "";

                MessageBox.Show(Contacto + Telefono);
            }
            else
            {
                MessageBox.Show("Agenda llena");
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
            verContactos.ShowDialog();
        }

        private void lstResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
