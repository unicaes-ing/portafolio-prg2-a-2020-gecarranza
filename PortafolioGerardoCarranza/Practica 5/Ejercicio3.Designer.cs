namespace Practica_5
{
	partial class frmSucursales
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
			this.lblTotal = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lstDos = new System.Windows.Forms.ListBox();
			this.lstUno = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(350, 238);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(0, 16);
			this.lblTotal.TabIndex = 17;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(252, 238);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 16);
			this.label3.TabIndex = 16;
			this.label3.Text = "Total ventas:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(221, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.TabIndex = 15;
			this.label2.Text = "Ventas";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 16);
			this.label1.TabIndex = 14;
			this.label1.Text = "Sucursales";
			// 
			// lstDos
			// 
			this.lstDos.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstDos.FormattingEnabled = true;
			this.lstDos.ItemHeight = 17;
			this.lstDos.Location = new System.Drawing.Point(224, 60);
			this.lstDos.Name = "lstDos";
			this.lstDos.Size = new System.Drawing.Size(192, 140);
			this.lstDos.TabIndex = 13;
			// 
			// lstUno
			// 
			this.lstUno.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstUno.FormattingEnabled = true;
			this.lstUno.ItemHeight = 17;
			this.lstUno.Location = new System.Drawing.Point(23, 60);
			this.lstUno.Name = "lstUno";
			this.lstUno.Size = new System.Drawing.Size(183, 140);
			this.lstUno.TabIndex = 12;
			this.lstUno.SelectedIndexChanged += new System.EventHandler(this.lstUno_SelectedIndexChanged);
			// 
			// frmSucursales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(470, 295);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstDos);
			this.Controls.Add(this.lstUno);
			this.Name = "frmSucursales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sucursales";
			this.Load += new System.EventHandler(this.frmSucursales_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lstDos;
		private System.Windows.Forms.ListBox lstUno;
	}
}