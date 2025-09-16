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
    public partial class frmContactos : Form
    {
        public frmContactos()
        {
            InitializeComponent();
        }

        //D eclaración de Variables

        string[] VecNombre = new string[3];
        int indice = 0;
        private void lblMostrar_Click(object sender, EventArgs e)
        {
            VecNombre[0] = "Matias";
            VecNombre[1] = "Iñaki";
            VecNombre[2] = "Mateo";

            lblMostrar.Text = VecNombre[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            indice++;
            lblMostrar.Text = VecNombre[indice];
        }

        private void frmContactos_Load(object sender, EventArgs e)
        {

        }

        private void btmSiguiente_Click(object sender, EventArgs e)
        {

        }
    }
}
