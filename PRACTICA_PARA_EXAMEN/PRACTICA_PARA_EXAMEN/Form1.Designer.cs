namespace PRACTICA_PARA_EXAMEN
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
			this.maskedFechaNac = new System.Windows.Forms.MaskedTextBox();
			this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
			this.txtNombreCompleto = new System.Windows.Forms.TextBox();
			this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorDui = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorNit = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorTel = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorDui)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorNit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorTel)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(91, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Fecha de nacimiento";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(109, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "DUI";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(110, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "NIT";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(86, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Telefono";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(42, 210);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Correo electronico";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(183, 254);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 6;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(283, 254);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 7;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(141, 207);
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(354, 20);
			this.maskedTextBox1.TabIndex = 8;
			this.maskedTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox1_Validating);
			this.maskedTextBox1.Validated += new System.EventHandler(this.maskedTextBox1_Validated);
			// 
			// maskedTextBox2
			// 
			this.maskedTextBox2.Location = new System.Drawing.Point(141, 170);
			this.maskedTextBox2.Mask = "0000-0000";
			this.maskedTextBox2.Name = "maskedTextBox2";
			this.maskedTextBox2.Size = new System.Drawing.Size(117, 20);
			this.maskedTextBox2.TabIndex = 9;
			this.maskedTextBox2.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox2_Validating);
			this.maskedTextBox2.Validated += new System.EventHandler(this.maskedTextBox2_Validated);
			// 
			// maskedTextBox3
			// 
			this.maskedTextBox3.Location = new System.Drawing.Point(141, 136);
			this.maskedTextBox3.Mask = "0000-000000-000-0";
			this.maskedTextBox3.Name = "maskedTextBox3";
			this.maskedTextBox3.Size = new System.Drawing.Size(117, 20);
			this.maskedTextBox3.TabIndex = 10;
			this.maskedTextBox3.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox3_Validating);
			this.maskedTextBox3.Validated += new System.EventHandler(this.maskedTextBox3_Validated);
			// 
			// maskedTextBox4
			// 
			this.maskedTextBox4.Location = new System.Drawing.Point(141, 100);
			this.maskedTextBox4.Mask = "00000000-0";
			this.maskedTextBox4.Name = "maskedTextBox4";
			this.maskedTextBox4.Size = new System.Drawing.Size(117, 20);
			this.maskedTextBox4.TabIndex = 11;
			this.maskedTextBox4.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox4_Validating);
			this.maskedTextBox4.Validated += new System.EventHandler(this.maskedTextBox4_Validated);
			// 
			// maskedFechaNac
			// 
			this.maskedFechaNac.Location = new System.Drawing.Point(141, 67);
			this.maskedFechaNac.Mask = "00/00/0000";
			this.maskedFechaNac.Name = "maskedFechaNac";
			this.maskedFechaNac.Size = new System.Drawing.Size(117, 20);
			this.maskedFechaNac.TabIndex = 12;
			this.maskedFechaNac.ValidatingType = typeof(System.DateTime);
			this.maskedFechaNac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedFechaNac_KeyPress);
			this.maskedFechaNac.Validating += new System.ComponentModel.CancelEventHandler(this.maskedFechaNac_Validating);
			this.maskedFechaNac.Validated += new System.EventHandler(this.maskedFechaNac_Validated);
			// 
			// errorEmail
			// 
			this.errorEmail.ContainerControl = this;
			// 
			// txtNombreCompleto
			// 
			this.txtNombreCompleto.Location = new System.Drawing.Point(141, 33);
			this.txtNombreCompleto.Name = "txtNombreCompleto";
			this.txtNombreCompleto.Size = new System.Drawing.Size(354, 20);
			this.txtNombreCompleto.TabIndex = 13;
			this.txtNombreCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCompleto_KeyPress);
			this.txtNombreCompleto.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombreCompleto_Validating);
			this.txtNombreCompleto.Validated += new System.EventHandler(this.txtNombreCompleto_Validated);
			// 
			// errorNombre
			// 
			this.errorNombre.ContainerControl = this;
			// 
			// errorDui
			// 
			this.errorDui.ContainerControl = this;
			// 
			// errorNit
			// 
			this.errorNit.ContainerControl = this;
			// 
			// errorTel
			// 
			this.errorTel.ContainerControl = this;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 304);
			this.Controls.Add(this.txtNombreCompleto);
			this.Controls.Add(this.maskedFechaNac);
			this.Controls.Add(this.maskedTextBox4);
			this.Controls.Add(this.maskedTextBox3);
			this.Controls.Add(this.maskedTextBox2);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorDui)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorNit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorTel)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox2;
		private System.Windows.Forms.MaskedTextBox maskedTextBox3;
		private System.Windows.Forms.MaskedTextBox maskedTextBox4;
		private System.Windows.Forms.MaskedTextBox maskedFechaNac;
		private System.Windows.Forms.ErrorProvider errorEmail;
		private System.Windows.Forms.TextBox txtNombreCompleto;
		private System.Windows.Forms.ErrorProvider errorNombre;
		private System.Windows.Forms.ErrorProvider errorDui;
		private System.Windows.Forms.ErrorProvider errorNit;
		private System.Windows.Forms.ErrorProvider errorTel;
	}
}

