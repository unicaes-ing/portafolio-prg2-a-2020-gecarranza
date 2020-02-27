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
	public partial class frmRomano : Form
	{
		public frmRomano()
		{
			InitializeComponent();
		}

		private void btnConvertir_Click(object sender, EventArgs e)
		{
			if (txtNumero.Text.Length == 0)
			{
				MessageBox.Show("No puede dejar el campo vacio", "Sistema", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			else
			{
				int num = Convert.ToInt32(txtNumero.Text);
				string res;
				string[] rom = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
				int u = num % 10;
				if (num <= 10)
				{
					res = (rom[num]);
					lblRomano.Text = string.Format("Equivale a " + res + " en romano.");
				}
				else
				{
					MessageBox.Show("Ingrese un numero entre 1 y 10");
				}
			}
		}
		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
