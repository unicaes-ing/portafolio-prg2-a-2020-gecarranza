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
	public partial class frmBuscar : Form
	{
		public frmBuscar()
		{
			InitializeComponent();
		}

		private void frmBuscar_Load(object sender, EventArgs e)
		{
			dgvBuscar.Size = new Size(210, 220);
			dgvBuscar.AllowUserToAddRows = false;
			dgvBuscar.ScrollBars = ScrollBars.None;
			dgvBuscar.ColumnCount = 10;
			dgvBuscar.ColumnHeadersVisible = false;
			dgvBuscar.RowHeadersVisible = false;
			dgvBuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			Random num = new Random();
			for (int x = 0; x < 10; x++)
			{
				dgvBuscar.Rows.Add();
				for (int y = 0; y < 10; y++)
				{
					dgvBuscar.Rows[x].Cells[y].Value = num.Next(10, 100);
				}
				dgvBuscar.ClearSelection();
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			int n;
			if (int.TryParse(txtBuscar.Text, out n))
			{
				for (int nu = 0; nu < 10; nu++)
				{
					for (int n2 = 0; n2 < 10; n2++)
					{
						string cant;
						cant = dgvBuscar.Rows[nu].Cells[n2].Value.ToString();
						if (n == Convert.ToInt32(cant))
						{
							dgvBuscar.Rows[nu].Cells[n2].Style.BackColor = Color.Yellow;
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Ingrese un número valido", "Sistema", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
			}
		}
	}
}
