using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Practica3
{
	public partial class frmPlanilla : Form
	{
		public frmPlanilla()
		{
			InitializeComponent();
		}
		private decimal sub = 0, total1 = 0, total = 0, imp = 0;

		private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			try
			{
				bool valido = true;

				string nom = Convert.ToString(txtNombre.Text);
				int hora = Convert.ToInt32(txtHoras.Text);
				decimal valor = Convert.ToDecimal(txtValor.Text);

				if (valido)
				{
					sub = hora * valor;
					imp = (sub * 0.10m);
					total1 = sub + (sub * 0.10m);
					total += sub + imp;
					dgvPlanilla.Rows.Add(nom, hora, "$ " + valor, "$ " + sub, "$ " + imp, "$ " + total);

					lblTotal.Text = string.Format("{0:C2}", total); ;

					txtNombre.Clear();
					txtHoras.Clear();
					txtValor.Clear();
					txtNombre.Focus();
				}
				
			}
			catch (Exception)
			{

				MessageBox.Show("No puede dejar casillas vacias.", "Sistema", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				txtNombre.Clear();
				txtHoras.Clear();
				txtValor.Clear();
				txtNombre.Focus();
			}
		}
		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			dgvPlanilla.Rows.Clear();
		}
	}
}
