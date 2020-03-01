using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5
{
	public partial class frmNumeros : Form
	{
		public frmNumeros()
		{
			InitializeComponent();
		}

		public static int Suma(int n1, int n2, int n3, int n4)
		{
			int total;
			total = n1 + n2 + n3 + n4;
			return total;

		}

		private void btnSumar_Click(object sender, EventArgs e)
		{
			try
			{
				int nu1 = Convert.ToInt32(txtNumero1.Text);
				int nu2 = Convert.ToInt32(txtNumero2.Text);
				int nu3 = Convert.ToInt32(txtNumero3.Text);
				int nu4 = Convert.ToInt32(txtNumero4.Text);
				int suma;
				suma = Suma(nu1, nu2, nu3, nu4);
				lblSuma.Text = string.Format("{0}", suma);
			}
			catch (Exception)
			{
				MessageBox.Show("Ingrese algun numero valio", "Sistema", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
		}
	}
}
