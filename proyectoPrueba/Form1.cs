/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC24
 * Fecha: 28/10/2026
 * Hora: 08:02 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectoPrueba
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button4Click(object sender, EventArgs e)
		{
   			 Random aleatorio = new Random();
		    int maxX = this.ClientSize.Width - button1.Width;
    		int maxY = this.ClientSize.Height - button1.Height;
    		int nuevaX = aleatorio.Next(0, maxX);
    		int nuevaY = aleatorio.Next(0, maxY);
    		button1.Location = new Point(nuevaX, nuevaY);
		}
	}
}
