using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class VUptade : Form
    {
        public VUptade()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Semestre.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        // AQUI SE DEBE MODFIICAR UN ESTUDIANTE YA REGISTRADO EN LA BASE DE DATOS
        private void Lb_CreacionTitulo_Click(object sender, EventArgs e)
        {

        }

        private void Bt_Registrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Deseas actualizar este registro?", "Creación",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
                return;

            // ================= VALIDACIONES: NINGÚN CAMPO VACÍO =================

            // 1. Nombre
            if (string.IsNullOrWhiteSpace(Txb_Nombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Error de validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txb_Nombre.Focus();
                return;
            }

            // 2. Contraseña
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("El campo Contraseña es obligatorio.", "Error de validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            // 3. Cédula
            if (string.IsNullOrWhiteSpace(Txb_Cedula.Text) || Txb_Cedula.Text.Length < 12)
            {
                MessageBox.Show("La cédula es obligatoria y debe estar completa.\nEjemplo: 09-1234-5678", "Error de validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txb_Cedula.Focus();
                return;
            }

            // 4. Carrera
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Carrera.", "Error de validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return;
            }

            // 5. Semestre
            if (Cb_Semestre.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Semestre.", "Error de validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cb_Semestre.Focus();
                return;
            }

            // 6. Jornada
            if (!Rb_Matutina.Checked && !Rb_Vespertina.Checked)
            {
                MessageBox.Show("Debe seleccionar una Jornada (Matutina o Vespertina).", "Error de validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ================= SI LLEGA AQUÍ → TODO ESTÁ COMPLETO → REGISTRO EXITOSO =================

            MessageBox.Show("¡Actualización exitosa creado exitosamente!", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Aquí va el codigo para registrar en la base de datos

            // Limpia el formulario para un nuevo registro
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            Txb_Nombre.Clear();
            textBox2.Clear();
            Txb_Cedula.Clear();
            comboBox1.SelectedIndex = -1;
            Cb_Semestre.SelectedIndex = -1;
            Rb_Matutina.Checked = false;
            Rb_Vespertina.Checked = false;
            Txb_Nombre.Focus();
        }
        private void Bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void VUptade_Load(object sender, EventArgs e)
        {

        }

        private void Txb_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txb_Nombre_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = Txb_Nombre;

            string textoActual = tb.Text;
            string soloLetras = "";

            // Recorre cada carácter y solo permite letras (A-Z, a-z) y espacios
            foreach (char c in textoActual)
            {
                if (char.IsLetter(c) || c == ' ')
                {
                    soloLetras += c;
                }
            }

            // Si se eliminó algún carácter no permitido (números, símbolos, etc.)
            if (soloLetras != textoActual)
            {
                int posicionCursor = tb.SelectionStart;

                // Ajusta la posición del cursor (para que no se desplace raro)
                if (soloLetras.Length < textoActual.Length)
                    posicionCursor--;  // Se borró un carácter

                tb.Text = soloLetras;
                tb.SelectionStart = posicionCursor < 0 ? 0 : posicionCursor;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = textBox2;

            string texto = tb.Text;

            // 1. Eliminar todos los espacios (en cualquier posición)
            string sinEspacios = texto.Replace(" ", "");

            // 2. Limitar a máximo 10 caracteres
            if (sinEspacios.Length > 10)
            {
                sinEspacios = sinEspacios.Substring(0, 10);
            }

            // 3. Si hubo cambios (se quitó espacio o se cortó), actualizar el TextBox
            if (texto != sinEspacios)
            {
                int posicionCursor = tb.SelectionStart;

                // Ajustar cursor según cuántos caracteres se eliminaron
                int eliminados = texto.Length - sinEspacios.Length;
                posicionCursor -= eliminados;

                tb.Text = sinEspacios;
                tb.SelectionStart = posicionCursor < 0 ? 0 : posicionCursor;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Forza que sea solo selección 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Txb_Cedula_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = Txb_Cedula;
            string texto = tb.Text;
            string soloValido = "";
            foreach (char c in texto)
            {
                if (char.IsDigit(c) || c == '-') soloValido += c;
            }
            string numeros = soloValido.Replace("-", "");
            if (numeros.Length > 10) numeros = numeros.Substring(0, 10);

            string formateado = "";
            if (numeros.Length > 6)
                formateado = numeros.Substring(0, 2) + "-" + numeros.Substring(2, 4) + "-" + numeros.Substring(6);
            else if (numeros.Length > 2)
                formateado = numeros.Substring(0, 2) + "-" + numeros.Substring(2);
            else
                formateado = numeros;

            if (tb.Text != formateado)
            {
                int posicionCursor = tb.SelectionStart;
                posicionCursor += (formateado.Length - texto.Length);
                tb.Text = formateado;
                tb.SelectionStart = posicionCursor < 0 ? 0 : posicionCursor;
                if (tb.SelectionStart > formateado.Length) tb.SelectionStart = formateado.Length;
            }
        }

        private void Cb_Semestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cb_Semestre.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
