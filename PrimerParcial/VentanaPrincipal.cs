using PrimerParcial.UI.Consulta;
using PrimerParcial.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        

        private void registrarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.MdiParent = this;
            registro.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultaVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarVendedores consultarVendedores = new ConsultarVendedores();
            consultarVendedores.MdiParent = this;
            consultarVendedores.Show();
        }
    }
}
