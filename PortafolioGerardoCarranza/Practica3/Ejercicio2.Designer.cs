namespace Practica3
{
	partial class frmAlfabeto
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
			this.lstAlfabeto = new System.Windows.Forms.ListBox();
			this.btnMostrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstAlfabeto
			// 
			this.lstAlfabeto.FormattingEnabled = true;
			this.lstAlfabeto.Location = new System.Drawing.Point(21, 18);
			this.lstAlfabeto.Name = "lstAlfabeto";
			this.lstAlfabeto.Size = new System.Drawing.Size(197, 316);
			this.lstAlfabeto.TabIndex = 1;
			// 
			// btnMostrar
			// 
			this.btnMostrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMostrar.Location = new System.Drawing.Point(80, 345);
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.Size = new System.Drawing.Size(75, 23);
			this.btnMostrar.TabIndex = 26;
			this.btnMostrar.Text = "Mostrar";
			this.btnMostrar.UseVisualStyleBackColor = true;
			this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
			// 
			// frmAlfabeto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(239, 380);
			this.Controls.Add(this.btnMostrar);
			this.Controls.Add(this.lstAlfabeto);
			this.Name = "frmAlfabeto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Alfabeto";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lstAlfabeto;
		private System.Windows.Forms.Button btnMostrar;
	}
}