using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryOttonelloPaloma_Gestionde
{
    public partial class frmContactos : Form
    {
       
     

        public frmContactos( string[] Contactos, string[] Telefono)
        {
           InitializeComponent();
        }

        int indice= 0;
        public string []VecContacto = new string[5]; 

        private void lblMostrar_Click(object sender, EventArgs e)
        {
           

            //llamo al otro formulario

            

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            indice--;
            if (indice < 0)
            {
                lblMostrar.Text = VecContacto[indice];
            }
            
        }

        private void frmContactos_Load(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indice++;
            if (indice <5)
            {
                lblMostrar.Text = VecContacto[indice];
            }
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
