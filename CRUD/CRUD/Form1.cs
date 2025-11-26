namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Asigna ESC como atajo para el menú "Crear"
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Semestre.DropDownStyle = ComboBoxStyle.DropDownList;
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
                Bt_Registrar.PerformClick();

                // Evita que se escriba la "S" en el control que tenga el foco y el "beep"
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            string texto = tb.Text;

            // 1. Eliminar todo lo que NO sea número o guion
            string soloNumerosYGuion = "";
            foreach (char c in texto)
            {
                if (char.IsDigit(c) || c == '-')
                    soloNumerosYGuion += c;
            }
            //
            // 2. Aplicar automáticamente el formato deseado mientras el usuario escribe
            string formateado = "";
            string numeros = soloNumerosYGuion.Replace("-", ""); // solo dígitos puros

            if (numeros.Length > 0)
            {
                // Tomar máximo 10 dígitos (cédulas típicas: 10 u 11)
                if (numeros.Length > 10) numeros = numeros.Substring(0, 10);

                if (numeros.Length >= 2)
                {
                    formateado = numeros.Substring(0, 2);
                    if (numeros.Length > 2)
                    {
                        formateado += "-" + numeros.Substring(2, numeros.Length - 2 > 4 ? 4 : numeros.Length - 2);
                        if (numeros.Length > 6)
                        {
                            string parteFinal = numeros.Substring(6);
                            if (parteFinal.Length > 4) parteFinal = parteFinal.Substring(0, 4);
                            formateado += "-" + parteFinal;
                        }
                    }
                }
                else
                {
                    formateado = numeros;
                }
            }

            // 3. Si el texto cambió, actualizar y mantener el cursor en la posición correcta
            if (tb.Text != formateado)
            {
                int posicion = tb.SelectionStart;

                // Ajustar posición del cursor según lo que se eliminó o agregó
                tb.Text = formateado;
                tb.SelectionStart = posicion + (formateado.Length - texto.Length);
                if (tb.SelectionStart < 0) tb.SelectionStart = 0;
                if (tb.SelectionStart > formateado.Length) tb.SelectionStart = formateado.Length;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Rb_Vespertina_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rb_Matutina_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Bt_Registrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea crear este registro?", "Creación",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
                return;

            // =================== VALIDACIONES CON LOS NOMBRES REALES ===================

            // 1. NOMBRE (es tu textBox1 → pero en realidad se llama como lo creaste)
            // Usa el nombre exacto del TextBox del nombre (el que tiene el evento textBox1_TextChanged_1)
            if (string.IsNullOrWhiteSpace(Txb_Nombre.Text.Trim()))
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txb_Nombre.Focus();
                return;
            }

            // 2. CONTRASEÑA (el que tiene el evento textBox2_TextChanged)
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("El campo Contraseña es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            // 3. CÉDULA (el que tiene el evento textBox3_TextChanged)
            if (string.IsNullOrWhiteSpace(comboBox1.Text) || comboBox1.Text.Length < 12)
            {
                MessageBox.Show("La cédula debe estar completa y con formato correcto.\nEjemplo: 09-1234-5678", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return;
            }

            // 4. CARRERA (el ComboBox que bloqueamos antes)
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Carrera.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return;
            }

            // 5. SEMESTRE
            if (Cb_Semestre.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Semestre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cb_Semestre.Focus();
                return;
            }

            // 6. JORNADA
            if (!Rb_Matutina.Checked && !Rb_Vespertina.Checked)
            {
                MessageBox.Show("Debe seleccionar una Jornada (Matutina o Vespertina).", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string jornada = Rb_Matutina.Checked ? "Matutina" : "Vespertina";

            var repo = new EstudianteRepository();
            bool exito = repo.Insertar(
                Txb_Nombre.Text.Trim(),
                Txb_Cedula.Text.Trim(),
                textBox2.Text,                    // ← Contraseña
                comboBox1.SelectedItem.ToString(),
                Cb_Semestre.SelectedItem.ToString(),
                jornada
            );

            if (exito)
            {
                MessageBox.Show("¡Estudiante registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar. Puede que la cédula ya exista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // =================== TODO CORRECTO → REGISTRO EXITOSO ===================
            MessageBox.Show("¡Registro creado exitosamente!", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpia el formulario para el siguiente registro
            LimpiarCampos();
        }

        // Método para limpiar todos los campos (opcional pero muy útil)
        private void LimpiarCampos()
        {
            Txb_Nombre.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            Cb_Semestre.SelectedIndex = -1;
            Rb_Matutina.Checked = false;
            Rb_Vespertina.Checked = false;
            Txb_Nombre.Focus();
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // Este método se ejecuta cada vez que cambia el texto
            TextBox tb = sender as TextBox;

            if (tb == null) return;

            string textoActual = tb.Text;
            string textoFiltrado = "";

            // Recorremos cada carácter y solo dejamos letras y espacios
            foreach (char c in textoActual)
            {
                if (char.IsLetter(c) || c == ' ')
                {
                    textoFiltrado += c;
                }
            }

            // Si el texto cambió (se eliminaron caracteres no permitidos)
            if (textoFiltrado != textoActual)
            {
                // Guardamos la posición del cursor
                int posicionCursor = tb.SelectionStart;

                // Si se borró un carácter, ajustamos la posición
                if (textoFiltrado.Length < textoActual.Length)
                    posicionCursor--;

                tb.Text = textoFiltrado;
                tb.SelectionStart = posicionCursor < 0 ? 0 : posicionCursor; // Evita índices negativos
            }
        }

        private void Bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = textBox2;

            string texto = tb.Text.Replace(" ", ""); // Elimina todos los espacios

            if (texto.Length > 10)
                texto = texto.Substring(0, 10);

            if (tb.Text != texto)
            {
                int pos = tb.SelectionStart;
                // Ajusta la posición del cursor si se eliminó un espacio o se cortó
                if (tb.Text.Length > texto.Length)
                    pos -= (tb.Text.Length - texto.Length);

                tb.Text = texto;
                tb.SelectionStart = pos < 0 ? 0 : pos;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Forza al ComboBox a ser de solo selección (no editable)
            if (comboBox1.DropDownStyle != ComboBoxStyle.DropDownList)
            {
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void Cb_Semestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Forza que el ComboBox sea de solo selección (NO editable)
            Cb_Semestre.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
