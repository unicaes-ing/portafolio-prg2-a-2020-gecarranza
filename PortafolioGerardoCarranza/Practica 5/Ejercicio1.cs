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
	public partial class frmVendedores : Form
	{
		public frmVendedores()
		{
			InitializeComponent();
		}

		string[] nombres = {"Gerardo", "Gabriela", "Mariana", "Jose", "Carlos",
							 "Ana","Juan", "Pedro", "Enrique", "Milagro"};
		private void frmVendedores_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < 10; i++)
			{
				lstVendedores.Items.Add(nombres[i]);
			}
		}

		private void btnOrdenarAZ_Click(object sender, EventArgs e)
		{
			lstVendedores.Items.Clear();
			Array.Sort(nombres);
			for (int i = 0; i < 10; i++)
			{
				lstVendedores.Items.Add(nombres[i]);
			}
		}

		private void btnOrdenarZA_Click(object sender, EventArgs e)
		{
			lstVendedores.Items.Clear();
			Array.Reverse(nombres);
			for (int i = 0; i < 10; i++)
			{
				lstVendedores.Items.Add(nombres[i]);
			}
		}

		private void btnQuitar_Click(object sender, EventArgs e)
		{
			lstVendedores.Items.Remove(lstVendedores.SelectedItem);
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			string vendedor = Convert.ToString(txtNombre.Text);
			for (int i = 0; i < 10; i++)
			{
				int lista = lstVendedores.FindString(vendedor);
				if (lista != -1)
				{
					lstVendedores.SetSelected(lista, true);
				}
				else
				{
					MessageBox.Show("Nombre de vendedor no encontrado");
					break;
				}
			}
		}
	}
}
