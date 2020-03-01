namespace Practica2
{
	partial class frmUsuario
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lblCorreo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.mtxCorreo = new System.Windows.Forms.MaskedTextBox();
			this.mtxContraseña = new System.Windows.Forms.MaskedTextBox();
			this.mtxConfirma = new System.Windows.Forms.MaskedTextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.errCorreo = new System.Windows.Forms.ErrorProvider(this.components);
			this.errContra = new System.Windows.Forms.ErrorProvider(this.components);
			this.errConfir = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errCorreo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errContra)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errConfir)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCorreo
			// 
			this.lblCorreo.AutoSize = true;
			this.lblCorreo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCorreo.Location = new System.Drawing.Point(26, 40);
			this.lblCorreo.Name = "lblCorreo";
			this.lblCorreo.Size = new System.Drawing.Size(49, 16);
			this.lblCorreo.TabIndex = 21;
			this.lblCorreo.Text = "Correo";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 16);
			this.label1.TabIndex = 22;
			this.label1.Text = "Contraseña";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 32);
			this.label2.TabIndex = 23;
			this.label2.Text = "Confirmación \r\nde contraseña";
			// 
			// mtxCorreo
			// 
			this.mtxCorreo.Location = new System.Drawing.Point(131, 38);
			this.mtxCorreo.Name = "mtxCorreo";
			this.mtxCorreo.Size = new System.Drawing.Size(266, 20);
			this.mtxCorreo.TabIndex = 24;
			this.mtxCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.mtxCorreo_Validating);
			this.mtxCorreo.Validated += new System.EventHandler(this.mtxCorreo_Validated);
			// 
			// mtxContraseña
			// 
			this.mtxContraseña.Location = new System.Drawing.Point(131, 82);
			this.mtxContraseña.Name = "mtxContraseña";
			this.mtxContraseña.PasswordChar = '*';
			this.mtxContraseña.Size = new System.Drawing.Size(118, 20);
			this.mtxContraseña.TabIndex = 25;
			this.mtxContraseña.Validating += new System.ComponentModel.CancelEventHandler(this.mtxContraseña_Validating);
			this.mtxContraseña.Validated += new System.EventHandler(this.mtxContraseña_Validated);
			// 
			// mtxConfirma
			// 
			this.mtxConfirma.Location = new System.Drawing.Point(131, 125);
			this.mtxConfirma.Name = "mtxConfirma";
			this.mtxConfirma.PasswordChar = '*';
			this.mtxConfirma.Size = new System.Drawing.Size(118, 20);
			this.mtxConfirma.TabIndex = 26;
			this.mtxConfirma.Validating += new System.ComponentModel.CancelEventHandler(this.mtxConfirma_Validating);
			this.mtxConfirma.Validated += new System.EventHandler(this.mtxConfirma_Validated);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Location = new System.Drawing.Point(131, 184);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 27;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(225, 184);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 28;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// errCorreo
			// 
			this.errCorreo.ContainerControl = this;
			// 
			// errContra
			// 
			this.errContra.ContainerControl = this;
			// 
			// errConfir
			// 
			this.errConfir.ContainerControl = this;
			// 
			// frmUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(467, 232);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.mtxConfirma);
			this.Controls.Add(this.mtxContraseña);
			this.Controls.Add(this.mtxCorreo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblCorreo);
			this.Name = "frmUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Datos de usuario";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUsuario_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.errCorreo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errContra)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errConfir)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCorreo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox mtxCorreo;
		private System.Windows.Forms.MaskedTextBox mtxContraseña;
		private System.Windows.Forms.MaskedTextBox mtxConfirma;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.ErrorProvider errCorreo;
		private System.Windows.Forms.ErrorProvider errContra;
		private System.Windows.Forms.ErrorProvider errConfir;
	}
}