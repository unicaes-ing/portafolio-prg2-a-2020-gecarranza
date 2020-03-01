namespace Practica3
{
	partial class frmPlanilla
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
			this.components = new System.ComponentModel.Container();
			this.lblValor = new System.Windows.Forms.Label();
			this.lblHoras = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtHoras = new System.Windows.Forms.TextBox();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.dgvPlanilla = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.lblPlanilla = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.errNombre = new System.Windows.Forms.ErrorProvider(this.components);
			this.lblTotal = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errNombre)).BeginInit();
			this.SuspendLayout();
			// 
			// lblValor
			// 
			this.lblValor.AutoSize = true;
			this.lblValor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValor.Location = new System.Drawing.Point(50, 95);
			this.lblValor.Name = "lblValor";
			this.lblValor.Size = new System.Drawing.Size(107, 16);
			this.lblValor.TabIndex = 24;
			this.lblValor.Text = "Valor de la hora";
			// 
			// lblHoras
			// 
			this.lblHoras.AutoSize = true;
			this.lblHoras.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHoras.Location = new System.Drawing.Point(45, 59);
			this.lblHoras.Name = "lblHoras";
			this.lblHoras.Size = new System.Drawing.Size(112, 16);
			this.lblHoras.TabIndex = 25;
			this.lblHoras.Text = "Horas trabajadas";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(99, 27);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(58, 16);
			this.lblNombre.TabIndex = 26;
			this.lblNombre.Text = "Nombre";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(163, 25);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(418, 20);
			this.txtNombre.TabIndex = 27;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Location = new System.Drawing.Point(53, 135);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 29;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// txtHoras
			// 
			this.txtHoras.Location = new System.Drawing.Point(163, 57);
			this.txtHoras.Name = "txtHoras";
			this.txtHoras.Size = new System.Drawing.Size(126, 20);
			this.txtHoras.TabIndex = 30;
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(163, 93);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(126, 20);
			this.txtValor.TabIndex = 31;
			// 
			// dgvPlanilla
			// 
			this.dgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPlanilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			this.dgvPlanilla.Location = new System.Drawing.Point(48, 164);
			this.dgvPlanilla.Name = "dgvPlanilla";
			this.dgvPlanilla.Size = new System.Drawing.Size(644, 150);
			this.dgvPlanilla.TabIndex = 32;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Nombre";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Horas trabajadas";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Valor hora";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "subtotal";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Impuesto";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Total";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Location = new System.Drawing.Point(48, 320);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 33;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// lblPlanilla
			// 
			this.lblPlanilla.AutoSize = true;
			this.lblPlanilla.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlanilla.Location = new System.Drawing.Point(537, 323);
			this.lblPlanilla.Name = "lblPlanilla";
			this.lblPlanilla.Size = new System.Drawing.Size(94, 16);
			this.lblPlanilla.TabIndex = 34;
			this.lblPlanilla.Text = "Total planilla:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(628, 323);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 16);
			this.label1.TabIndex = 35;
			// 
			// errNombre
			// 
			this.errNombre.ContainerControl = this;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(634, 322);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(0, 17);
			this.lblTotal.TabIndex = 36;
			// 
			// frmPlanilla
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(725, 364);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblPlanilla);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.dgvPlanilla);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.txtHoras);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblHoras);
			this.Controls.Add(this.lblValor);
			this.Name = "frmPlanilla";
			this.Text = "Pagos";
			((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errNombre)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblValor;
		private System.Windows.Forms.Label lblHoras;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txtHoras;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.DataGridView dgvPlanilla;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Label lblPlanilla;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errNombre;
		private System.Windows.Forms.Label lblTotal;
	}
}