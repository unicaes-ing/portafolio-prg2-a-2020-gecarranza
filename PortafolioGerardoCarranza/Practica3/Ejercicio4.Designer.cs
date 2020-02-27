namespace Practica3
{
	partial class frmBuscar
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
			this.dgvBuscar = new System.Windows.Forms.DataGridView();
			this.lblNumero = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvBuscar
			// 
			this.dgvBuscar.AllowUserToDeleteRows = false;
			this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBuscar.Location = new System.Drawing.Point(24, 26);
			this.dgvBuscar.Name = "dgvBuscar";
			this.dgvBuscar.ReadOnly = true;
			this.dgvBuscar.Size = new System.Drawing.Size(236, 226);
			this.dgvBuscar.TabIndex = 0;
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero.Location = new System.Drawing.Point(12, 270);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(117, 16);
			this.lblNumero.TabIndex = 23;
			this.lblNumero.Text = "Número a buscar:";
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(135, 268);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(95, 20);
			this.txtBuscar.TabIndex = 24;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Location = new System.Drawing.Point(236, 267);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 28;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// frmBuscar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(328, 310);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.lblNumero);
			this.Controls.Add(this.dgvBuscar);
			this.Name = "frmBuscar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Buscar";
			this.Load += new System.EventHandler(this.frmBuscar_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvBuscar;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Button btnBuscar;
	}
}