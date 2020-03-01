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
	public partial class frmFibonacci : Form
	{
		public frmFibonacci()
		{
			InitializeComponent();
		}
		public static int Fibonacci(int n)
		{
			if (n == 1 || n == 0)
			{
				return n;
			}
			else
			{
				return Fibonacci(n - 1) + Fibonacci(n - 2);
			}
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			try
			{
				int nm = Convert.ToInt32(txtNumero.Text);
				for (int nu = 0; nu <= nm - 1; nu++)
				{
					txtFibonacci.Text = string.Format("{0}", Fibonacci(nu));
				}
				txtNumero.Clear();
				txtNumero.Focus();
			}
			catch (Exception)
			{
				MessageBox.Show("Ingrese un número correcto", "Sistema", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);

			}
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtFibonacci.Clear();
			txtNumero.Focus();
		}
	}
}
