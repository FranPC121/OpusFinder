using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace OpusFinder
{
    public partial class Form1 : Form
    {
        Dictionary<Panel, Point> posicionesOriginales = new Dictionary<Panel, Point>(); //Este diccionario tiene como clave el panel y como valor la posición original (Point) que tenía cuando se cargó el formulario.
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string rubro = cmbrubro.SelectedItem?.ToString();

            // Ocultamos todos los paneles
            panelComercio.Visible = false;
            panelInformatica.Visible = false;
            panelIndustrial.Visible = false;
            panelEducacion.Visible = false;
            panelConstruccion.Visible = false;

            // Mostramos solo el que coincide con el rubro seleccionado
            switch (rubro)
            {
                case "Comercio":
                    MostrarYCentra(panelComercio);
                    break;
                case "Informática":
                    MostrarYCentra(panelInformatica);
                    break;
                case "Industrial":
                    MostrarYCentra(panelIndustrial);
                    break;
                case "Educación":
                    MostrarYCentra(panelEducacion);
                    break;
                case "Construcción":
                    MostrarYCentra(panelConstruccion);
                    break;
                case "Cualquier rubro":
                    foreach (var panel in posicionesOriginales.Keys) // Recorres cada uno de los paneles que guardaste previamente en el diccionario posicionesOriginales.
                    {
                        panel.Visible = true;
                        panel.Location = posicionesOriginales[panel]; //Vuelves a colocar el panel en su posición original, recuperándola desde el diccionario.
                    }
                    break;
                default:
                    MessageBox.Show("Selecciona un rubro válido.");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Aquí agregas las posiciones de los paneles al diccionario posicionesOriginales cuando se carga el formulario.
            posicionesOriginales[panelComercio] = panelComercio.Location;
            posicionesOriginales[panelInformatica] = panelInformatica.Location;
            posicionesOriginales[panelIndustrial] = panelIndustrial.Location;
            posicionesOriginales[panelEducacion] = panelEducacion.Location;
            posicionesOriginales[panelConstruccion] = panelConstruccion.Location;
        }
        private void MostrarYCentra(Panel p) // Método para mostrar y centrar un panel en el formulario
        {
            p.Visible = true;
            p.Left = (this.ClientSize.Width - p.Width) / 2;
            p.Top = (this.ClientSize.Height - p.Height) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag != null)
            {
                int idEmpleo = Convert.ToInt32(btn.Tag);

                // Abres el formulario y le pasas el ID
                oferta formOferta = new oferta(idEmpleo);
                formOferta.ShowDialog(); // o Show() si no quieres bloquear el principal
            }
        }

        private void of1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag != null)
            {
                int idEmpleo = Convert.ToInt32(btn.Tag);

                // Abres el formulario y le pasas el ID
                oferta formOferta = new oferta(idEmpleo);
                formOferta.ShowDialog(); // o Show() si no quieres bloquear el principal
            }
        }

        private void of3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag != null)
            {
                int idEmpleo = Convert.ToInt32(btn.Tag);

                // Abres el formulario y le pasas el ID
                oferta formOferta = new oferta(idEmpleo);
                formOferta.ShowDialog(); // o Show() si no quieres bloquear el principal
            }
        }

        private void of4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag != null)
            {
                int idEmpleo = Convert.ToInt32(btn.Tag);

                // Abres el formulario y le pasas el ID
                oferta formOferta = new oferta(idEmpleo);
                formOferta.ShowDialog(); // o Show() si no quieres bloquear el principal
            }
        }

        private void of5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag != null)
            {
                int idEmpleo = Convert.ToInt32(btn.Tag);

                // Abres el formulario y le pasas el ID
                oferta formOferta = new oferta(idEmpleo);
                formOferta.ShowDialog(); // o Show() si no quieres bloquear el principal
            }
        }
    }
}
