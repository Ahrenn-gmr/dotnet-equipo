/*
 * Creado por SharpDevelop.
 * Usuario: ahren
 * Fecha: 04/11/2026
 * Hora: 08:18 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectoPrueba
{
	/// <summary>
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		public Form4()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			Form1 y = new Form1();
			y.Show();
			this.Hide();
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{


		    double x, y;
		    if (!double.TryParse(txtX.Text, out x))
		    {
		        MessageBox.Show("Por favor, introduce un número válido en la coordenada X.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		        txtX.Focus();
		        return;
		    }
		    
		    if (!double.TryParse(txtY.Text, out y))
		    {
		        MessageBox.Show("Por favor, introduce un número válido en la coordenada Y.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		        txtY.Focus();
		        return;
		    }
		    
		    if (x > 0 && y > 0)
		    {
		        lblResultado.Text = string.Format("El punto ({0}, {1}) está en el CUADRANTE 1.", x, y);
		    }
		    else if (x < 0 && y > 0)
		    {
		        lblResultado.Text = string.Format("El punto ({0}, {1}) está en el CUADRANTE 2.", x, y);
		    }
		    else if (x < 0 && y < 0)
		    {
		        lblResultado.Text = string.Format("El punto ({0}, {1}) está en el CUADRANTE 3.", x, y);
		    }
		    else if (x > 0 && y < 0)
		    {
		        lblResultado.Text = string.Format("El punto ({0}, {1}) está en el CUADRANTE 4.", x, y);
		    }
		    else if (x == 0 && y != 0)
		    {
		        lblResultado.Text = string.Format("El punto ({0}, {1}) está sobre el EJE Y.", x, y);
		    }
		    else if (x != 0 && y == 0)
		    {
		        lblResultado.Text = string.Format("El punto ({0}, {1}) está sobre el EJE X.", x, y);
		    }
		    else
		    {
		        lblResultado.Text = string.Format("El punto ({0}, {1}) es el ORIGEN.", x, y);
		    }

		}
	}
}
