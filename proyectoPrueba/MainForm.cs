/*
 * Creado por SharpDevelop.
 * Usuario: ahren
 * Fecha: 27/10/2026
 * Hora: 08:19 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proyectoPrueba
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnINICIARClick(object sender, EventArgs e)
		{
			string user = txtUSUARIO.Text;
			string contra = txtCONTRA.Text;
			
			if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(contra))
			{
			    MessageBox.Show("No puede haber campos vacíos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (user == "CBTis217" && contra == "Programacion")
			{
			    MessageBox.Show("¡Inicio de sesión exitoso! Bienvenido.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
			    // Form1 menu = new Form1();
			    // menu.Show();
			    // this.Hide();
			}
			else
			{
			    MessageBox.Show("Usuario y contraseña incorrectos.", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
