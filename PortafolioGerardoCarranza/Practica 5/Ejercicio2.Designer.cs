namespace Practica_5
{
	partial class frmMatrices
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
			this.pnlMatrices = new System.Windows.Forms.Panel();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.rdoMultiplicar = new System.Windows.Forms.RadioButton();
			this.rdoSuma = new System.Windows.Forms.RadioButton();
			this.dgvMatrizC = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvResultado = new System.Windows.Forms.DataGridView();
			this.dgvMatrizB = new System.Windows.Forms.DataGridView();
			this.dgvMatrizA = new System.Windows.Forms.DataGridView();
			this.pnlMatrices.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvMatrizB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvMatrizA)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlMatrices
			// 
			this.pnlMatrices.Controls.Add(this.btnCalcular);
			this.pnlMatrices.Controls.Add(this.rdoMultiplicar);
			this.pnlMatrices.Controls.Add(this.rdoSuma);
			this.pnlMatrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnlMatrices.Location = new System.Drawing.Point(284, 240);
			this.pnlMatrices.Name = "pnlMatrices";
			this.pnlMatrices.Size = new System.Drawing.Size(240, 66);
			this.pnlMatrices.TabIndex = 13;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(126, 21);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 9;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// rdoMultiplicar
			// 
			this.rdoMultiplicar.AutoSize = true;
			this.rdoMultiplicar.Location = new System.Drawing.Point(14, 32);
			this.rdoMultiplicar.Name = "rdoMultiplicar";
			this.rdoMultiplicar.Size = new System.Drawing.Size(97, 20);
			this.rdoMultiplicar.TabIndex = 8;
			this.rdoMultiplicar.TabStop = true;
			this.rdoMultiplicar.Text = "Multiplicar";
			this.rdoMultiplicar.UseVisualStyleBackColor = true;
			// 
			// rdoSuma
			// 
			this.rdoSuma.AutoSize = true;
			this.rdoSuma.Location = new System.Drawing.Point(14, 9);
			this.rdoSuma.Name = "rdoSuma";
			this.rdoSuma.Size = new System.Drawing.Size(70, 20);
			this.rdoSuma.TabIndex = 7;
			this.rdoSuma.TabStop = true;
			this.rdoSuma.Text = "Sumar";
			this.rdoSuma.UseVisualStyleBackColor = true;
			// 
			// dgvMatrizC
			// 
			this.dgvMatrizC.AutoSize = true;
			this.dgvMatrizC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvMatrizC.Location = new System.Drawing.Point(540, 43);
			this.dgvMatrizC.Name = "dgvMatrizC";
			this.dgvMatrizC.Size = new System.Drawing.Size(63, 16);
			this.dgvMatrizC.TabIndex = 12;
			this.dgvMatrizC.Text = "Matriz C";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(281, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 16);
			this.label2.TabIndex = 11;
			this.label2.Text = "Matriz B";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Matriz A";
			// 
			// dgvResultado
			// 
			this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvResultado.Location = new System.Drawing.Point(543, 70);
			this.dgvResultado.Name = "dgvResultado";
			this.dgvResultado.Size = new System.Drawing.Size(240, 150);
			this.dgvResultado.TabIndex = 9;
			// 
			// dgvMatrizB
			// 
			this.dgvMatrizB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMatrizB.Location = new System.Drawing.Point(284, 70);
			this.dgvMatrizB.Name = "dgvMatrizB";
			this.dgvMatrizB.Size = new System.Drawing.Size(240, 150);
			this.dgvMatrizB.TabIndex = 8;
			// 
			// dgvMatrizA
			// 
			this.dgvMatrizA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMatrizA.Location = new System.Drawing.Point(25, 70);
			this.dgvMatrizA.Name = "dgvMatrizA";
			this.dgvMatrizA.Size = new System.Drawing.Size(240, 150);
			this.dgvMatrizA.TabIndex = 7;
			// 
			// frmMatrices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(852, 346);
			this.Controls.Add(this.pnlMatrices);
			this.Controls.Add(this.dgvMatrizC);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvResultado);
			this.Controls.Add(this.dgvMatrizB);
			this.Controls.Add(this.dgvMatrizA);
			this.Name = "frmMatrices";
			this.Text = "Matrices";
			this.Load += new System.EventHandler(this.frmMatrices_Load);
			this.pnlMatrices.ResumeLayout(false);
			this.pnlMatrices.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvMatrizB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvMatrizA)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlMatrices;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.RadioButton rdoMultiplicar;
		private System.Windows.Forms.RadioButton rdoSuma;
		private System.Windows.Forms.Label dgvMatrizC;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvResultado;
		private System.Windows.Forms.DataGridView dgvMatrizB;
		private System.Windows.Forms.DataGridView dgvMatrizA;
	}
}