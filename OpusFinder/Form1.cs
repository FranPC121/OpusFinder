using System.Windows.Forms;

namespace OpusFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cv1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta Form1

           cv cvForm = new cv();

            cvForm.FormClosed += (s, args) => this.Show(); // Mostrar Form1 cuando cv se cierra

            cvForm.Show(); // Mostrar el formulario cv
        }
    }
}
