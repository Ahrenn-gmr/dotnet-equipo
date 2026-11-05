/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC24
 * Fecha: 28/10/2026
 * Hora: 08:02 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace proyectoPrueba
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnPesosDolares = new System.Windows.Forms.Button();
			this.btnDistancia = new System.Windows.Forms.Button();
			this.btnCordenada = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Red;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(13, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(322, 72);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(322, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "ELIGE UNA DE LAS OPSIONES:";
			// 
			// btnPesosDolares
			// 
			this.btnPesosDolares.Location = new System.Drawing.Point(13, 112);
			this.btnPesosDolares.Name = "btnPesosDolares";
			this.btnPesosDolares.Size = new System.Drawing.Size(98, 73);
			this.btnPesosDolares.TabIndex = 3;
			this.btnPesosDolares.Text = "CONVERCION DE DOLARES/PESOS";
			this.btnPesosDolares.UseVisualStyleBackColor = true;
			this.btnPesosDolares.Click += new System.EventHandler(this.BtnPesosDolaresClick);
			// 
			// btnDistancia
			// 
			this.btnDistancia.Location = new System.Drawing.Point(117, 113);
			this.btnDistancia.Name = "btnDistancia";
			this.btnDistancia.Size = new System.Drawing.Size(98, 72);
			this.btnDistancia.TabIndex = 4;
			this.btnDistancia.Text = "DISTANCIA ENTRE DOS PUNTOS";
			this.btnDistancia.UseVisualStyleBackColor = true;
			this.btnDistancia.Click += new System.EventHandler(this.BtnDistanciaClick);
			// 
			// btnCordenada
			// 
			this.btnCordenada.Location = new System.Drawing.Point(221, 113);
			this.btnCordenada.Name = "btnCordenada";
			this.btnCordenada.Size = new System.Drawing.Size(98, 72);
			this.btnCordenada.TabIndex = 5;
			this.btnCordenada.Text = "CORDENADA DE UN PUNTO";
			this.btnCordenada.UseVisualStyleBackColor = true;
			this.btnCordenada.Click += new System.EventHandler(this.BtnCordenadaClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 192);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 74);
			this.button1.TabIndex = 6;
			this.button1.Text = "PREGUNTA MAGICA😋😋😋";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 315);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnCordenada);
			this.Controls.Add(this.btnDistancia);
			this.Controls.Add(this.btnPesosDolares);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "MENU PRINCIPAL";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnCordenada;
		private System.Windows.Forms.Button btnDistancia;
		private System.Windows.Forms.Button btnPesosDolares;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
