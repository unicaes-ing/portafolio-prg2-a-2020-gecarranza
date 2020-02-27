namespace Practica3
{
	partial class frmLanza
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
			this.lstLanzar = new System.Windows.Forms.ListBox();
			this.btnLanzar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstLanzar
			// 
			this.lstLanzar.FormattingEnabled = true;
			this.lstLanzar.Location = new System.Drawing.Point(24, 25);
			this.lstLanzar.Name = "lstLanzar";
			this.lstLanzar.Size = new System.Drawing.Size(155, 329);
			this.lstLanzar.TabIndex = 1;
			// 
			// btnLanzar
			// 
			this.btnLanzar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLanzar.Location = new System.Drawing.Point(63, 369);
			this.btnLanzar.Name = "btnLanzar";
			this.btnLanzar.Size = new System.Drawing.Size(75, 23);
			this.btnLanzar.TabIndex = 27;
			this.btnLanzar.Text = "Lanzar";
			this.btnLanzar.UseVisualStyleBackColor = true;
			this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
			// 
			// frmLanza
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(204, 404);
			this.Controls.Add(this.btnLanzar);
			this.Controls.Add(this.lstLanzar);
			this.Name = "frmLanza";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dado";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lstLanzar;
		private System.Windows.Forms.Button btnLanzar;
	}
}