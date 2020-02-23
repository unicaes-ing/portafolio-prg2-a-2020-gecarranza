using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PRACTICA_PARA_EXAMEN
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
		{
			Regex formato = new Regex("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");
			if (!formato.IsMatch(maskedTextBox1.Text))
			{
				e.Cancel = true;
				maskedTextBox1.SelectAll();
				errorEmail.SetError(maskedTextBox1, "Ingrese un correo valido");

			}
		}

		private void maskedTextBox1_Validated(object sender, EventArgs e)
		{
			errorEmail.Clear();
		}

		private void txtNombreCompleto_Validating(object sender, CancelEventArgs e)
		{
			Regex format = new Regex("[a-zA-ZñÑ\\s]{2,50}");
			if (!format.IsMatch(txtNombreCompleto.Text))
			{
				e.Cancel = true;
				txtNombreCompleto.SelectAll();
			    errorNombre.SetError(txtNombreCompleto, "Ingrese el nombrecorrectamente");
			}
		}

		private void txtNombreCompleto_Validated(object sender, EventArgs e)
		{
			errorNombre.Clear();
		}

		private void txtNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (char.IsSeparator(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else 
			{
				e.Handled = true;
			}
		}

		private void maskedFechaNac_Validating(object sender, CancelEventArgs e)
		{
			Regex formto = new Regex("^([0-2][0-9]|3[0-1])(\\/|-)(0[1-9]|1[0-2])\\2(\\d{4})$");
			if (!formto.IsMatch(maskedFechaNac.Text))
			{
				e.Cancel = true;
				maskedFechaNac.SelectAll();
				errorNombre.SetError(maskedFechaNac, "Ingrese fecha en formato DD/MM/AAAA");
			}
		}

		private void maskedFechaNac_Validated(object sender, EventArgs e)
		{
			errorNombre.Clear();
		}

		private void maskedFechaNac_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsNumber(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void maskedTextBox4_Validating(object sender, CancelEventArgs e)
		{
			Regex Format = new Regex("^([0-9]{8})-([0-9]{1})$");
			if (!Format.IsMatch(maskedTextBox4.Text))
			{
				e.Cancel = true;
				maskedTextBox4.SelectAll();
				errorDui.SetError(maskedTextBox4, "Ingrese un numero de Dui valido");
			}
		}

		private void maskedTextBox4_Validated(object sender, EventArgs e)
		{
			errorDui.Clear();
		}

		private void maskedTextBox3_Validating(object sender, CancelEventArgs e)
		{
			Regex formato = new Regex("^([0-9]{4})-([0-9]{6})-([0-9]{3})-([0-9]{1})$");
			if (!formato.IsMatch(maskedTextBox3.Text))
			{
				e.Cancel = true;
				maskedTextBox3.SelectAll();
				errorNit.SetError(maskedTextBox3, "Ingrese un numero de Nit valido");
			}
		}

		private void maskedTextBox3_Validated(object sender, EventArgs e)
		{
			errorNit.Clear();
		}

		private void maskedTextBox2_Validating(object sender, CancelEventArgs e)
		{
			Regex formato = new Regex("^([6-7]{1}[0-9]{3})-([0-9]{4})$");
			if (!formato.IsMatch(maskedTextBox2.Text))
			{
				e.Cancel = true;
				maskedTextBox2.SelectAll();
				errorTel.SetError(maskedTextBox2, "Ingrese un numero de telefono valido");
			}
		}

		private void maskedTextBox2_Validated(object sender, EventArgs e)
		{
			errorTel.Clear();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (txtNombreCompleto.Text.Length == 0 || 
				maskedFechaNac.Text.Length == 0 || maskedTextBox1.Text.Length == 0 ||
				maskedTextBox2.Text.Length == 0 || maskedTextBox3.Text.Length == 0 ||
				maskedTextBox4.Text.Length == 0)
			{
				MessageBox.Show("Faltan campos por llenar");
			}
			else
			{
				MessageBox.Show("Datos correctos");
			}
		}
	}
}
