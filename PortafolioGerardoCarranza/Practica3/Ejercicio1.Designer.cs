namespace Practica3
{
	partial class frmTablas
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
			this.lblNumero = new System.Windows.Forms.Label();
			this.txtTabla = new System.Windows.Forms.TextBox();
			this.lstTabla = new System.Windows.Forms.ListBox();
			this.btnGenerar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero.Location = new System.Drawing.Point(25, 28);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(116, 16);
			this.lblNumero.TabIndex = 22;
			this.lblNumero.Text = "Número de tabla:";
			// 
			// txtTabla
			// 
			this.txtTabla.Location = new System.Drawing.Point(28, 47);
			this.txtTabla.Name = "txtTabla";
			this.txtTabla.Size = new System.Drawing.Size(221, 20);
			this.txtTabla.TabIndex = 23;
			// 
			// lstTabla
			// 
			this.lstTabla.FormattingEnabled = true;
			this.lstTabla.Location = new System.Drawing.Point(28, 73);
			this.lstTabla.Name = "lstTabla";
			this.lstTabla.Size = new System.Drawing.Size(221, 264);
			this.lstTabla.TabIndex = 24;
			// 
			// btnGenerar
			// 
			this.btnGenerar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerar.Location = new System.Drawing.Point(255, 46);
			this.btnGenerar.Name = "btnGenerar";
			this.btnGenerar.Size = new System.Drawing.Size(75, 23);
			this.btnGenerar.TabIndex = 25;
			this.btnGenerar.Text = "Generar";
			this.btnGenerar.UseVisualStyleBackColor = true;
			this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
			// 
			// frmTablas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(356, 365);
			this.Controls.Add(this.btnGenerar);
			this.Controls.Add(this.lstTabla);
			this.Controls.Add(this.txtTabla);
			this.Controls.Add(this.lblNumero);
			this.Name = "frmTablas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tablas";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.TextBox txtTabla;
		private System.Windows.Forms.ListBox lstTabla;
		private System.Windows.Forms.Button btnGenerar;
	}
}

