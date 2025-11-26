using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;

            // Suscribimos el evento KeyDown
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Ctrl + S → Guardar / Registrar
            if (e.Control && e.KeyCode == Keys.S)
            {
                // Ejecuta exactamente el mismo código que al hacer clic en el botón
                button1.PerformClick();

                // Evita que se escriba la "S" en el control que tenga el foco y el "beep"
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Lb_CreacionTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cedula = txt_NmbrUsuario.Text.Trim();     // Usas cédula como "usuario"
            string contrasena = textBox2.Text;

            if (string.IsNullOrWhiteSpace(cedula) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Ingresa nombre y contraseña.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString);
                conn.Open();

                string sql = "SELECT COUNT(1) FROM Estudiantes WHERE Cedula = @Cedula AND Contrasena = @Pass";
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Cedula", cedula);
                cmd.Parameters.AddWithValue("@Pass", contrasena);

                int existe = (int)cmd.ExecuteScalar();

                if (existe > 0)
                {
                    MessageBox.Show("¡Bienvenido al sistema!", "Acceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Viewer().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cédula o contraseña incorrecta.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Clear();
                    textBox2.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión:\n" + ex.Message +
                    "\n\nVerifica que:\n" +
                    "1. La base de datos 'Alumno' exista\n" +
                    "2. La tabla 'Estudiantes' esté creada\n" +
                    "3. App.config tenga la cadena correcta",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
