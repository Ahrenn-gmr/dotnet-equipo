/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC24
 * Fecha: 05/11/2026
 * Hora: 07:30 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectoPrueba
{
	/// <summary>
	/// Description of Form5.
	/// </summary>
	public partial class Form5 : Form
	{
		 private Random aleatorio = new Random();
		public Form5()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			

		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show("FELICIDADES RESPETAMOS TUS GUSTOS, GRACIAS POR CER SINCERO 😂😂😂😂");
		}
		
		void Button1MouseMove(object sender, MouseEventArgs e)
		{
			
		}
		
		void Button2MouseMove(object sender, MouseEventArgs e)
		{
			 int maximoX = this.ClientSize.Width - button1.Width;
            int maximoY = this.ClientSize.Height - button1.Height;

            int nuevaX = aleatorio.Next(0, maximoX);
            int nuevaY = aleatorio.Next(0, maximoY);

            button2.Location = new Point(nuevaX, nuevaY);
		}
	}
}
