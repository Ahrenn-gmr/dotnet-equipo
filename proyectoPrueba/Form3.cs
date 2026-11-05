/*
 * Creado por SharpDevelop.
 * Usuario: ahren
 * Fecha: 04/11/2026
 * Hora: 08:17 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectoPrueba
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		public Form3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double x1 = Convert.ToDouble(txtX1.Text);
			double x2 = Convert.ToDouble(txtX2.Text);
			double y1 = Convert.ToDouble(txtY1.Text);
			double y2 = Convert.ToDouble(txtY2.Text);
			
			double d = Math.Sqrt(Math.Pow(x2 - x1, 2)+Math.Pow(y2 - y1, 2));
			lblResultado.Text="La distancia es: "+d.ToString("F2");
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form1 m = new Form1();
			m.Show();
			this.Hide();
		}
	}
}
