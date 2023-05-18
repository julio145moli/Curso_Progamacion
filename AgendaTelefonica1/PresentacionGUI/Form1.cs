using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class Form1 : Form
    {
       // private string Path = @"D:\Diego Chinchilla\AgendaTelefonica1\Imagenes";
       private string path = Application.StartupPath + "\\Imagenes\\";
        private bool HayCamara;
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MiCamara;

        public Form1()
        {
            InitializeComponent();
            listFamiliar.Visible = false;
            lbContcFamiliar.Visible = false;
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            textId.Text = "";
            textId.Focus();
            textNombre.Text = "";
            texTelefono.Text = "";
            dateTime.Text = "";
            btGuardar.Enabled = true;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textId.Text) || String.IsNullOrWhiteSpace(textNombre.Text) || String.IsNullOrWhiteSpace(texTelefono.Text))
            {
                MessageBox.Show("Campo Vacio... Agrega Un Valor");
            }
            else
            {
                listFamiliar.Items.Add("CONTACO # " + textId.Text);
                listFamiliar.Items.Add("NOMBRE: " + textNombre.Text);
                btGuardar.Enabled = false;
            }
        }

        private bool listaVisible = false;
        private void btMostrar_Click(object sender, EventArgs e)
        {
            if (listaVisible == false)
            {
                listFamiliar.Visible = true;
                lbContcFamiliar.Visible = true;
                btMostrar.Text = "OCULTAR LISTA";
                listaVisible = true;
            }
            else
            {
                listFamiliar.Visible = false;
                lbContcFamiliar.Visible = false;
                btMostrar.Text = "MOSTRAR LISTA";
                listaVisible = false;
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void listFamiliar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDispositivos();
        }

        public void CargarDispositivos()
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if(MisDispositivos.Count > 0 )
            {
                HayCamara = true;

                for (int i = 0; i < MisDispositivos.Count; i++)
                {
                    cbDispositivos.Items.Add(MisDispositivos[i].Name.ToString());
                }
            }
            else
            {
                HayCamara = false;
            }
        }
        public void CerrarCamara()
        {
            if(MiCamara != null && MiCamara.IsRunning)
            {
                MiCamara.SignalToStop();
                MiCamara = null;

            }
        }

        public void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone(); 
            pictureBox1.Image = imagen;
        }

        private void btGrabar_Click(object sender, EventArgs e)
        {
            CerrarCamara();
            int i = cbDispositivos.SelectedIndex;
            string NombreVideo = MisDispositivos[i].MonikerString;
            MiCamara = new VideoCaptureDevice(NombreVideo);
            MiCamara.NewFrame += new NewFrameEventHandler(Capturando);
            MiCamara.Start();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarCamara();
        }

        private void btCapturar_Click(object sender, EventArgs e)
        {
            this.Text = path;
            if (MiCamara != null && MiCamara.IsRunning)
            {
                pictureBox2.Image = pictureBox1.Image;
                pictureBox2.Image.Save(path + $"{textId.Text}-{textNombre.Text}.jpeg", ImageFormat.Jpeg);
            }
        }

        private void lbContcFamiliar_Click(object sender, EventArgs e)
        {

        }
    }
}
