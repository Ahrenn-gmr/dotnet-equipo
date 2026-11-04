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
   			
		}
		
		void BtnPesosDolaresClick(object sender, EventArgs e)
		{
			Form2 t = new Form2();
			t.Show();
			this.Hide();
		}
		
		void BtnDistanciaClick(object sender, EventArgs e)
		{
			Form3 y = new Form3();
			y.Show();
			this.Hide();
		}
		
		void BtnCordenadaClick(object sender, EventArgs e)
		{
			Form4 P = new Form4();
			P.Show();
			this.Hide();
		}
	}
}
