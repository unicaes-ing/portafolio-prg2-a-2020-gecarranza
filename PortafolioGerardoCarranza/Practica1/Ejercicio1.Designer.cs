namespace Practica1
{
	partial class frmPromedio
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
			this.lblExam1 = new System.Windows.Forms.Label();
			this.lblExam2 = new System.Windows.Forms.Label();
			this.lblExam3 = new System.Windows.Forms.Label();
			this.lblPromedio = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.txtExam1 = new System.Windows.Forms.TextBox();
			this.txtExam2 = new System.Windows.Forms.TextBox();
			this.txtExam3 = new System.Windows.Forms.TextBox();
			this.txtProm = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblExam1
			// 
			this.lblExam1.AutoSize = true;
			this.lblExam1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExam1.Location = new System.Drawing.Point(32, 50);
			this.lblExam1.Name = "lblExam1";
			this.lblExam1.Size = new System.Drawing.Size(71, 16);
			this.lblExam1.TabIndex = 0;
			this.lblExam1.Text = "Examen 1:";
			// 
			// lblExam2
			// 
			this.lblExam2.AutoSize = true;
			this.lblExam2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExam2.Location = new System.Drawing.Point(32, 102);
			this.lblExam2.Name = "lblExam2";
			this.lblExam2.Size = new System.Drawing.Size(71, 16);
			this.lblExam2.TabIndex = 1;
			this.lblExam2.Text = "Examen 2:";
			// 
			// lblExam3
			// 
			this.lblExam3.AutoSize = true;
			this.lblExam3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExam3.Location = new System.Drawing.Point(32, 159);
			this.lblExam3.Name = "lblExam3";
			this.lblExam3.Size = new System.Drawing.Size(71, 16);
			this.lblExam3.TabIndex = 2;
			this.lblExam3.Text = "Examen 3:";
			// 
			// lblPromedio
			// 
			this.lblPromedio.AutoSize = true;
			this.lblPromedio.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPromedio.Location = new System.Drawing.Point(32, 233);
			this.lblPromedio.Name = "lblPromedio";
			this.lblPromedio.Size = new System.Drawing.Size(72, 16);
			this.lblPromedio.TabIndex = 3;
			this.lblPromedio.Text = "Promedio:";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(35, 296);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 4;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Location = new System.Drawing.Point(147, 296);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 5;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(257, 296);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 6;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// txtExam1
			// 
			this.txtExam1.Location = new System.Drawing.Point(129, 48);
			this.txtExam1.Name = "txtExam1";
			this.txtExam1.Size = new System.Drawing.Size(146, 20);
			this.txtExam1.TabIndex = 7;
			// 
			// txtExam2
			// 
			this.txtExam2.Location = new System.Drawing.Point(129, 100);
			this.txtExam2.Name = "txtExam2";
			this.txtExam2.Size = new System.Drawing.Size(146, 20);
			this.txtExam2.TabIndex = 8;
			// 
			// txtExam3
			// 
			this.txtExam3.Location = new System.Drawing.Point(129, 157);
			this.txtExam3.Name = "txtExam3";
			this.txtExam3.Size = new System.Drawing.Size(146, 20);
			this.txtExam3.TabIndex = 9;
			// 
			// txtProm
			// 
			this.txtProm.Location = new System.Drawing.Point(129, 231);
			this.txtProm.Name = "txtProm";
			this.txtProm.Size = new System.Drawing.Size(146, 20);
			this.txtProm.TabIndex = 10;
			// 
			// frmPromedio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(407, 360);
			this.Controls.Add(this.txtProm);
			this.Controls.Add(this.txtExam3);
			this.Controls.Add(this.txtExam2);
			this.Controls.Add(this.txtExam1);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblPromedio);
			this.Controls.Add(this.lblExam3);
			this.Controls.Add(this.lblExam2);
			this.Controls.Add(this.lblExam1);
			this.Name = "frmPromedio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Promedio";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblExam1;
		private System.Windows.Forms.Label lblExam2;
		private System.Windows.Forms.Label lblExam3;
		private System.Windows.Forms.Label lblPromedio;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.TextBox txtExam1;
		private System.Windows.Forms.TextBox txtExam2;
		private System.Windows.Forms.TextBox txtExam3;
		private System.Windows.Forms.TextBox txtProm;
	}
}

