namespace Practica2
{
	partial class frmLongitud
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
			this.txtEntrada = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lstConver1 = new System.Windows.Forms.ListBox();
			this.lstConver2 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.btnCconvertir = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblCantidad
			// 
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidad.Location = new System.Drawing.Point(32, 50);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(215, 16);
			this.lblCantidad.TabIndex = 20;
			this.lblCantidad.Text = "Introduzca la longitud a convertir";
			// 
			// txtEntrada
			// 
			this.txtEntrada.Location = new System.Drawing.Point(253, 48);
			this.txtEntrada.Name = "txtEntrada";
			this.txtEntrada.Size = new System.Drawing.Size(114, 20);
			this.txtEntrada.TabIndex = 21;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lstConver1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(35, 96);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 133);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "De";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lstConver2);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(282, 96);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 133);
			this.groupBox2.TabIndex = 23;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "a";
			// 
			// lstConver1
			// 
			this.lstConver1.FormattingEnabled = true;
			this.lstConver1.ItemHeight = 19;
			this.lstConver1.Items.AddRange(new object[] {
            "Pulgadas",
            "Pies",
            "Yardas"});
			this.lstConver1.Location = new System.Drawing.Point(6, 24);
			this.lstConver1.Name = "lstConver1";
			this.lstConver1.Size = new System.Drawing.Size(176, 99);
			this.lstConver1.TabIndex = 24;
			// 
			// lstConver2
			// 
			this.lstConver2.FormattingEnabled = true;
			this.lstConver2.ItemHeight = 19;
			this.lstConver2.Items.AddRange(new object[] {
            "Pulgadas",
            "Pies",
            "Yardas"});
			this.lstConver2.Location = new System.Drawing.Point(6, 24);
			this.lstConver2.Name = "lstConver2";
			this.lstConver2.Size = new System.Drawing.Size(176, 99);
			this.lstConver2.TabIndex = 25;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 267);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 16);
			this.label1.TabIndex = 24;
			this.label1.Text = "Longitud convertida";
			// 
			// txtResultado
			// 
			this.txtResultado.Location = new System.Drawing.Point(196, 265);
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.Size = new System.Drawing.Size(134, 20);
			this.txtResultado.TabIndex = 25;
			// 
			// btnCconvertir
			// 
			this.btnCconvertir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCconvertir.Location = new System.Drawing.Point(172, 330);
			this.btnCconvertir.Name = "btnCconvertir";
			this.btnCconvertir.Size = new System.Drawing.Size(75, 23);
			this.btnCconvertir.TabIndex = 26;
			this.btnCconvertir.Text = "Convertir";
			this.btnCconvertir.UseVisualStyleBackColor = true;
			this.btnCconvertir.Click += new System.EventHandler(this.btnCconvertir_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(272, 330);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 27;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// frmLongitud
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(531, 385);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnCconvertir);
			this.Controls.Add(this.txtResultado);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtEntrada);
			this.Controls.Add(this.lblCantidad);
			this.Name = "frmLongitud";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Conversor";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.TextBox txtEntrada;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox lstConver1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListBox lstConver2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtResultado;
		private System.Windows.Forms.Button btnCconvertir;
		private System.Windows.Forms.Button btnSalir;
	}
}