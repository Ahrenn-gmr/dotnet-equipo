/*
 * Creado por SharpDevelop.
 * Usuario: ahren
 * Fecha: 27/10/2026
 * Hora: 08:19 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace proyectoPrueba
{
	partial class MainForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUSUARIO = new System.Windows.Forms.TextBox();
			this.txtCONTRA = new System.Windows.Forms.TextBox();
			this.btnINICIAR = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(433, 47);
			this.label1.TabIndex = 0;
			this.label1.Text = "INICIO DE SESION";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(18, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(247, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "NOMBRE DE USUARIO:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(18, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(218, 29);
			this.label3.TabIndex = 2;
			this.label3.Text = "CONTRASEÑA:";
			// 
			// txtUSUARIO
			// 
			this.txtUSUARIO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUSUARIO.Location = new System.Drawing.Point(259, 94);
			this.txtUSUARIO.Multiline = true;
			this.txtUSUARIO.Name = "txtUSUARIO";
			this.txtUSUARIO.Size = new System.Drawing.Size(186, 29);
			this.txtUSUARIO.TabIndex = 3;
			// 
			// txtCONTRA
			// 
			this.txtCONTRA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCONTRA.Location = new System.Drawing.Point(259, 147);
			this.txtCONTRA.Multiline = true;
			this.txtCONTRA.Name = "txtCONTRA";
			this.txtCONTRA.Size = new System.Drawing.Size(186, 29);
			this.txtCONTRA.TabIndex = 4;
			// 
			// btnINICIAR
			// 
			this.btnINICIAR.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnINICIAR.Location = new System.Drawing.Point(118, 217);
			this.btnINICIAR.Name = "btnINICIAR";
			this.btnINICIAR.Size = new System.Drawing.Size(215, 58);
			this.btnINICIAR.TabIndex = 5;
			this.btnINICIAR.Text = "INICIAR SESIÓN";
			this.btnINICIAR.UseVisualStyleBackColor = true;
			this.btnINICIAR.Click += new System.EventHandler(this.BtnINICIARClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 296);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(433, 44);
			this.label4.TabIndex = 6;
			this.label4.Text = "el usuario y la contrasena para nada son: USER: CBTis217 | PASS: Programacion";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(457, 341);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnINICIAR);
			this.Controls.Add(this.txtCONTRA);
			this.Controls.Add(this.txtUSUARIO);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Identificate";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnINICIAR;
		private System.Windows.Forms.TextBox txtCONTRA;
		private System.Windows.Forms.TextBox txtUSUARIO;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
