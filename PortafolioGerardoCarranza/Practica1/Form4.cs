using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void btnCalcula_Click(object sender, EventArgs e)
		{
			double pre, cant, sub, imp, total;
			pre = Convert.ToDouble(txtPrecio.Text);
			cant = Convert.ToDouble(txtCantidad.Text);
			sub = (pre * cant);
			txtSub.Text = Convert.ToString(sub);
			imp = (sub * 0.13);
			txtImpuesto.Text = Convert.ToString(imp);
			total = (sub + imp);
			txtTotal.Text = Convert.ToString(total);
		}

		private void btnNueva_Click(object sender, EventArgs e)
		{
			cboTitulo.Text = "";
			txtPrecio.Clear();
			txtCantidad.Clear();
			txtSub.Clear();
			txtImpuesto.Clear();
			txtTotal.Clear();
			cboTitulo.Focus();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
