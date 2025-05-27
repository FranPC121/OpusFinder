using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



namespace OpusFinder
{
    public partial class cv : Form
    {
        int idUsuario = 0;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HTNGQBS;Initial Catalog=CV;User ID=sa;Password=Nosenada01;Encrypt=False");

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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HTNGQBS;Initial Catalog=CV;User ID=sa;Password=Nosenada01;Encrypt=False");
            con.Open();

            // Datos del usuario
            string Nombres = txtNombre.Text;
            string Apellidos = txtApellidos.Text;
            string Titulo_universitario = txtTitulo.Text;
            string Email = txtCorreo.Text;
            string Codigo_Postal = txtCP.Text;
            string Localidad = txtLocalidad.Text;
            string Genero = cmbGenero.Text;
            string Estado_civil = cmbEstadoCivil.Text;
            string Telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;

            // Insertar usuario
            string cadenaUsuario = "INSERT INTO dbo.usuario (Nombres, Apellidos, Titulo_universitario, Email, Código_Postal, Localidad, Género, Estado_civil, Telefono,direccion) " +
                                   "VALUES (@Nombres, @Apellidos, @Titulo_universitario, @Email, @Codigo_Postal, @Localidad, @Genero, @Estado_civil, @Telefono,@direccion); " +
                                   "SELECT SCOPE_IDENTITY();";

            SqlCommand comandoUsuario = new SqlCommand(cadenaUsuario, con);
            comandoUsuario.Parameters.AddWithValue("@Nombres", Nombres);
            comandoUsuario.Parameters.AddWithValue("@Apellidos", Apellidos);
            comandoUsuario.Parameters.AddWithValue("@Titulo_universitario", Titulo_universitario);
            comandoUsuario.Parameters.AddWithValue("@Email", Email);
            comandoUsuario.Parameters.AddWithValue("@Codigo_Postal", Codigo_Postal);
            comandoUsuario.Parameters.AddWithValue("@Localidad", Localidad);
            comandoUsuario.Parameters.AddWithValue("@Genero", Genero);
            comandoUsuario.Parameters.AddWithValue("@Estado_civil", Estado_civil);
            comandoUsuario.Parameters.AddWithValue("@Telefono", Telefono);
            comandoUsuario.Parameters.AddWithValue("@direccion", direccion);

            int idUsuario = Convert.ToInt32(comandoUsuario.ExecuteScalar());

            // Insertar idiomas
            InsertarIdioma(txtIdioma1.Text, cmbNivel1.Text, idUsuario, con);
            InsertarIdioma(txtIdioma2.Text, cmbNivel2.Text, idUsuario, con);
            InsertarIdioma(txtIdioma3.Text, cmbNivel3.Text, idUsuario, con);
            InsertarIdioma(txtIdioma4.Text, cmbNivel4.Text, idUsuario, con);

            MessageBox.Show("Datos guardados correctamente");

            // Limpiar campos del formulario
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtTitulo.Text = "";
            txtCorreo.Text = "";
            txtCP.Text = "";
            txtLocalidad.Text = "";
            cmbGenero.Text = "";
            cmbEstadoCivil.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";

            txtIdioma1.Text = "";
            txtIdioma2.Text = "";
            txtIdioma3.Text = "";
            txtIdioma4.Text = "";

            cmbNivel1.Text = "";
            cmbNivel2.Text = "";
            cmbNivel3.Text = "";
            cmbNivel4.Text = "";

            con.Close();
        }

        // Método para insertar idioma solo si hay datos
        private void InsertarIdioma(string idioma, string nivel, int idUsuario, SqlConnection con)
        {
            if (!string.IsNullOrWhiteSpace(idioma) && !string.IsNullOrWhiteSpace(nivel))
            {
                string insertIdioma = "INSERT INTO dbo.idiomas (idioma, nivel, id_usuario) VALUES (@idioma, @nivel, @id_usuario)";
                SqlCommand cmd = new SqlCommand(insertIdioma, con);
                cmd.Parameters.AddWithValue("@idioma", idioma);
                cmd.Parameters.AddWithValue("@nivel", nivel);
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                cmd.ExecuteNonQuery();
            }
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cv_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                    idUsuario = Convert.ToInt32(fila.Cells["id_usuario"].Value);
                    txtNombre.Text = fila.Cells["Nombres"].Value.ToString();
                    txtApellidos.Text = fila.Cells["Apellidos"].Value.ToString();
                    txtTitulo.Text = fila.Cells["Titulo_universitario"].Value.ToString();
                    txtCorreo.Text = fila.Cells["Email"].Value.ToString();
                    txtCP.Text = fila.Cells["Código_Postal"].Value.ToString();
                    txtLocalidad.Text = fila.Cells["Localidad"].Value.ToString();
                    cmbGenero.Text = fila.Cells["Género"].Value.ToString();
                    cmbEstadoCivil.Text = fila.Cells["Estado_civil"].Value.ToString();
                    txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                    txtDireccion.Text = fila.Cells["direccion"].Value.ToString();
                }
            }
        }
        private void CargarUsuarios()
        {
            con.Open();

            string consulta = "SELECT u.id_usuario, u.Nombres, u.Apellidos, u.Titulo_universitario, u.Email, " +
                              "u.Código_Postal, u.Localidad, u.Género, u.Estado_civil, u.Telefono,u.direccion ," +
                              "i.idioma, i.nivel " +
                              "FROM dbo.usuario u " +
                              "LEFT JOIN dbo.idiomas i ON u.id_usuario = i.id_usuario";

            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string actualizarUsuario = "UPDATE dbo.usuario SET " +
                               "Nombres = @Nombres, Apellidos = @Apellidos, Titulo_universitario = @Titulo, Email = @Email, " +
                               "Código_Postal = @CP, Localidad = @Localidad, Género = @Genero, Estado_civil = @EstadoCivil, Telefono = @Telefono,@direccion=direccion " +
                               "WHERE id_usuario = @IdUsuario";

            SqlCommand cmd = new SqlCommand(actualizarUsuario, con);
            cmd.Parameters.AddWithValue("@Nombres", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text);
            cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
            cmd.Parameters.AddWithValue("@Email", txtCorreo.Text);
            cmd.Parameters.AddWithValue("@CP", txtCP.Text);
            cmd.Parameters.AddWithValue("@Localidad", txtLocalidad.Text);
            cmd.Parameters.AddWithValue("@Genero", cmbGenero.Text);
            cmd.Parameters.AddWithValue("@EstadoCivil", cmbEstadoCivil.Text);
            cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text); 
            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario); // Este valor tiene que venir del DataGridView

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Usuario actualizado");
            CargarUsuarios(); //  Actualiza el DataGridView
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                if (idUsuario == 0)
                {
                    MessageBox.Show("Selecciona un usuario antes de intentar eliminarlo.");
                    return;
                }

                try
                {
                    con.Open();

                    // Eliminar idiomas
                    string eliminarIdiomas = "DELETE FROM dbo.idiomas WHERE id_usuario = @IdUsuario";
                    SqlCommand cmd1 = new SqlCommand(eliminarIdiomas, con);
                    cmd1.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd1.ExecuteNonQuery();

                    // Eliminar usuario
                    string eliminarUsuario = "DELETE FROM dbo.usuario WHERE id_usuario = @IdUsuario";
                    SqlCommand cmd2 = new SqlCommand(eliminarUsuario, con);
                    cmd2.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Usuario eliminado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
                finally
                {
                    con.Close();
                    CargarUsuarios();
                    idUsuario = 0; // Reset
                }
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
