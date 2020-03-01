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
	public partial class frmLista : Form
	{
		public frmLista()
		{
			InitializeComponent();
		}
		public static int Buscar(int num, params string[] numeros)
		{
			int busca = 0;
			foreach (string numero in numeros)
			{
				if (Convert.ToInt32(numero) == num)
				{
					busca++;
				}
			}
			return busca;
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			if (txtNumero1.Text.Length == 0)
			{
				MessageBox.Show("Ingrese un número valido", "Sistema", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			else
			{
				lstNumero.Items.Add(txtNumero1.Text);
				txtNumero1.Clear();
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			try
			{
				int n = Convert.ToInt32(txtNumero2.Text);
				int busca;
				string[] nu = new string[lstNumero.Items.Count];
				lstNumero.Items.CopyTo(nu, 0);
				busca = Buscar(n, nu);
				MessageBox.Show("El número " + n + " se encontro " + busca + " veces.");
			}
			catch (Exception)
			{

				MessageBox.Show("Debe ser un número", "Error", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
		}

		private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
