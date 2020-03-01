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
	public partial class frmLanza : Form
	{
		public frmLanza()
		{
			InitializeComponent();
		}

		private void btnLanzar_Click(object sender, EventArgs e)
		{
			int d = 0, c = 0, n6 = 0;
			Random numero = new Random();
			lstLanzar.Items.Clear();
			const int lanzar = 5000;
			while (c < lanzar)
			{
				d = numero.Next(1, 15);
				c++;
				lstLanzar.Items.Add(d);
				if (d == 6)
				{
					n6++;
				}
			}
			MessageBox.Show("el numero 6 se obtubo " + n6 + " veces","Resultado", MessageBoxButtons.OKCancel,
					MessageBoxIcon.None);
		}
	}
}
