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
	public partial class frmMayor : Form
	{
		public frmMayor()
		{
			InitializeComponent();
		}
		public static int Mayor(int n1, int n2)
		{
			if (n1 < n2)
			{
				return n2;
			}
			else
			{
				return n1;
			}
		}
		public static int Mayor(int n1, int n2, int n3)
		{
			if (n1 > n2 && n1 > n3)
			{
				return n1;
			}
			else if (n2 > n1 && n2 > n3)
			{
				return n2;
			}
			else
			{
				return n3;
			}
		}

		private void btnMayor_Click(object sender, EventArgs e)
		{
			try
			{
				int nu1 = Convert.ToInt32(txtNumero1.Text);
				int nu2 = Convert.ToInt32(txtNumero2.Text);
				lblMayor.Text = string.Format("{0}", Mayor(nu1, nu2));
				if (!string.IsNullOrEmpty(txtNumero3.Text))
				{
					int num3 = Convert.ToInt32(txtNumero3.Text);
					lblMayor.Text = string.Format("{0}", Mayor(nu1, nu2, num3));
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Ingrese los caracteres correctos", "Sistema", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
		}
	}
}
