using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace OpusFinder
{
    public partial class cv : Form
    {
        public cv()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|Todos los archivos (*.*)|*.*";
            archivo.Title = "Seleccionar imagen de perfil";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                // Cargar la imagen seleccionada en el PictureBox
                pictureBoxFoto.Image = System.Drawing.Image.FromFile(archivo.FileName);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            us nuevoFormulario = new us();
            nuevoFormulario.Show();     // Muestra el form para crear cv
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.FormClosed += (s, args) => Application.Exit(); // Cierra todo al cerrar Form1
            form1.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            us nuevoFormulario = new us();
            nuevoFormulario.Show();     // Muestra el form para crear cv
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

       
    }


}
