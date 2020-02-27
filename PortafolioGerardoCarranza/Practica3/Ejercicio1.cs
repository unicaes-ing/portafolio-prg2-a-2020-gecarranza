using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
	public partial class frmTablas : Form
	{
		public frmTablas()
		{
			InitializeComponent();
		}

		private void btnGenerar_Click(object sender, EventArgs e)
		{
			lstTabla.Items.Clear();
			int nu;
			if (int.TryParse(txtTabla.Text, out nu))
			{
				for (int i = 1; i <= 10; i++)
				{
					lstTabla.Items.Add(nu + "  x  " + i + "     =     " + nu * i);
				}
			}
			else
			{
				MessageBox.Show("Ingrese un número de tabla", "Sistema", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
		}
	}
}
