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
	public partial class frmInversionistas : Form
	{
		public frmInversionistas()
		{
			InitializeComponent();
		}

		private void btnCal_Click(object sender, EventArgs e)
		{
			try
			{
				double n1, n2, n3, p1, p2, p3, porc;
				n1 = Convert.ToDouble(txtInv1.Text);
				n2 = Convert.ToDouble(txtInv2.Text);
				n3 = Convert.ToDouble(txtInv3.Text);
				porc = (n1 + n2 + n3);

				p1 = (n1 * 100 / porc);
				p2 = (n2 * 100 / porc);
				p3 = (n3 * 100 / porc);

				txtTotal.Text = Convert.ToString(porc);
				txtPor1.Text = Convert.ToString(p1);
				txtPor2.Text = Convert.ToString(p2);
				txtPor3.Text = Convert.ToString(p3);
			}
			catch (Exception)
			{

				MessageBox.Show("Error");
			}
		}

		private void btnLim_Click(object sender, EventArgs e)
		{
			txtInv1.Clear();
			txtInv2.Clear();
			txtInv3.Clear();
			txtPor1.Clear();
			txtPor2.Clear();
			txtPor3.Clear();
			txtTotal.Clear();
			txtInv1.Focus();
		}

		private void btnSal_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
