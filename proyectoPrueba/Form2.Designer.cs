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
			this.btnRegresar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(9, 10);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(90, 89);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(104, 10);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(373, 43);
			this.label1.TabIndex = 1;
			this.label1.Text = "¡BIENVENID@!";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(104, 53);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(248, 80);
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
			this.cmbConversion.Location = new System.Drawing.Point(9, 159);
			this.cmbConversion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cmbConversion.Name = "cmbConversion";
			this.cmbConversion.Size = new System.Drawing.Size(227, 29);
			this.cmbConversion.TabIndex = 3;
			// 
			// txtCantidad
			// 
			this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtCantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidad.ForeColor = System.Drawing.Color.White;
			this.txtCantidad.Location = new System.Drawing.Point(9, 228);
			this.txtCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtCantidad.Multiline = true;
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(271, 33);
			this.txtCantidad.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(9, 132);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(263, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "Seleccione el Tipo de Conversion:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(9, 201);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(180, 24);
			this.label4.TabIndex = 6;
			this.label4.Text = "Cantidad a Convertir:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(9, 277);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(180, 24);
			this.label5.TabIndex = 7;
			this.label5.Text = "Tipo de Cambio:";
			// 
			// txtTipoCambio
			// 
			this.txtTipoCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtTipoCambio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTipoCambio.ForeColor = System.Drawing.Color.White;
			this.txtTipoCambio.Location = new System.Drawing.Point(9, 304);
			this.txtTipoCambio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtTipoCambio.Multiline = true;
			this.txtTipoCambio.Name = "txtTipoCambio";
			this.txtTipoCambio.Size = new System.Drawing.Size(271, 33);
			this.txtTipoCambio.TabIndex = 8;
			// 
			// btnConvertir
			// 
			this.btnConvertir.BackColor = System.Drawing.Color.Lime;
			this.btnConvertir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConvertir.Location = new System.Drawing.Point(89, 359);
			this.btnConvertir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnConvertir.Name = "btnConvertir";
			this.btnConvertir.Size = new System.Drawing.Size(183, 46);
			this.btnConvertir.TabIndex = 9;
			this.btnConvertir.Text = "Convertir";
			this.btnConvertir.UseVisualStyleBackColor = false;
			this.btnConvertir.Click += new System.EventHandler(this.BtnConvertirClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.White;
			this.lblResultado.Location = new System.Drawing.Point(16, 446);
			this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(336, 24);
			this.lblResultado.TabIndex = 10;
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.Color.Lime;
			this.btnRegresar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(98, 412);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(161, 32);
			this.btnRegresar.TabIndex = 11;
			this.btnRegresar.Text = "REGRESAR";
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(368, 479);
			this.Controls.Add(this.btnRegresar);
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
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form2";
			this.Text = "Conversion de Dinero";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnRegresar;
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
