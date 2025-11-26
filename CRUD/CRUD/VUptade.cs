using System;
using System.Data;
using System.Windows.Forms;

namespace CRUD
{
    public partial class VUptade : Form
    {
        private readonly EstudianteRepository _repo = new EstudianteRepository();
        public int IdEstudiante { get; set; } = 0; // Se asigna desde Viewer

        public VUptade()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Semestre.DropDownStyle = ComboBoxStyle.DropDownList;
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                Bt_Actualizar.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void VUptade_Load(object sender, EventArgs e)
        {
            CargarDatosEstudiante();
        }

        private void CargarDatosEstudiante()
        {
            if (IdEstudiante <= 0) return;

            try
            {
                DataRow fila = _repo.ObtenerPorId(IdEstudiante);
                if (fila != null)
                {
                    Txb_Nombre.Text = fila["Nombre"].ToString();
                    Txb_Cedula.Text = fila["Cedula"].ToString();
                    textBox2.Text = fila["Contraseña"].ToString();
                    comboBox1.SelectedItem = fila["Carrera"].ToString();
                    Cb_Semestre.SelectedItem = fila["Semestre"].ToString();

                    if (fila["Jornada"].ToString() == "Matutina")
                        Rb_Matutina.Checked = true;
                    else
                        Rb_Vespertina.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
            }
        }

        private void Bt_Actualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            DialogResult resp = MessageBox.Show("¿Deseas guardar los cambios?", "Actualizar registro",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.No) return;

            string jornada = Rb_Matutina.Checked ? "Matutina" : "Vespertina";

            try
            {
                bool exito = _repo.Actualizar(
                    IdEstudiante,
                    Txb_Nombre.Text.Trim(),
                    Txb_Cedula.Text.Trim(),
                    textBox2.Text,
                    comboBox1.SelectedItem.ToString(),
                    Cb_Semestre.SelectedItem.ToString(),
                    jornada
                );

                if (exito)
                {
                    MessageBox.Show("¡Estudiante actualizado correctamente!", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(Txb_Nombre.Text))
            { MessageBox.Show("El nombre es obligatorio."); Txb_Nombre.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            { MessageBox.Show("La contraseña es obligatoria."); textBox2.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(Txb_Cedula.Text) || Txb_Cedula.Text.Length < 12)
            { MessageBox.Show("La cédula debe estar completa (ej: 09-1234-5678)."); Txb_Cedula.Focus(); return false; }

            if (comboBox1.SelectedIndex == -1)
            { MessageBox.Show("Selecciona una carrera."); comboBox1.Focus(); return false; }

            if (Cb_Semestre.SelectedIndex == -1)
            { MessageBox.Show("Selecciona un semestre."); Cb_Semestre.Focus(); return false; }

            if (!Rb_Matutina.Checked && !Rb_Vespertina.Checked)
            { MessageBox.Show("Selecciona una jornada."); return false; }

            return true;
        }

        private void Bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Tus eventos de validación de TextBox (Txb_Nombre, textBox2, Txb_Cedula, etc.) se mantienen igual
        // (los que ya tenías para solo letras, formato cédula, etc.)
    }
}