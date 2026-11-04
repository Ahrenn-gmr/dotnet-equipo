/*
 * Creado por SharpDevelop.
 * Usuario: ahren
 * Fecha: 04/11/2026
 * Hora: 07:47 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace proyectoPrueba
{
	partial class Form2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbConversion = new System.Windows.Forms.ComboBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTipoCambio = new System.Windows.Forms.TextBox();
			this.btnConvertir = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(120, 110);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(138, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(497, 53);
			this.label1.TabIndex = 1;
			this.label1.Text = "¡BIENVENID@!";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(138, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(331, 98);
			this.label2.TabIndex = 2;
			this.label2.Text = "Convierte fácilmente Dolares a Pesos y Pesos a Dolares. ⚠️ Los datos que te arroj" +
			"e el resultado pueden no ser reales o hayan cambiado\r\n";
			// 
			// cmbConversion
			// 
			this.cmbConversion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cmbConversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbConversion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbConversion.ForeColor = System.Drawing.Color.White;
			this.cmbConversion.FormattingEnabled = true;
			this.cmbConversion.Items.AddRange(new object[] {
									"Dolares a Pesos",
									"Pesos a Dolares"});
			this.cmbConversion.Location = new System.Drawing.Point(12, 196);
			this.cmbConversion.Name = "cmbConversion";
			this.cmbConversion.Size = new System.Drawing.Size(301, 36);
			this.cmbConversion.TabIndex = 3;
			// 
			// txtCantidad
			// 
			this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtCantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidad.ForeColor = System.Drawing.Color.White;
			this.txtCantidad.Location = new System.Drawing.Point(12, 280);
			this.txtCantidad.Multiline = true;
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(360, 40);
			this.txtCantidad.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(12, 163);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(351, 30);
			this.label3.TabIndex = 4;
			this.label3.Text = "Seleccione el Tipo de Conversion:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(12, 247);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(240, 30);
			this.label4.TabIndex = 6;
			this.label4.Text = "Cantidad a Convertir:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(12, 341);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(240, 30);
			this.label5.TabIndex = 7;
			this.label5.Text = "Tipo de Cambio:";
			// 
			// txtTipoCambio
			// 
			this.txtTipoCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtTipoCambio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTipoCambio.ForeColor = System.Drawing.Color.White;
			this.txtTipoCambio.Location = new System.Drawing.Point(12, 374);
			this.txtTipoCambio.Multiline = true;
			this.txtTipoCambio.Name = "txtTipoCambio";
			this.txtTipoCambio.Size = new System.Drawing.Size(360, 40);
			this.txtTipoCambio.TabIndex = 8;
			// 
			// btnConvertir
			// 
			this.btnConvertir.BackColor = System.Drawing.Color.Lime;
			this.btnConvertir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConvertir.Location = new System.Drawing.Point(119, 442);
			this.btnConvertir.Name = "btnConvertir";
			this.btnConvertir.Size = new System.Drawing.Size(244, 56);
			this.btnConvertir.TabIndex = 9;
			this.btnConvertir.Text = "Convertir";
			this.btnConvertir.UseVisualStyleBackColor = false;
			this.btnConvertir.Click += new System.EventHandler(this.BtnConvertirClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.White;
			this.lblResultado.Location = new System.Drawing.Point(21, 526);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(448, 30);
			this.lblResultado.TabIndex = 10;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(490, 589);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnConvertir);
			this.Controls.Add(this.txtTipoCambio);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbConversion);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form2";
			this.Text = "Conversion de Dinero";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnConvertir;
		private System.Windows.Forms.TextBox txtTipoCambio;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbConversion;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
