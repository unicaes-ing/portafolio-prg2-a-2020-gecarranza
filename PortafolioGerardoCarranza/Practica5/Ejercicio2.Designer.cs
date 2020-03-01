namespace Practica4
{
	partial class frmLista
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
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lstNumero = new System.Windows.Forms.ListBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnBuscar
			// 
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Location = new System.Drawing.Point(261, 296);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(94, 28);
			this.btnBuscar.TabIndex = 20;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtNumero2
			// 
			this.txtNumero2.Location = new System.Drawing.Point(261, 270);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(94, 20);
			this.txtNumero2.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(258, 250);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 17);
			this.label2.TabIndex = 18;
			this.label2.Text = "Número ";
			// 
			// lstNumero
			// 
			this.lstNumero.FormattingEnabled = true;
			this.lstNumero.Location = new System.Drawing.Point(37, 78);
			this.lstNumero.Name = "lstNumero";
			this.lstNumero.Size = new System.Drawing.Size(198, 264);
			this.lstNumero.TabIndex = 17;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Location = new System.Drawing.Point(250, 31);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(84, 30);
			this.btnAgregar.TabIndex = 16;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// txtNumero1
			// 
			this.txtNumero1.Location = new System.Drawing.Point(102, 33);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(133, 20);
			this.txtNumero1.TabIndex = 15;
			this.txtNumero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero1_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(34, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 17);
			this.label1.TabIndex = 14;
			this.label1.Text = "Número ";
			// 
			// frmLista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(382, 388);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lstNumero);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtNumero1);
			this.Controls.Add(this.label1);
			this.Name = "frmLista";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lista";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtNumero2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lstNumero;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txtNumero1;
		private System.Windows.Forms.Label label1;
	}
}