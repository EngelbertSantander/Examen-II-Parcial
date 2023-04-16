using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_II_Parcial
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private async void IngresarButton_Click(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(UsuarioTextBox, "Ingrese un usuario");
                UsuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (ContrasenaTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(ContrasenaTextBox, "Ingrese una contraseña:");
                ContrasenaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            UsuarioDatos UserDatos = new UsuarioDatos();

           bool valido = await UserDatos.LoginAsync(UsuarioTextBox.Text, ContrasenaTextBox.Text);
            if (valido)
            {
                MenúForm Formulario = new MenúForm();
                Hide();
                Formulario.Show();
            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
