namespace Practica2
{
	partial class frmCompra
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
			this.lblCantidad = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdoCero = new System.Windows.Forms.RadioButton();
			this.rdoCinco = new System.Windows.Forms.RadioButton();
			this.rdoDiez = new System.Windows.Forms.RadioButton();
			this.rdoQuince = new System.Windows.Forms.RadioButton();
			this.rdoVeinte = new System.Windows.Forms.RadioButton();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescuento = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblCantidad
			// 
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidad.Location = new System.Drawing.Point(37, 49);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(63, 16);
			this.lblCantidad.TabIndex = 19;
			this.lblCantidad.Text = "Cantidad";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(106, 47);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(114, 20);
			this.txtCantidad.TabIndex = 20;
			this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(106, 88);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(114, 20);
			this.txtPrecio.TabIndex = 21;
			this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(54, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 16);
			this.label1.TabIndex = 22;
			this.label1.Text = "Precio";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdoVeinte);
			this.groupBox1.Controls.Add(this.rdoQuince);
			this.groupBox1.Controls.Add(this.rdoDiez);
			this.groupBox1.Controls.Add(this.rdoCinco);
			this.groupBox1.Controls.Add(this.rdoCero);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(242, 33);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(133, 182);
			this.groupBox1.TabIndex = 23;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Descuento";
			// 
			// rdoCero
			// 
			this.rdoCero.AutoSize = true;
			this.rdoCero.Location = new System.Drawing.Point(22, 24);
			this.rdoCero.Name = "rdoCero";
			this.rdoCero.Size = new System.Drawing.Size(47, 23);
			this.rdoCero.TabIndex = 0;
			this.rdoCero.TabStop = true;
			this.rdoCero.Text = "0%";
			this.rdoCero.UseVisualStyleBackColor = true;
			// 
			// rdoCinco
			// 
			this.rdoCinco.AutoSize = true;
			this.rdoCinco.Location = new System.Drawing.Point(22, 52);
			this.rdoCinco.Name = "rdoCinco";
			this.rdoCinco.Size = new System.Drawing.Size(47, 23);
			this.rdoCinco.TabIndex = 1;
			this.rdoCinco.TabStop = true;
			this.rdoCinco.Text = "5%";
			this.rdoCinco.UseVisualStyleBackColor = true;
			// 
			// rdoDiez
			// 
			this.rdoDiez.AutoSize = true;
			this.rdoDiez.Location = new System.Drawing.Point(22, 81);
			this.rdoDiez.Name = "rdoDiez";
			this.rdoDiez.Size = new System.Drawing.Size(55, 23);
			this.rdoDiez.TabIndex = 24;
			this.rdoDiez.TabStop = true;
			this.rdoDiez.Text = "10%";
			this.rdoDiez.UseVisualStyleBackColor = true;
			// 
			// rdoQuince
			// 
			this.rdoQuince.AutoSize = true;
			this.rdoQuince.Location = new System.Drawing.Point(22, 110);
			this.rdoQuince.Name = "rdoQuince";
			this.rdoQuince.Size = new System.Drawing.Size(55, 23);
			this.rdoQuince.TabIndex = 25;
			this.rdoQuince.TabStop = true;
			this.rdoQuince.Text = "15%";
			this.rdoQuince.UseVisualStyleBackColor = true;
			// 
			// rdoVeinte
			// 
			this.rdoVeinte.AutoSize = true;
			this.rdoVeinte.Location = new System.Drawing.Point(22, 139);
			this.rdoVeinte.Name = "rdoVeinte";
			this.rdoVeinte.Size = new System.Drawing.Size(55, 23);
			this.rdoVeinte.TabIndex = 26;
			this.rdoVeinte.TabStop = true;
			this.rdoVeinte.Text = "20%";
			this.rdoVeinte.UseVisualStyleBackColor = true;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(106, 126);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 24;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Location = new System.Drawing.Point(106, 260);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 25;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(201, 260);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 26;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(27, 189);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 16);
			this.label2.TabIndex = 27;
			this.label2.Text = "Descuento";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(54, 225);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 16);
			this.label3.TabIndex = 28;
			this.label3.Text = "Total";
			// 
			// txtDescuento
			// 
			this.txtDescuento.Location = new System.Drawing.Point(106, 185);
			this.txtDescuento.Name = "txtDescuento";
			this.txtDescuento.Size = new System.Drawing.Size(114, 20);
			this.txtDescuento.TabIndex = 29;
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(106, 221);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(114, 20);
			this.txtTotal.TabIndex = 30;
			// 
			// frmCompra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(405, 323);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtDescuento);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.lblCantidad);
			this.Name = "frmCompra";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Compra";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdoVeinte;
		private System.Windows.Forms.RadioButton rdoQuince;
		private System.Windows.Forms.RadioButton rdoDiez;
		private System.Windows.Forms.RadioButton rdoCinco;
		private System.Windows.Forms.RadioButton rdoCero;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDescuento;
		private System.Windows.Forms.TextBox txtTotal;
	}
}