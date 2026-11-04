/*
 * Creado por SharpDevelop.
 * Usuario: ahren
 * Fecha: 04/11/2026
 * Hora: 07:47 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectoPrueba
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void BtnConvertirClick(object sender, EventArgs e)
		{
			    if (cmbConversion.SelectedIndex == -1)
			    {
			        MessageBox.Show("Por favor, selecciona el tipo de conversión (Dólares a Pesos o Pesos a Dólares).", 
			                        "Falta selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			        return;
			    }
			
			    double cantidad, tipoCambio, resultado;
			    if (!double.TryParse(txtCantidad.Text, out cantidad) || cantidad < 0)
			    {
			        MessageBox.Show("Por favor, introduce una cantidad numérica válida y mayor o igual a cero.", 
			                        "Error en cantidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			        txtCantidad.Focus();
			        return;
			    }

			    if (!double.TryParse(txtTipoCambio.Text, out tipoCambio) || tipoCambio <= 0)
			    {
			        MessageBox.Show("Por favor, introduce un tipo de cambio válido (mayor a cero).", 
			                        "Error en tipo de cambio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			        txtTipoCambio.Focus();
			        return;
			    }
			
			    if (cmbConversion.SelectedIndex == 0)
			    {
			        resultado = cantidad * tipoCambio;
			        lblResultado.Text = string.Format("{0:N2} USD equivalen a ${1:N2} MXN", cantidad, resultado);
			    }
			    else 
			    {
			        resultado = cantidad / tipoCambio;
			        lblResultado.Text = string.Format("${0:N2} MXN equivalen a {1:N2} USD", cantidad, resultado);
			    }
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			Form1 a = new Form1();
			a.Show();
			this.Hide();
		}
	}
}
