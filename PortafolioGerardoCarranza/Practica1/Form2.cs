﻿using System;
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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void btnCal_Click(object sender, EventArgs e)
		{
			int dec = Convert.ToInt32(txtDecimal.Text);
			txtBinario.Text = Convert.ToString(dec, 2);
			txtOctal.Text = Convert.ToString(dec, 8);
			txtHexa.Text = Convert.ToString(dec, 16);
		}

		private void btnLim_Click(object sender, EventArgs e)
		{
			txtDecimal.Clear();
			txtBinario.Clear();
			txtOctal.Clear();
			txtHexa.Clear();
			txtDecimal.Focus();
		}

		private void btnSal_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
