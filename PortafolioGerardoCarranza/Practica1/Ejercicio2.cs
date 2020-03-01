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
	public partial class frmSistemas : Form
	{
		public frmSistemas()
		{
			InitializeComponent();
		}

		private void btnCal_Click(object sender, EventArgs e)
		{
			try
			{
				int dec = Convert.ToInt32(txtDecimal.Text);
				txtBinario.Text = Convert.ToString(dec, 2);
				txtOctal.Text = Convert.ToString(dec, 8);
				txtHexa.Text = Convert.ToString(dec, 16);
			}
			catch (Exception)
			{

				MessageBox.Show("Error");
			}
		}

		private void btnLim_Click(object sender, EventArgs e)
		{
			txtDecimal.Clear();
			txtBinario.Clear();
			txtOctal.Clear();
			txtHexa.Clear();
			txtDecimal.Focus();
		}

		private void btnSal_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
