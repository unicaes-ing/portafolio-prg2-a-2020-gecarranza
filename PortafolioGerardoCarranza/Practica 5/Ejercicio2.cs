using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Practica_5.Matrices;

namespace Practica_5
{
	public partial class frmMatrices : Form
	{
		public frmMatrices()
		{
			InitializeComponent();
		}

		int[,] numeros = new int[5, 5];
		int[,] numeros2 = new int[5, 5];
		private void frmMatrices_Load(object sender, EventArgs e)
		{
			dgvMatrizA.Size = new Size(230, 115);
			dgvMatrizA.ColumnCount = 5;
			dgvMatrizA.AllowUserToAddRows = false;
			dgvMatrizA.ColumnHeadersVisible = false;
			dgvMatrizA.RowHeadersVisible = false;
			dgvMatrizA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			Random a = new Random();
			for (int f = 0; f < numeros.GetLength(0); f++)
			{
				dgvMatrizA.Rows.Add();
				for (int c = 0; c < numeros.GetLength(1); c++)
				{
					numeros[f, c] = a.Next(10, 90);
					dgvMatrizA.Rows[f].Cells[c].Value = numeros[f, c];
				}
			}
			dgvMatrizA.ClearSelection();

			dgvMatrizB.Size = new Size(230, 115);
			dgvMatrizB.ColumnCount = 5;
			dgvMatrizB.AllowUserToAddRows = false;
			dgvMatrizB.ColumnHeadersVisible = false;
			dgvMatrizB.RowHeadersVisible = false;
			dgvMatrizB.AutoSizeColumnsMode =
				DataGridViewAutoSizeColumnsMode.Fill;
			Random al = new Random();
			for (int f2 = 0; f2 < numeros2.GetLength(0); f2++)
			{
				dgvMatrizB.Rows.Add();
				for (int c2 = 0; c2 < numeros2.GetLength(1); c2++)
				{
					numeros2[f2, c2] = al.Next(10, 90);
					dgvMatrizB.Rows[f2].Cells[c2].Value = numeros2[f2, c2];
				}
			}
			dgvMatrizB.ClearSelection();
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			dgvResultado.Size = new Size(230, 115);
			dgvResultado.Rows.Clear();
			dgvResultado.ColumnCount = 5;
			dgvResultado.AllowUserToAddRows = false;
			dgvResultado.RowHeadersVisible = false;
			dgvResultado.ColumnHeadersVisible = false;
			dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			int[,] resul = new int[5, 5];
			resul = (rdoSuma.Checked) ? SumaMatriz(numeros, numeros2, rdoSuma) : MultiplicaMatriz(numeros, numeros2, rdoMultiplicar);
			for (int f = 0; f < resul.GetLength(0); f++)
			{
				dgvResultado.Rows.Add();
				for (int c = 0; c < resul.GetLength(1); c++)
				{
					dgvResultado.Rows[f].Cells[c].Value = resul[f, c];
				}
			}
			dgvResultado.ClearSelection();
		}
	}
}
