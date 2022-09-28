using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryGarciaBiblioteca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

       

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // que se basa en el resultado que el usuario de cuando se muestre la MessageBox (Resultados de dialogo: Si - No)
            DialogResult s = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Si el resultado del dialogo es Si, la aplicacion se cierra
            if (s == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Muestra al otro formulario 
            frmBiblioteca biblioteca1 = new frmBiblioteca();
            biblioteca1.ShowDialog();
        }
    }
}
