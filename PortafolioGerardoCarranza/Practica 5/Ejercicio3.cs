using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5
{
	public partial class frmSucursales : Form
	{
		public frmSucursales()
		{
			InitializeComponent();
		}

		String[][] Venta = new string[5][];
		private void frmSucursales_Load(object sender, EventArgs e)
		{
			Venta[0] = new string[5] { "600", "1000", "800", "1340", "450"};
			Venta[1] = new string[2] { "190", "980" };
			Venta[2] = new string[1] { "2350" };
			Venta[3] = new string[4] { "1000", "190", "740", "2050" };
			Venta[4] = new string[3] { "325", "700", "1021" };
			lstUno.Items.Clear();
			for (int v = 0; v < Venta.GetLength(0); v++)
			{
				lstUno.Items.Add("Sucursal " + (v + 1));
			}
		}

		private void lstUno_SelectedIndexChanged(object sender, EventArgs e)
		{
			int suma = 0;
			if (lstUno.SelectedIndex >= 0)
			{
				lstDos.Items.Clear();
				foreach (string Venta in
			   Venta[lstUno.SelectedIndex])
				{
					lstDos.Items.Add(Venta);
					suma += Convert.ToInt32(Venta);
				}
				lblTotal.Text = string.Format("$ {0}", suma);
			}
		}
	}
}
