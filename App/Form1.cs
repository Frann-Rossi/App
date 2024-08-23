using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Validación de los campos
            bool camposValidos = true;

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                txtApellido.BackColor = System.Drawing.Color.Red;
                camposValidos = false;
            }
            else
            {
                txtApellido.BackColor = System.Drawing.Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.BackColor = System.Drawing.Color.Red;
                camposValidos = false;
            }
            else
            {
                txtNombre.BackColor = System.Drawing.Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtEdad.Text) || !int.TryParse(txtEdad.Text, out _))
            {
                txtEdad.BackColor = System.Drawing.Color.Red;
                camposValidos = false;
            }
            else
            {
                txtEdad.BackColor = System.Drawing.Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                txtDireccion.BackColor = System.Drawing.Color.Red;
                camposValidos = false;
            }
            else
            {
                txtDireccion.BackColor = System.Drawing.Color.White;
            }

            // Si todos los campos son válidos, mostrar la información en el TextBox de resultado
            if (camposValidos)
            {
                txtResultado.Text = $"Apellido y Nombre: {txtApellido.Text.ToUpper()} {txtNombre.Text.ToUpper()}\r\n" +
                                    $"Edad: {txtEdad.Text}\r\n" +
                                    $"Dirección: {txtDireccion.Text.ToUpper()}";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            this.Close();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números en el campo de edad
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            // Limitar la cantidad de caracteres y pasar a mayúsculas
            txtApellido.Text = txtApellido.Text.ToUpper();
            txtApellido.SelectionStart = txtApellido.Text.Length;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // Limitar la cantidad de caracteres y pasar a mayúsculas
            txtNombre.Text = txtNombre.Text.ToUpper();
            txtNombre.SelectionStart = txtNombre.Text.Length;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            // Limitar la cantidad de caracteres y pasar a mayúsculas
            txtDireccion.Text = txtDireccion.Text.ToUpper();
            txtDireccion.SelectionStart = txtDireccion.Text.Length;
        }
    }
}
