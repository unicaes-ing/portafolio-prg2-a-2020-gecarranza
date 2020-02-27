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
	public partial class frmLongitud : Form
	{
		public frmLongitud()
		{
			InitializeComponent();
		}

		private void btnCconvertir_Click(object sender, EventArgs e)
		{
			try
			{
				if (lstConver1.SelectedIndex.Equals(-1) && lstConver2.SelectedIndex.Equals(-1))
				{
					MessageBox.Show("Debe seleccionar las longitudes a convertir", "Sistema", MessageBoxButtons.OK, 
						MessageBoxIcon.Exclamation);
					txtEntrada.Focus();
				}
				else
				{
					double longitud = Convert.ToDouble(txtEntrada.Text);
					double total;
					if (lstConver1.Text == "Pulgadas" && lstConver2.Text == "Pulgadas")
					{
						total = longitud * 1;
						txtResultado.Text = string.Format("{0}", total);
					}
					else if (lstConver1.Text == "Pulgadas" && lstConver2.Text == "Pies")
					{
						total = longitud * 0.833333;
						txtResultado.Text = string.Format("{0:N2}", total);
					}
					else if (lstConver1.Text == "Pulgadas" && lstConver2.Text == "Yardas")
					{
						total = longitud * 0.0277777666667;
						txtResultado.Text = string.Format("{0:N2}", total);
					}
					else if (lstConver1.Text == "Pies" && lstConver2.Text == "Pulgadas")
					{
						total = longitud * 12;
						txtResultado.Text = string.Format("{0}", total);
					}
					else if (lstConver1.Text == "Pies" && lstConver2.Text == "Pies")
					{
						total = longitud * 1;
						txtResultado.Text = string.Format("{0}", total);
					}
					else if (lstConver1.Text == "Pies" && lstConver2.Text == "Yardas")
					{
						total = longitud * 0.333333;
						txtResultado.Text = string.Format("{0:N2}", total);
					}
					else if (lstConver1.Text == "Yardas" && lstConver2.Text == "Pulgadas")
					{
						total = longitud * 36;
						txtResultado.Text = string.Format("{0}", total);
					}
					else if (lstConver1.Text == "Yardas" && lstConver2.Text == "Pies")
					{
						total = longitud * 3;
						txtResultado.Text = string.Format("{0}", total);
					}
					else if (lstConver1.Text == "Yardas" && lstConver2.Text == "Yardas")
					{
						total = longitud * 1;
						txtResultado.Text = string.Format("{0}", total);
					}
				}
			}
			catch (Exception)
			{

				MessageBox.Show("Ingrese un caracter valido", "Sistema", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				txtEntrada.Focus();
			}
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
