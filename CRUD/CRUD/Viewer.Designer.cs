namespace CRUD
{
    partial class Viewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Lsb_Alumnos = new ListBox();
            Jornada = new Label();
            label1 = new Label();
            Lb_Nombre = new Label();
            Txb_Nombre = new TextBox();
            Txb_ID = new TextBox();
            Lb_ID = new Label();
            Lb_Titulo = new Label();
            menuStrip1 = new MenuStrip();
            crearToolStripMenuItem = new ToolStripMenuItem();
            cargarDatosToolStripMenuItem = new ToolStripMenuItem();
            actualizarDatosToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            generarReporteToolStripMenuItem = new ToolStripMenuItem();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            conectaToolStripMenuItem = new ToolStripMenuItem();
            Txb_carrera = new TextBox();
            txb_jornada = new TextBox();
            Lb_Jornada = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Lsb_Alumnos
            // 
            Lsb_Alumnos.FormattingEnabled = true;
            Lsb_Alumnos.Items.AddRange(new object[] { "ID — Nombre — Carrera — Jornada", "01 - Gerardo Tejada - Desarrollo de software - Matutina" });
            Lsb_Alumnos.Location = new Point(12, 308);
            Lsb_Alumnos.Name = "Lsb_Alumnos";
            Lsb_Alumnos.Size = new Size(633, 144);
            Lsb_Alumnos.TabIndex = 0;
            // 
            // Jornada
            // 
            Jornada.AutoSize = true;
            Jornada.Location = new Point(113, 164);
            Jornada.Name = "Jornada";
            Jornada.Size = new Size(0, 20);
            Jornada.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 176);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 25;
            label1.Text = "CARRERA";
            // 
            // Lb_Nombre
            // 
            Lb_Nombre.AutoSize = true;
            Lb_Nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Nombre.Location = new Point(409, 102);
            Lb_Nombre.Name = "Lb_Nombre";
            Lb_Nombre.Size = new Size(74, 20);
            Lb_Nombre.TabIndex = 24;
            Lb_Nombre.Text = "NOMBRE";
            // 
            // Txb_Nombre
            // 
            Txb_Nombre.Enabled = false;
            Txb_Nombre.Location = new Point(409, 125);
            Txb_Nombre.Name = "Txb_Nombre";
            Txb_Nombre.Size = new Size(191, 27);
            Txb_Nombre.TabIndex = 23;
            // 
            // Txb_ID
            // 
            Txb_ID.Enabled = false;
            Txb_ID.Location = new Point(65, 125);
            Txb_ID.Name = "Txb_ID";
            Txb_ID.Size = new Size(192, 27);
            Txb_ID.TabIndex = 22;
            // 
            // Lb_ID
            // 
            Lb_ID.AutoSize = true;
            Lb_ID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_ID.Location = new Point(65, 102);
            Lb_ID.Name = "Lb_ID";
            Lb_ID.Size = new Size(25, 20);
            Lb_ID.TabIndex = 21;
            Lb_ID.Text = "ID";
            // 
            // Lb_Titulo
            // 
            Lb_Titulo.AutoSize = true;
            Lb_Titulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Titulo.Location = new Point(176, 47);
            Lb_Titulo.Name = "Lb_Titulo";
            Lb_Titulo.Size = new Size(330, 38);
            Lb_Titulo.TabIndex = 37;
            Lb_Titulo.Text = "DATOS DE ESTUDIANTE";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { crearToolStripMenuItem, cargarDatosToolStripMenuItem, actualizarDatosToolStripMenuItem, eliminarToolStripMenuItem, salirToolStripMenuItem, generarReporteToolStripMenuItem, opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(657, 28);
            menuStrip1.TabIndex = 38;
            menuStrip1.Text = "menuStrip1";
            // 
            // crearToolStripMenuItem
            // 
            crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            crearToolStripMenuItem.Size = new Size(58, 24);
            crearToolStripMenuItem.Text = "Crear";
            crearToolStripMenuItem.Click += crearToolStripMenuItem_Click;
            // 
            // cargarDatosToolStripMenuItem
            // 
            cargarDatosToolStripMenuItem.Name = "cargarDatosToolStripMenuItem";
            cargarDatosToolStripMenuItem.Size = new Size(108, 24);
            cargarDatosToolStripMenuItem.Text = "Cargar datos";
            cargarDatosToolStripMenuItem.Click += cargarDatosToolStripMenuItem_Click;
            // 
            // actualizarDatosToolStripMenuItem
            // 
            actualizarDatosToolStripMenuItem.Name = "actualizarDatosToolStripMenuItem";
            actualizarDatosToolStripMenuItem.Size = new Size(130, 24);
            actualizarDatosToolStripMenuItem.Text = "Actualizar datos";
            actualizarDatosToolStripMenuItem.Click += actualizarDatosToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(77, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // generarReporteToolStripMenuItem
            // 
            generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            generarReporteToolStripMenuItem.Size = new Size(128, 24);
            generarReporteToolStripMenuItem.Text = "Generar reporte";
            generarReporteToolStripMenuItem.Click += generarReporteToolStripMenuItem_Click;
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { conectaToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(85, 24);
            opcionesToolStripMenuItem.Text = "Opciones";
            opcionesToolStripMenuItem.Click += opcionesToolStripMenuItem_Click;
            // 
            // conectaToolStripMenuItem
            // 
            conectaToolStripMenuItem.Name = "conectaToolStripMenuItem";
            conectaToolStripMenuItem.Size = new Size(146, 26);
            conectaToolStripMenuItem.Text = "Conecta";
            conectaToolStripMenuItem.Click += conectaToolStripMenuItem_Click;
            // 
            // Txb_carrera
            // 
            Txb_carrera.Enabled = false;
            Txb_carrera.Location = new Point(65, 199);
            Txb_carrera.Name = "Txb_carrera";
            Txb_carrera.Size = new Size(191, 27);
            Txb_carrera.TabIndex = 40;
            // 
            // txb_jornada
            // 
            txb_jornada.Enabled = false;
            txb_jornada.Location = new Point(409, 199);
            txb_jornada.Name = "txb_jornada";
            txb_jornada.Size = new Size(191, 27);
            txb_jornada.TabIndex = 41;
            // 
            // Lb_Jornada
            // 
            Lb_Jornada.AutoSize = true;
            Lb_Jornada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Jornada.Location = new Point(409, 176);
            Lb_Jornada.Name = "Lb_Jornada";
            Lb_Jornada.Size = new Size(82, 20);
            Lb_Jornada.TabIndex = 42;
            Lb_Jornada.Text = "JORNADA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 271);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 43;
            label2.Text = "ALUMNO";
            // 
            // Viewer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 466);
            Controls.Add(label2);
            Controls.Add(Lb_Jornada);
            Controls.Add(txb_jornada);
            Controls.Add(Txb_carrera);
            Controls.Add(Lb_Titulo);
            Controls.Add(Jornada);
            Controls.Add(label1);
            Controls.Add(Lb_Nombre);
            Controls.Add(Txb_Nombre);
            Controls.Add(Txb_ID);
            Controls.Add(Lb_ID);
            Controls.Add(Lsb_Alumnos);
            Controls.Add(menuStrip1);
            Name = "Viewer";
            Text = "Viewer";
            Load += Viewer_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TablapRUEBA;
        private DataGridViewTextBoxColumn Prueba;
        private DataGridViewTextBoxColumn Column1;
        private ListBox Lsb_Alumnos;
        private Label Jornada;
        private Label label1;
        private Label Lb_Nombre;
        private TextBox Txb_Nombre;
        private TextBox Txb_ID;
        private Label Lb_ID;
        private Label Lb_Titulo;
        private MenuStrip menuStrip1;
        private TextBox Txb_carrera;
        private TextBox txb_jornada;
        private Label Lb_Jornada;
        private ToolStripMenuItem crearToolStripMenuItem;
        private ToolStripMenuItem cargarDatosToolStripMenuItem;
        private ToolStripMenuItem actualizarDatosToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem conectaToolStripMenuItem;
        private Label label2;
        private ToolStripMenuItem generarReporteToolStripMenuItem;
    }
}