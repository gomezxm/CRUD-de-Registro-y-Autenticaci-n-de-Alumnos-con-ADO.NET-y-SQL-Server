namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            DialogResult respuesta = MessageBox.Show("¿Desea crear este registro?", "Creacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // ESTE CODIGO ES PARA CREAR UN ALUMNO EN ESPECIFICO
            if (respuesta == DialogResult.Yes)
            {
                // 1. Validen los datos antes de el registro
                // 2. Si el registro esta mal validados no deberia imprimir el mensaje de exito
                // AQUI VA EL CODIGO PARA CERAR EL REGISTRO SELECCIONADO
                MessageBox.Show("Registro creado", "Creacion", MessageBoxButtons.OK, MessageBoxIcon.Information); // ESTE MENSAJE SE DEBE MOSTRAR DESPUES DE CREAR EL REGISTRO
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
