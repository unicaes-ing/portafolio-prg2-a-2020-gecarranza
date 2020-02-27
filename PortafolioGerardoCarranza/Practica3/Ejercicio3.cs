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
			int dado = 0, conta = 0, n6 = 0;
			Random num = new Random();
			lstLanzar.Items.Clear();
			const int lanzar = 5000;
			while (conta < lanzar)
			{
				dado = num.Next(1, 15);
				conta++;
				lstLanzar.Items.Add(dado);
				if (dado == 6)
				{
					n6++;
				}
			}
			MessageBox.Show("el numero 6 se obtubo " + n6 + " veces","Resultado", MessageBoxButtons.OK,
					MessageBoxIcon.None);
		}
	}
}
