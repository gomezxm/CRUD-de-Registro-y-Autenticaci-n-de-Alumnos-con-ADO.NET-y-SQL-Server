using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
            Lsb_Alumnos.SelectionMode = SelectionMode.One;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Viewer_Load(object sender, EventArgs e)
        {

        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void prueba2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Lb_Titulo_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e) // VENTANA PARA CREAR NUEVOS REGISTROS
        {
            Form1 VCrear = new Form1();
            VCrear.ShowDialog();
        }

        private void actualizarDatosToolStripMenuItem_Click(object sender, EventArgs e) // VENTANA PARA ACTUALIZAR REGISTROS
        {
            VUptade VActualizar = new VUptade();
            VActualizar.ShowDialog();

        }

        private void cargarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // AQUI SE DEBE ACTUALIZAR LA TABLA PARA VER LOS NUEVOS DATOS O VER DATOS (SE DEBE SELECCIONAR UN ESTUDIANTE)
            MessageBox.Show("Datos cargados", "Carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Information); // ESTE MENSAJE SE DEBE MOSTRAR DESPUES DE CARGAR LOS DATOS
        }


        /// PARA DANIEL, CUANDO SE VA A EJECUTAR UNA CRUD EL PROCESO ES: 1. SELECCIONA UN REGISTRO EN EL LISTBOX, 2. LUEGO TOCAR UN BOTON
        /// NO PUEDE EJECUTAR UNA FUNCION SIN HABERLO SELECCIONADO
        /// LAS VALIDACIONES PARA TODOS LOS CAMPOS DEPENDE LO QUE DIGA EL GAY DE MIGUEL PERO LA MAYORIA ES DE PURA LOGICA (QUE EL NOMBRE NO DEBE TENER SIMBOLOS EXTRAÑOS, SIN ESPACIOS EN BLANCO, ECT).
        
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea eliminar este registro?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // ESTE CODIGO ES PARA ELIMINAR UN ALUMNO EN ESPECIFICO
            if (respuesta == DialogResult.Yes)
            {
                // AQUI VA EL CODIGO PARA ELIMINAR EL REGISTRO !!!!!!!!SELECCIONADO!!!!!!!!
                MessageBox.Show("Registro eliminado", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // ESTE MENSAJE SE DEBE MOSTRAR DESPUES DE ELIMINAR EL REGISTRO
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose(); // AQUI SE CIERRA EL PROGRAMA
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            // CUANDO SE SELECCIONE UN ESTUDIANTE EN EL LISTBOX SE DEBE MOSTRAR EN LOS CAMPOS EN Viewer
            // Si hay una columna en el ListBox, borrenla ya que solo es de referencia el formato de como debe verse el ListBoxs
            
            if (Lsb_Alumnos.SelectedItem != null)
            {
                string[] b = Lsb_Alumnos.SelectedItem.ToString().Split('-');
                Txb_ID.Text = b[0].Trim();
                Txb_Nombre.Text = b[1].Trim();
                Txb_carrera.Text = b[2].Trim();
                txb_jornada.Text = b[3].Trim();
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txb_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void conectaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ESTA PARTE ES PARA CONECTAR A LA BASE DE DATOS
            MessageBox.Show("Conectando...","Conexion base de daos",MessageBoxButtons.OK);
        }
    }
}
