namespace Practica_5
{
	partial class frmVendedores
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
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.btnOrdenarZA = new System.Windows.Forms.Button();
			this.btnOrdenarAZ = new System.Windows.Forms.Button();
			this.lstVendedores = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(187, 185);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 21);
			this.txtNombre.TabIndex = 15;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Location = new System.Drawing.Point(187, 211);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(100, 23);
			this.btnBuscar.TabIndex = 14;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(184, 169);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 13;
			this.label2.Text = "Nombre:";
			// 
			// btnQuitar
			// 
			this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuitar.Location = new System.Drawing.Point(187, 123);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(100, 23);
			this.btnQuitar.TabIndex = 12;
			this.btnQuitar.Text = "Quitar";
			this.btnQuitar.UseVisualStyleBackColor = true;
			this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
			// 
			// btnOrdenarZA
			// 
			this.btnOrdenarZA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrdenarZA.Location = new System.Drawing.Point(187, 94);
			this.btnOrdenarZA.Name = "btnOrdenarZA";
			this.btnOrdenarZA.Size = new System.Drawing.Size(100, 23);
			this.btnOrdenarZA.TabIndex = 11;
			this.btnOrdenarZA.Text = "Ordenar Z-A";
			this.btnOrdenarZA.UseVisualStyleBackColor = true;
			this.btnOrdenarZA.Click += new System.EventHandler(this.btnOrdenarZA_Click);
			// 
			// btnOrdenarAZ
			// 
			this.btnOrdenarAZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrdenarAZ.Location = new System.Drawing.Point(187, 65);
			this.btnOrdenarAZ.Name = "btnOrdenarAZ";
			this.btnOrdenarAZ.Size = new System.Drawing.Size(100, 23);
			this.btnOrdenarAZ.TabIndex = 10;
			this.btnOrdenarAZ.Text = "Ordenar A-Z";
			this.btnOrdenarAZ.UseVisualStyleBackColor = true;
			this.btnOrdenarAZ.Click += new System.EventHandler(this.btnOrdenarAZ_Click);
			// 
			// lstVendedores
			// 
			this.lstVendedores.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstVendedores.FormattingEnabled = true;
			this.lstVendedores.ItemHeight = 17;
			this.lstVendedores.Location = new System.Drawing.Point(26, 41);
			this.lstVendedores.Name = "lstVendedores";
			this.lstVendedores.Size = new System.Drawing.Size(143, 242);
			this.lstVendedores.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "Vendedores";
			// 
			// frmVendedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(320, 324);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnQuitar);
			this.Controls.Add(this.btnOrdenarZA);
			this.Controls.Add(this.btnOrdenarAZ);
			this.Controls.Add(this.lstVendedores);
			this.Controls.Add(this.label1);
			this.Name = "frmVendedores";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vendedores";
			this.Load += new System.EventHandler(this.frmVendedores_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnQuitar;
		private System.Windows.Forms.Button btnOrdenarZA;
		private System.Windows.Forms.Button btnOrdenarAZ;
		private System.Windows.Forms.ListBox lstVendedores;
		private System.Windows.Forms.Label label1;
	}
}

