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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUSUARIO = new System.Windows.Forms.TextBox();
			this.txtCONTRA = new System.Windows.Forms.TextBox();
			this.btnINICIAR = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(60, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(504, 113);
			this.label1.TabIndex = 0;
			this.label1.Text = "Inicia Sesión en Nuestro Programa";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(86, 254);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(247, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre de Usuario:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(86, 348);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(218, 29);
			this.label3.TabIndex = 2;
			this.label3.Text = "Contraseña:";
			// 
			// txtUSUARIO
			// 
			this.txtUSUARIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtUSUARIO.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUSUARIO.ForeColor = System.Drawing.Color.White;
			this.txtUSUARIO.Location = new System.Drawing.Point(138, 290);
			this.txtUSUARIO.Multiline = true;
			this.txtUSUARIO.Name = "txtUSUARIO";
			this.txtUSUARIO.Size = new System.Drawing.Size(360, 40);
			this.txtUSUARIO.TabIndex = 3;
			// 
			// txtCONTRA
			// 
			this.txtCONTRA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtCONTRA.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCONTRA.ForeColor = System.Drawing.Color.White;
			this.txtCONTRA.Location = new System.Drawing.Point(138, 380);
			this.txtCONTRA.Multiline = true;
			this.txtCONTRA.Name = "txtCONTRA";
			this.txtCONTRA.Size = new System.Drawing.Size(360, 41);
			this.txtCONTRA.TabIndex = 4;
			// 
			// btnINICIAR
			// 
			this.btnINICIAR.BackColor = System.Drawing.Color.LimeGreen;
			this.btnINICIAR.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnINICIAR.Location = new System.Drawing.Point(178, 445);
			this.btnINICIAR.Name = "btnINICIAR";
			this.btnINICIAR.Size = new System.Drawing.Size(287, 58);
			this.btnINICIAR.TabIndex = 5;
			this.btnINICIAR.Text = "Iniciar Sesión";
			this.btnINICIAR.UseVisualStyleBackColor = false;
			this.btnINICIAR.Click += new System.EventHandler(this.BtnINICIARClick);
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(100, 530);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(433, 44);
			this.label4.TabIndex = 6;
			this.label4.Text = "Tip: No intentes poner en Usuario: CBTis217 y en Contraseña: Programacion procura" +
			" escribirlo bien.";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(12, 217);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(598, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "¡Bienvenid@ de vuelta! Tendrás que identificarte primero antes de entrar.";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(258, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 93);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(622, 596);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnINICIAR);
			this.Controls.Add(this.txtCONTRA);
			this.Controls.Add(this.txtUSUARIO);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BIENVENIDO";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnINICIAR;
		private System.Windows.Forms.TextBox txtCONTRA;
		private System.Windows.Forms.TextBox txtUSUARIO;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
