using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace OpusFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cv nuevoFormulario = new cv();
            nuevoFormulario.Show();     // Muestra el form para crear cv
            this.Hide();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Location = new Point(0, 150);
            panel1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 150);
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
        }


        private void off1_Click(object sender, EventArgs e)
        {
            oferta nuevoFormulario = new oferta();
            nuevoFormulario.Show();     // Muestra el form para crear cv
            this.Hide();
            
        }

    }
}
