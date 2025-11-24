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
    public partial class VUptade : Form
    {
        public VUptade()
        {
            InitializeComponent();
        }
        // AQUI SE DEBE MODFIICAR UN ESTUDIANTE YA REGISTRADO EN LA BASE DE DATOS
        private void Lb_CreacionTitulo_Click(object sender, EventArgs e)
        {

        }

        private void Bt_Registrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea crear este registro?", "Creacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // ESTE CODIGO ES PARA ACTUALIZAR UN ALUMNO EN ESPECIFICO
            if (respuesta == DialogResult.Yes)
            {
                // 1. Validen los datos antes de el EJECUTAR registro
                // 2. Si el registro esta mal validados no deberia imprimir el mensaje de exito
                // AQUI VA EL CODIGO PARA ACTUALIZAR EL REGISTRO SELECCIONADO
                MessageBox.Show("Registro creado", "Creacion", MessageBoxButtons.OK, MessageBoxIcon.Information); // ESTE MENSAJE SE DEBE MOSTRAR DESPUES DE ACTUALIZAR EL REGISTRO
            }
        }
        private void Bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }
    }
}
