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
    public partial class RetirarVehiculo : Form
    {
        public RetirarVehiculo()
        {
            InitializeComponent();
        }

        private void btAtras2_Click(object sender, EventArgs e)
        {
            RegistroUsuario registro = new RegistroUsuario();
            registro.Show();
            this.Close();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBuscar.Text))
            {
                MessageBox.Show("Campo Vacio... Agrega Un Valor");
            }
            else
            {
                lbDatos.Text = textBuscar.Text;
                gbDatos.Visible = true;
                lbNombre1.Visible = true;
                lbHora.Visible = true;
                lbPago.Visible = true;
                lbDatos.Visible = true;
                cbHora.Visible = true;
                lbPrecio.Visible = true;
                btRetirar.Visible = true;
                textBuscar.Text = "";
                textBuscar.Focus();
            }
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void lbDatos_Click(object sender, EventArgs e)
        {

        }

        private void RetirarVehiculo_Load(object sender, EventArgs e)
        {
            gbDatos.Visible = false;
            lbNombre1.Visible = false;
            lbHora.Visible = false;
            lbPago.Visible = false;
            lbDatos.Visible = false;
            cbHora.Visible = false;
            lbPrecio.Visible = false;
            btRetirar.Visible = false;
        }

        private void cbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TotalPagar;
            string datoString = cbHora.SelectedItem.ToString();
            int datoInt = int.Parse(datoString);

            TotalPagar = datoInt * 2000;

            lbPrecio.Text = TotalPagar.ToString();

        }

        private void lbPrecio_Click(object sender, EventArgs e)
        {
            lbPrecio.Text = cbHora.Text;
        }

        private void btRetirar_Click(object sender, EventArgs e)
        {
            lbDatos.Text = "";
            cbHora.Text = "";
            lbPrecio.Text = "0";
            gbDatos.Visible = false;
            lbNombre1.Visible = false;
            lbHora.Visible = false;
            lbPago.Visible = false;
            lbDatos.Visible = false;
            cbHora.Visible = false;
            lbPrecio.Visible = false;
            btRetirar.Visible = false;

            MessageBox.Show("El Vehiculo Fue Retirado.....");
        }

        private void textBuscar_KeyPress(object sender, KeyPressEventArgs e)
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
                textBuscar.Text = "";
                textBuscar.Focus();
            }
        }
    }
}
