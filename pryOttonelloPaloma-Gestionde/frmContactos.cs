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
       
     

        public frmContactos()
        {
           InitializeComponent();
        }


        public string[] PasarDatos;
        int indice= 0;
       

        private void lblMostrar_Click(object sender, EventArgs e)
        {
           

            //llamo al otro formulario
            //lblMostrar.Text = frmGestiondeAgendas.VecVerContactos[indice];

            

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
           
            
        }

        private void frmContactos_Load(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            if (indice <5)
            {
                btnAtras.Enabled = true;
                lblMostrar.Text = PasarDatos[indice];
                indice++;
            }
            else
            {
                btnSiguiente.Enabled=false;
                indice--;
            }
            
            
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            

            if (indice >= 0)
            {
                btnSiguiente.Enabled = true;

                lblMostrar.Text = PasarDatos[indice];
                indice--;
            }
            else
            {
                btnAtras.Enabled = false;
                indice++;
            }
        }
    }
}
