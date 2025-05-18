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
            cv nuevoFormulario = new cv();
            nuevoFormulario.Show();     // Muestra el form para crear cv
            this.Hide();
        }
    }
}
