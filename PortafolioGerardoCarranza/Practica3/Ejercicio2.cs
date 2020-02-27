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
	public partial class frmAlfabeto : Form
	{
		public frmAlfabeto()
		{
			InitializeComponent();
		}

		private void btnMostrar_Click(object sender, EventArgs e)
		{
			lstAlfabeto.Items.Clear();
			for (char let = 'A'; let <= 'Z'; let++)
			{
				lstAlfabeto.Items.Add(let);
			}
		}
	}
}
