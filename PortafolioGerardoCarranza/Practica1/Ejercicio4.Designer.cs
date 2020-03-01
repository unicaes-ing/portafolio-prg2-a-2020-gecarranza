namespace Practica1
{
	partial class frmLibreria
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtSub = new System.Windows.Forms.TextBox();
			this.txtImpuesto = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.cboTitulo = new System.Windows.Forms.ComboBox();
			this.btnCalcula = new System.Windows.Forms.Button();
			this.btnNueva = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(30, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 16);
			this.label1.TabIndex = 18;
			this.label1.Text = "Titulo del libro:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(30, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 16);
			this.label2.TabIndex = 19;
			this.label2.Text = "Precio:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(30, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 16);
			this.label3.TabIndex = 20;
			this.label3.Text = "Cantidad:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(30, 181);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 16);
			this.label4.TabIndex = 21;
			this.label4.Text = "Subtotal:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(30, 222);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 16);
			this.label5.TabIndex = 22;
			this.label5.Text = "Impuesto (13%):";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(30, 265);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 16);
			this.label6.TabIndex = 23;
			this.label6.Text = "Total a pagar:";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(162, 95);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(96, 20);
			this.txtPrecio.TabIndex = 24;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(162, 132);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(96, 20);
			this.txtCantidad.TabIndex = 25;
			// 
			// txtSub
			// 
			this.txtSub.Location = new System.Drawing.Point(162, 177);
			this.txtSub.Name = "txtSub";
			this.txtSub.Size = new System.Drawing.Size(96, 20);
			this.txtSub.TabIndex = 26;
			// 
			// txtImpuesto
			// 
			this.txtImpuesto.Location = new System.Drawing.Point(162, 220);
			this.txtImpuesto.Name = "txtImpuesto";
			this.txtImpuesto.Size = new System.Drawing.Size(96, 20);
			this.txtImpuesto.TabIndex = 27;
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(162, 263);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(96, 20);
			this.txtTotal.TabIndex = 28;
			// 
			// cboTitulo
			// 
			this.cboTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTitulo.FormattingEnabled = true;
			this.cboTitulo.Items.AddRange(new object[] {
            "1.  \"Cien años de soledad\" de Gabriel Garcia Marquez",
            "2.  \"Frankenstein\" de Mary Shelley",
            "3.  \"Hamlet\" de William Shakespeare",
            "4.  \"Lolita\" de Vladimir Nabokov",
            "5.  \"El conde de montecristo\" de Alejandro Dumas"});
			this.cboTitulo.Location = new System.Drawing.Point(162, 43);
			this.cboTitulo.Name = "cboTitulo";
			this.cboTitulo.Size = new System.Drawing.Size(338, 21);
			this.cboTitulo.TabIndex = 29;
			// 
			// btnCalcula
			// 
			this.btnCalcula.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcula.Location = new System.Drawing.Point(33, 326);
			this.btnCalcula.Name = "btnCalcula";
			this.btnCalcula.Size = new System.Drawing.Size(75, 23);
			this.btnCalcula.TabIndex = 30;
			this.btnCalcula.Text = "Calcular";
			this.btnCalcula.UseVisualStyleBackColor = true;
			this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
			// 
			// btnNueva
			// 
			this.btnNueva.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNueva.Location = new System.Drawing.Point(162, 326);
			this.btnNueva.Name = "btnNueva";
			this.btnNueva.Size = new System.Drawing.Size(75, 23);
			this.btnNueva.TabIndex = 31;
			this.btnNueva.Text = "Nueva";
			this.btnNueva.UseVisualStyleBackColor = true;
			this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(292, 326);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 32;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// frmLibreria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(545, 383);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnNueva);
			this.Controls.Add(this.btnCalcula);
			this.Controls.Add(this.cboTitulo);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtImpuesto);
			this.Controls.Add(this.txtSub);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmLibreria";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Libreria universitaria";
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
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtSub;
		private System.Windows.Forms.TextBox txtImpuesto;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.ComboBox cboTitulo;
		private System.Windows.Forms.Button btnCalcula;
		private System.Windows.Forms.Button btnNueva;
		private System.Windows.Forms.Button btnSalir;
	}
}