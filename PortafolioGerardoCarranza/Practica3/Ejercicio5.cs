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

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			try
			{
				string nom = Convert.ToString(txtNombre.Text);
				int h = Convert.ToInt32(txtHoras.Text);
				double v = Convert.ToDouble(txtValor.Text);
				double sub, total, iva;
				sub = h * v;
				iva = sub * 0.10;
				total = sub + iva;
				dgvPlanilla.Rows.Add(nom, h, "$ " + v, "$ " + sub, "$ " + iva, "$ " + total);
				total = 0;
				foreach (DataGridViewRow celda in dgvPlanilla.Rows)
				{
					total += Convert.ToDouble(celda.Cells["Total"].Value);
					lblTotal.Text = total.ToString();
				}
				txtNombre.Clear();
				txtHoras.Clear();
				txtValor.Clear();
				txtNombre.Focus();
			}
			catch (Exception)
			{

				MessageBox.Show("Empleado agregado.");
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
