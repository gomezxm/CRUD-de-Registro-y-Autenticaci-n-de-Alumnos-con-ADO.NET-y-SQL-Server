using System;
using System.Configuration;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Viewer : Form
    {
        private readonly EstudianteRepository _repo = new EstudianteRepository();

        public Viewer()
        {
            InitializeComponent();
            Lsb_Alumnos.SelectionMode = SelectionMode.One;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;
            this.KeyDown += FormPrincipal_KeyDown;

            // Atajos de menú
            actualizarDatosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            actualizarDatosToolStripMenuItem.ShowShortcutKeys = true;
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D)
            {
                eliminarToolStripMenuItem.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                crearToolStripMenuItem.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            CargarEstudiantes();
        }

        private void CargarEstudiantes()
        {
            try
            {
                var lista = _repo.ObtenerTodos();
                Lsb_Alumnos.Items.Clear();
                foreach (var item in lista)
                    Lsb_Alumnos.Items.Add(item);

                if (Lsb_Alumnos.Items.Count > 0)
                    Lsb_Alumnos.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estudiantes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formCrear = new Form1();
            if (formCrear.ShowDialog() == DialogResult.OK)
                CargarEstudiantes();
        }

        private void actualizarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Lsb_Alumnos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un estudiante para actualizar.", "Seleccionar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string seleccionado = Lsb_Alumnos.SelectedItem.ToString();
            int id = int.Parse(seleccionado.Split('-')[0].Trim());

            VUptade formUpdate = new VUptade
            {
                IdEstudiante = id
            };

            if (formUpdate.ShowDialog() == DialogResult.OK)
                CargarEstudiantes();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Lsb_Alumnos.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un estudiante para eliminar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string seleccionado = Lsb_Alumnos.SelectedItem.ToString();
            int id = int.Parse(seleccionado.Split('-')[0].Trim());
            string nombre = seleccionado.Split('-')[1].Trim();

            DialogResult respuesta = MessageBox.Show(
                $"¿Estás seguro de eliminar a:\n{nombre}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    if (_repo.Eliminar(id))
                    {
                        MessageBox.Show("Estudiante eliminado correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarEstudiantes();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cargarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarEstudiantes();
            MessageBox.Show("Datos actualizados correctamente.", "Carga de datos",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void conectaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(
                    ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString))
                {
                    conn.Open();
                    MessageBox.Show("¡Conexión exitosa a la base de datos!", "Conexión",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Muestra datos del estudiante seleccionado en los TextBox (opcional)
        private void Lsb_Alumnos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Lsb_Alumnos.SelectedItem == null) return;

            string[] partes = Lsb_Alumnos.SelectedItem.ToString().Split('-');
            if (partes.Length >= 4)
            {
                Txb_ID.Text = partes[0].Trim();
                Txb_Nombre.Text = partes[1].Trim();
                Txb_carrera.Text = partes[2].Trim();
                txb_jornada.Text = partes[3].Trim();
            }
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VGenerarReportes GREPORTES = new VGenerarReportes();
            GREPORTES.ShowDialog();
        }
    }
}