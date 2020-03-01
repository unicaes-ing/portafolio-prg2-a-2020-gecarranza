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

namespace Practica2
{
	public partial class frmUsuario : Form
	{
		public frmUsuario()
		{
			InitializeComponent();
		}

		private void mtxCorreo_Validating(object sender, CancelEventArgs e)
		{
			Regex correo = new Regex("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([.]\\w+)*");
			if (!correo.IsMatch(mtxCorreo.Text))
			{
				e.Cancel = true;
				mtxCorreo.SelectAll();
				errCorreo.SetError(mtxCorreo, "Ingrese un correo valido");
			}
		}

		private void mtxCorreo_Validated(object sender, EventArgs e)
		{
			errCorreo.Clear();
		}

		private void mtxContraseña_Validating(object sender, CancelEventArgs e)
		{
			Regex contra = new Regex("^(?=\\w*\\d)(?=\\w*[A-Z])(?=\\w*[a-z])\\S{8,8}$");
			if (!contra.IsMatch(mtxContraseña.Text))
			{
				e.Cancel = true;
				mtxContraseña.SelectAll();
				errContra.SetError(mtxContraseña, "Ingrese una contraseña valida");
			}
		}

		private void mtxContraseña_Validated(object sender, EventArgs e)
		{
			errContra.Clear();
		}

		private void mtxConfirma_Validating(object sender, CancelEventArgs e)
		{
			Regex contra = new Regex("^(?=\\w*\\d)(?=\\w*[A-Z])(?=\\w*[a-z])\\S{8,8}$");
			if (!contra.IsMatch(mtxConfirma.Text))
			{
				e.Cancel = true;
				mtxConfirma.SelectAll();
				errConfir.SetError(mtxConfirma, "Ingrese una contraseña valida");
			}
		}

		private void mtxConfirma_Validated(object sender, EventArgs e)
		{
			errConfir.Clear();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (mtxCorreo.Text.Length == 0 || mtxContraseña.Text.Length == 0
				|| mtxConfirma.Text.Length == 0)
			{
				MessageBox.Show("No puede dejar campos vacios", "Sistema", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			else if (mtxContraseña.Text != mtxConfirma.Text)
			{
				MessageBox.Show("Las contraseñas no coinciden", "Sistema", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
				mtxConfirma.Focus();
			}
			else 
			{
				MessageBox.Show("Datos correctos", "Sistema", MessageBoxButtons.OK,
					MessageBoxIcon.None);
			}

		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmUsuario_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
	}
}
