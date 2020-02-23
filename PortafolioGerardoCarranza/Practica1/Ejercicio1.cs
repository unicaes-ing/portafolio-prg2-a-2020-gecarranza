using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
	public partial class frmPromedio : Form
	{
		public frmPromedio()
		{
			InitializeComponent();
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			double exam1, exam2, exam3, promedio;
			exam1 = Convert.ToDouble(txtExam1.Text);
			exam2 = Convert.ToDouble(txtExam2.Text);
			exam3 = Convert.ToDouble(txtExam3.Text);
			promedio = ((exam1 + exam2 + exam3) / 3);
			txtProm.Text = Convert.ToString(promedio);
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtExam1.Clear();
			txtExam2.Clear();
			txtExam3.Clear();
			txtProm.Clear();
			txtExam1.Focus();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
