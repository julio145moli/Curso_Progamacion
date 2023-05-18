using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentacionGUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textContraseña.PasswordChar = '*';
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void labelContraseña_Click(object sender, EventArgs e)
        {

        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            if(textUsuario.Text == "admin" && textContraseña.Text == "12345")
            {
                RegistroUsuario formulario = new RegistroUsuario();
                formulario.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Usuario O Contraseña Incorrecta");
            }
            
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtener el carácter presionado
            char ch = e.KeyChar;

            // Permitir la tecla "Backspace" y la tecla "Delete"
            if (ch == 8 || ch == 32)
            {
                e.Handled = false;
                return;
            }
            // Verificar si el carácter es una letra
            if (!Char.IsLetter(ch))
            {
                e.Handled = true;
            }
            // Verifica en enter para agregar
            if (e.KeyChar == (char)Keys.Enter)
            {
                textUsuario.Text = "";
                textUsuario.Focus();
            }
        }
    }
}
