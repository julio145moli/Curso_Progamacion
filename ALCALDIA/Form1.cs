using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ALCALDIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Valor_Click(object sender, EventArgs e)
        {

        }

        private void ListaMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Departamento_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Municipio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Lugar_Enter(object sender, EventArgs e)
        {

        }

        private void Agregar_Enter(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                return;
            }
            if (Departamento.Checked )
            {
                ListaDepartamentos.Items.Add(txtValor.Text);
                
            }
            else
            {
                ListaMunicipios.Items.Add(txtValor.Text);
            }
            txtValor.Text = "";
            txtValor.Focus();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (ListaDepartamentos.SelectedIndex != -1) 
            {
                ListaDepartamentos.Items.RemoveAt(ListaDepartamentos.SelectedIndex);
            }
        }

        private void Listas_Enter(object sender, EventArgs e)
        {

        }

        private void btDerecho_Click(object sender, EventArgs e)
        {
            var indice = ListaDepartamentos.SelectedIndex;
            ListaMunicipios.Items.Add(ListaDepartamentos.SelectedItems.ToString());
            ListaDepartamentos.Items.RemoveAt(indice);
            ListaDepartamentos.Refresh();
            ListaMunicipios.Refresh();  
        }

        private void btIzquierdo_Click(object sender, EventArgs e)
        {
            var indice = ListaMunicipios.SelectedIndex;
            ListaDepartamentos.Items.Add(ListaMunicipios.SelectedItems.ToString());
            ListaMunicipios.Items.RemoveAt(indice);
            ListaDepartamentos.Refresh();
            ListaMunicipios.Refresh();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            if (Departamento.Checked)
            {
                ListaDepartamentos.Items.Clear();

            }
            else
            {
                ListaMunicipios.Items.Clear();
            }
        }

        private void ListaDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
