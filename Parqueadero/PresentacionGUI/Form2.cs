using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            Login login1 = new Login();
            login1.Show();
            Hide();
        }

        private void btRegistros_Click(object sender, EventArgs e)
        {
            ReporteSistemas reporte = new ReporteSistemas();
            reporte.Show();
            Hide();
        }

        private void brRegistrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textNombre.Text) || String.IsNullOrWhiteSpace(textApellido.Text) || String.IsNullOrWhiteSpace(cbCargo.Text) || String.IsNullOrWhiteSpace(cbParqueadero.Text) || String.IsNullOrWhiteSpace(cbVehiculo.Text))
            {
                MessageBox.Show("Campo Vacio... Agrega Un Valor");
            }
            else
            {
                if (textPlaca.Enabled == true && String.IsNullOrWhiteSpace(textPlaca.Text)) 
                {
                    MessageBox.Show("Campo Vacio... Agrega Un Valor");
                }
                else
                {
                    Random rnd = new Random();
                    int nAleatorio = rnd.Next(1, 20);
                    MessageBox.Show("    ------------------------------" +
                                  "\n   |---------- TICKET ----------|" +
                                  "\n    ------------------------------" +
                                "\n\n    NOMBRE : " + textNombre.Text +
                                  "\n    PLACA      : " + textPlaca.Text +
                                  "\n    PUESTO   : " + nAleatorio);
                }
            }
            textNombre.Text = "";
            textApellido.Text = "";
            cbCargo.Text = "";
            cbParqueadero.Text = "";
            cbVehiculo.Text = "";
            textPlaca.Text = "";
        }

        private void cbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbVehiculo.Text == "Bicicleta")
            {
                textPlaca.Enabled = false;
            }
            else
            {
                textPlaca.Enabled = true;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btRetirar_Click(object sender, EventArgs e)
        {
            RetirarVehiculo retirar = new RetirarVehiculo();
            retirar.Show();
            this.Close();
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
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
                textNombre.Text = "";
                textNombre.Focus();
            }
        }

        private void textApellido_KeyPress(object sender, KeyPressEventArgs e)
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
                textApellido.Text = "";
                textApellido.Focus();
            }
        }
    }
}
