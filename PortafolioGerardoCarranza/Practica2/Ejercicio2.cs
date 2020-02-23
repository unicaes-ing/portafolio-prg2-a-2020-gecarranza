using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
	public partial class frmCompra : Form
	{
		public frmCompra()
		{
			InitializeComponent();
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			if (txtCantidad.Text.Length == 0 && txtPrecio.Text.Length == 0)
			{
				MessageBox.Show("No puede dejar ningun campo vacio");
				txtCantidad.Focus();
			}
			else
			{
				double cant = Convert.ToDouble(txtCantidad.Text);
				double pre = Convert.ToDouble(txtPrecio.Text);
				double total, desc, total2;
				if (rdoCero.Checked)
				{
					total = cant * pre;
					txtDescuento.Text = ("Sin descuento");
					txtTotal.Text = string.Format("{0:C2}", total);
				}
				else if (rdoCinco.Checked)
				{
					total = cant * pre;
					desc = (total * 0.05);
					total2 = total - desc;
					txtDescuento.Text = string.Format("{0:C2}", desc);
					txtTotal.Text = string.Format("{0:C2}", total2);
				}
				else if (rdoDiez.Checked)
				{
					total = cant * pre;
					desc = (total * 0.10);
					total2 = total - desc;
					txtDescuento.Text = string.Format("{0:C2}", desc);
					txtTotal.Text = string.Format("{0:C2}", total2);
				}
				else if (rdoQuince.Checked)
				{
					total = cant * pre;
					desc = (total * 0.15);
					total2 = total - desc;
					txtDescuento.Text = string.Format("{0:C2}", desc);
					txtTotal.Text = string.Format("{0:C2}", total2);
				}
				else if (rdoVeinte.Checked)
				{
					total = cant * pre;
					desc = (total * 0.20);
					total2 = total - desc;
					txtDescuento.Text = string.Format("{0:C2}", desc);
					txtTotal.Text = string.Format("{0:C2}", total2);
				}
			}
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtCantidad.Clear();
			txtPrecio.Clear();
			txtDescuento.Clear();
			txtTotal.Clear();
			txtCantidad.Focus();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}

			if (e.KeyChar == '.' && !txtPrecio.Text.Contains("."))
			{
				e.Handled = false;
			}
		}
	}
}
