/*
 * Creado por SharpDevelop.
 * Usuario: ahren
 * Fecha: 04/11/2026
 * Hora: 08:17 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace proyectoPrueba
{
	partial class Form3
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblX1 = new System.Windows.Forms.Label();
			this.lblX2 = new System.Windows.Forms.Label();
			this.lblY1 = new System.Windows.Forms.Label();
			this.lblY2 = new System.Windows.Forms.Label();
			this.txtX1 = new System.Windows.Forms.TextBox();
			this.txtX2 = new System.Windows.Forms.TextBox();
			this.txtY1 = new System.Windows.Forms.TextBox();
			this.txtY2 = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(309, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "DISTANCIA ENTRE DOS PUNTOS";
			// 
			// lblX1
			// 
			this.lblX1.Location = new System.Drawing.Point(12, 36);
			this.lblX1.Name = "lblX1";
			this.lblX1.Size = new System.Drawing.Size(55, 23);
			this.lblX1.TabIndex = 1;
			this.lblX1.Text = "X1:";
			// 
			// lblX2
			// 
			this.lblX2.Location = new System.Drawing.Point(12, 63);
			this.lblX2.Name = "lblX2";
			this.lblX2.Size = new System.Drawing.Size(55, 23);
			this.lblX2.TabIndex = 2;
			this.lblX2.Text = "X2:";
			// 
			// lblY1
			// 
			this.lblY1.Location = new System.Drawing.Point(162, 32);
			this.lblY1.Name = "lblY1";
			this.lblY1.Size = new System.Drawing.Size(54, 23);
			this.lblY1.TabIndex = 3;
			this.lblY1.Text = "Y1:";
			// 
			// lblY2
			// 
			this.lblY2.Location = new System.Drawing.Point(162, 63);
			this.lblY2.Name = "lblY2";
			this.lblY2.Size = new System.Drawing.Size(54, 23);
			this.lblY2.TabIndex = 4;
			this.lblY2.Text = "Y2:";
			// 
			// txtX1
			// 
			this.txtX1.Location = new System.Drawing.Point(43, 32);
			this.txtX1.Name = "txtX1";
			this.txtX1.Size = new System.Drawing.Size(83, 22);
			this.txtX1.TabIndex = 5;
			// 
			// txtX2
			// 
			this.txtX2.Location = new System.Drawing.Point(43, 60);
			this.txtX2.Name = "txtX2";
			this.txtX2.Size = new System.Drawing.Size(83, 22);
			this.txtX2.TabIndex = 6;
			// 
			// txtY1
			// 
			this.txtY1.Location = new System.Drawing.Point(193, 29);
			this.txtY1.Name = "txtY1";
			this.txtY1.Size = new System.Drawing.Size(100, 22);
			this.txtY1.TabIndex = 7;
			// 
			// txtY2
			// 
			this.txtY2.Location = new System.Drawing.Point(193, 63);
			this.txtY2.Name = "txtY2";
			this.txtY2.Size = new System.Drawing.Size(100, 22);
			this.txtY2.TabIndex = 8;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(43, 88);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(118, 46);
			this.btnCalcular.TabIndex = 9;
			this.btnCalcular.Text = "CALCULAR";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 146);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "RESULTADO:";
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(116, 146);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(205, 47);
			this.lblResultado.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(193, 90);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 31);
			this.button1.TabIndex = 12;
			this.button1.Text = "REGRESAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(333, 253);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtY2);
			this.Controls.Add(this.txtY1);
			this.Controls.Add(this.txtX2);
			this.Controls.Add(this.txtX1);
			this.Controls.Add(this.lblY2);
			this.Controls.Add(this.lblY1);
			this.Controls.Add(this.lblX2);
			this.Controls.Add(this.lblX1);
			this.Controls.Add(this.label1);
			this.Name = "Form3";
			this.Text = "Form3";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtY2;
		private System.Windows.Forms.TextBox txtY1;
		private System.Windows.Forms.TextBox txtX2;
		private System.Windows.Forms.TextBox txtX1;
		private System.Windows.Forms.Label lblY2;
		private System.Windows.Forms.Label lblY1;
		private System.Windows.Forms.Label lblX2;
		private System.Windows.Forms.Label lblX1;
		private System.Windows.Forms.Label label1;
	}
}
