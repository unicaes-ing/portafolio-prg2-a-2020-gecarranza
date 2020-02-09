namespace Practica1
{
	partial class Form2
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
			this.lblDecimal = new System.Windows.Forms.Label();
			this.txtDecimal = new System.Windows.Forms.TextBox();
			this.grpConversiones = new System.Windows.Forms.GroupBox();
			this.lblBinario = new System.Windows.Forms.Label();
			this.lblOctal = new System.Windows.Forms.Label();
			this.lblHexa = new System.Windows.Forms.Label();
			this.btnCal = new System.Windows.Forms.Button();
			this.btnLim = new System.Windows.Forms.Button();
			this.btnSal = new System.Windows.Forms.Button();
			this.txtBinario = new System.Windows.Forms.TextBox();
			this.txtOctal = new System.Windows.Forms.TextBox();
			this.txtHexa = new System.Windows.Forms.TextBox();
			this.grpConversiones.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblDecimal
			// 
			this.lblDecimal.AutoSize = true;
			this.lblDecimal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDecimal.Location = new System.Drawing.Point(27, 50);
			this.lblDecimal.Name = "lblDecimal";
			this.lblDecimal.Size = new System.Drawing.Size(62, 16);
			this.lblDecimal.TabIndex = 1;
			this.lblDecimal.Text = "Decimal:";
			// 
			// txtDecimal
			// 
			this.txtDecimal.Location = new System.Drawing.Point(95, 48);
			this.txtDecimal.Name = "txtDecimal";
			this.txtDecimal.Size = new System.Drawing.Size(130, 20);
			this.txtDecimal.TabIndex = 2;
			// 
			// grpConversiones
			// 
			this.grpConversiones.Controls.Add(this.txtHexa);
			this.grpConversiones.Controls.Add(this.txtOctal);
			this.grpConversiones.Controls.Add(this.txtBinario);
			this.grpConversiones.Controls.Add(this.lblHexa);
			this.grpConversiones.Controls.Add(this.lblOctal);
			this.grpConversiones.Controls.Add(this.lblBinario);
			this.grpConversiones.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpConversiones.Location = new System.Drawing.Point(30, 94);
			this.grpConversiones.Name = "grpConversiones";
			this.grpConversiones.Size = new System.Drawing.Size(345, 185);
			this.grpConversiones.TabIndex = 3;
			this.grpConversiones.TabStop = false;
			this.grpConversiones.Text = "Equivale a:";
			// 
			// lblBinario
			// 
			this.lblBinario.AutoSize = true;
			this.lblBinario.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBinario.Location = new System.Drawing.Point(17, 44);
			this.lblBinario.Name = "lblBinario";
			this.lblBinario.Size = new System.Drawing.Size(56, 16);
			this.lblBinario.TabIndex = 2;
			this.lblBinario.Text = "Binario:";
			// 
			// lblOctal
			// 
			this.lblOctal.AutoSize = true;
			this.lblOctal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOctal.Location = new System.Drawing.Point(17, 88);
			this.lblOctal.Name = "lblOctal";
			this.lblOctal.Size = new System.Drawing.Size(44, 16);
			this.lblOctal.TabIndex = 3;
			this.lblOctal.Text = "Octal:";
			// 
			// lblHexa
			// 
			this.lblHexa.AutoSize = true;
			this.lblHexa.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHexa.Location = new System.Drawing.Point(17, 135);
			this.lblHexa.Name = "lblHexa";
			this.lblHexa.Size = new System.Drawing.Size(91, 16);
			this.lblHexa.TabIndex = 4;
			this.lblHexa.Text = "Hexadecimal:";
			// 
			// btnCal
			// 
			this.btnCal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCal.Location = new System.Drawing.Point(63, 299);
			this.btnCal.Name = "btnCal";
			this.btnCal.Size = new System.Drawing.Size(75, 23);
			this.btnCal.TabIndex = 5;
			this.btnCal.Text = "Calcular";
			this.btnCal.UseVisualStyleBackColor = true;
			this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
			// 
			// btnLim
			// 
			this.btnLim.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLim.Location = new System.Drawing.Point(160, 299);
			this.btnLim.Name = "btnLim";
			this.btnLim.Size = new System.Drawing.Size(75, 23);
			this.btnLim.TabIndex = 6;
			this.btnLim.Text = "Limpiar";
			this.btnLim.UseVisualStyleBackColor = true;
			this.btnLim.Click += new System.EventHandler(this.btnLim_Click);
			// 
			// btnSal
			// 
			this.btnSal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSal.Location = new System.Drawing.Point(256, 299);
			this.btnSal.Name = "btnSal";
			this.btnSal.Size = new System.Drawing.Size(75, 23);
			this.btnSal.TabIndex = 7;
			this.btnSal.Text = "Salir";
			this.btnSal.UseVisualStyleBackColor = true;
			this.btnSal.Click += new System.EventHandler(this.btnSal_Click);
			// 
			// txtBinario
			// 
			this.txtBinario.Location = new System.Drawing.Point(114, 41);
			this.txtBinario.Name = "txtBinario";
			this.txtBinario.Size = new System.Drawing.Size(177, 24);
			this.txtBinario.TabIndex = 5;
			// 
			// txtOctal
			// 
			this.txtOctal.Location = new System.Drawing.Point(114, 85);
			this.txtOctal.Name = "txtOctal";
			this.txtOctal.Size = new System.Drawing.Size(177, 24);
			this.txtOctal.TabIndex = 6;
			// 
			// txtHexa
			// 
			this.txtHexa.Location = new System.Drawing.Point(114, 127);
			this.txtHexa.Name = "txtHexa";
			this.txtHexa.Size = new System.Drawing.Size(177, 24);
			this.txtHexa.TabIndex = 7;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(411, 354);
			this.Controls.Add(this.btnSal);
			this.Controls.Add(this.btnLim);
			this.Controls.Add(this.btnCal);
			this.Controls.Add(this.grpConversiones);
			this.Controls.Add(this.txtDecimal);
			this.Controls.Add(this.lblDecimal);
			this.Name = "Form2";
			this.Text = "Sistemas";
			this.grpConversiones.ResumeLayout(false);
			this.grpConversiones.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDecimal;
		private System.Windows.Forms.TextBox txtDecimal;
		private System.Windows.Forms.GroupBox grpConversiones;
		private System.Windows.Forms.Label lblHexa;
		private System.Windows.Forms.Label lblOctal;
		private System.Windows.Forms.Label lblBinario;
		private System.Windows.Forms.Button btnCal;
		private System.Windows.Forms.Button btnLim;
		private System.Windows.Forms.Button btnSal;
		private System.Windows.Forms.TextBox txtHexa;
		private System.Windows.Forms.TextBox txtOctal;
		private System.Windows.Forms.TextBox txtBinario;
	}
}