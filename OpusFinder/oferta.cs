using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpusFinder
{
    public partial class oferta : Form
    {
        public oferta()
        {
            InitializeComponent();
        }

        private void empleogrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void oferta_Load(object sender, EventArgs e)
        {

        }
        private int empleoID; // Variable para almacenar el ID del empleo seleccionado

        public oferta(int idEmpleo) // Cuando abres este formulario, le estás pasando un número entero (idEmpleo), que representa el ID del empleo que quieres mostrar.
        {
            InitializeComponent();
            empleoID = idEmpleo; // Asignas el ID del empleo a la variable empleoID para que puedas usarlo más adelante.
            CargarDatosEmpleo(); // Llamas al método CargarDatosEmpleo para que cargue los datos del empleo seleccionado en el DataGridView.
        }
        private void CargarDatosEmpleo()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BI2NFI7; Initial Catalog=CV; User ID=sa; Password=richi2006; Encrypt=False");

            try
            {
                con.Open();

                string query = "SELECT * FROM info_empleo WHERE id_empleo = @id_empleo"; // Aquí estás definiendo una consulta SQL que selecciona todos los campos de la tabla info_empleo donde el id_empleo coincide con el ID del empleo que quieres mostrar.
                SqlCommand cmd = new SqlCommand(query, con); // Creas un objeto SqlCommand que contiene la consulta SQL y la conexión a la base de datos.
                cmd.Parameters.AddWithValue("@id_empleo", empleoID); 

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); // Creas un DataTable para almacenar los resultados de la consulta.
                da.Fill(dt); // Aquí estás ejecutando la consulta y llenando un DataTable con los resultados.

                empleogrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleo: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
