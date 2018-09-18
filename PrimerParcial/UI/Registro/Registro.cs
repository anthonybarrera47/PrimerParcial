using PrimerParcial.BLL;
using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial.UI.Registro
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            errorProvider.Clear();
            vendedorIDNumericUpDown.Value = 0;
            nombresTextBox.Text = string.Empty;
            sueldoNumericUpDown.Value = Convert.ToDecimal(0);
            retencionPorcentajeNumericUpDown.Value = Convert.ToDecimal(0);
            retencionCalculoTextBox.Text = string.Empty;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private Vendedor LlenaClase()
        {
            Vendedor vendedor = new Vendedor()
            {
                vendedorID = Convert.ToInt32(vendedorIDNumericUpDown.Value),
                Nombres = nombresTextBox.Text,
                Sueldo = Convert.ToDouble(sueldoNumericUpDown.Value),
                RetencionPorcentaje = Convert.ToSingle(retencionPorcentajeNumericUpDown.Value),
                RetencionCalculo = retencionCalculoTextBox.Text

            };
            return vendedor;
        }
        private void LlenaCampo(Vendedor vendedor)
        {
            vendedorIDNumericUpDown.Value = vendedor.vendedorID;
            nombresTextBox.Text = vendedor.Nombres;
            sueldoNumericUpDown.Value = Convert.ToDecimal(vendedor.Sueldo);
            retencionPorcentajeNumericUpDown.Value = Convert.ToDecimal(vendedor.RetencionPorcentaje);
            retencionCalculoTextBox.Text = Convert.ToString(vendedor.RetencionCalculo);
        }
        private bool Validar()
        {
            bool paso = true;

            if(String.IsNullOrWhiteSpace(nombresTextBox.Text))
            {
                errorProvider.SetError(nombresTextBox, "Este Campo No puede Estar Vacio!!");
                paso = false;
            }
            if(sueldoNumericUpDown.Value == 0)
            {
                errorProvider.SetError(sueldoNumericUpDown, "Este Campo No puede Ser Cero");
                paso = false;
            }
            if(retencionPorcentajeNumericUpDown.Value == 0)
            {
                errorProvider.SetError(retencionPorcentajeNumericUpDown, "Este Campo No puede Ser Cero");
                paso = false;
            }
           
            return paso;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Vendedor vendedor = VendedorBLL.Buscar((int)vendedorIDNumericUpDown.Value);
            return (vendedor != null);
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Vendedor vendedor;
            bool paso = false;
            if (!Validar())
                return;

            vendedor = LlenaClase();
            if (vendedorIDNumericUpDown.Value == 0)
                paso = VendedorBLL.Guardar(vendedor);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    return;
                }
                paso = VendedorBLL.Modificar(vendedor);
            }
            if(paso)
            {
                MessageBox.Show("Vendedor Guardado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int id;
            int.TryParse(vendedorIDNumericUpDown.Text, out id);

            if(!ExisteEnLaBaseDeDatos())
            {
                errorProvider.SetError(vendedorIDNumericUpDown, "No puedes Borrar Un Vendedor Inexistente");
                return;
            }
            if(VendedorBLL.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Vendedor Eliminado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Vendedor vendedor = new Vendedor();
            int.TryParse(vendedorIDNumericUpDown.Text, out id);

            vendedor = VendedorBLL.Buscar(id);

            if(vendedor!=null)
            {
                errorProvider.Clear();
                LlenaCampo(vendedor);
                MessageBox.Show("Vendedor Encontrado!!!", "Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Vendedor no Encontrado!!!", "Fallo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void sueldoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Double sueldo = Convert.ToDouble(sueldoNumericUpDown.Value);
            float retencion = Convert.ToSingle(retencionPorcentajeNumericUpDown.Value);

            retencion /= 100;

            Double Total = sueldo * retencion;
            retencionCalculoTextBox.Text = Convert.ToString(Math.Round(Total, 3));

        }

        private void retencionPorcentajeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Double sueldo = Convert.ToDouble(sueldoNumericUpDown.Value);
            float retencion = Convert.ToSingle(retencionPorcentajeNumericUpDown.Value);

            retencion /= 100;

            Double Total = sueldo * retencion;
            retencionCalculoTextBox.Text = Convert.ToString(Math.Round(Total,3));
        }

        private void nombresTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
