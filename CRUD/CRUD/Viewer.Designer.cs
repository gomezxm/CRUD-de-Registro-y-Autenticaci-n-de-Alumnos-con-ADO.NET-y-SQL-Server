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
            listBox1 = new ListBox();
            Lb_Contraseña = new Label();
            textBox2 = new TextBox();
            Jornada = new Label();
            Lb_Semestre = new Label();
            Lb_Cedula = new Label();
            Txb_Cedula = new TextBox();
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
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            Lb_Jornada = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "1- Gerardo Tejada - Desarrollo en Software - Matutina" });
            listBox1.Location = new Point(473, 49);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(428, 324);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // Lb_Contraseña
            // 
            Lb_Contraseña.AutoSize = true;
            Lb_Contraseña.Location = new Point(39, 218);
            Lb_Contraseña.Name = "Lb_Contraseña";
            Lb_Contraseña.Size = new Size(83, 20);
            Lb_Contraseña.TabIndex = 34;
            Lb_Contraseña.Text = "Contraseña";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(39, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 33;
            // 
            // Jornada
            // 
            Jornada.AutoSize = true;
            Jornada.Location = new Point(357, 153);
            Jornada.Name = "Jornada";
            Jornada.Size = new Size(0, 20);
            Jornada.TabIndex = 29;
            // 
            // Lb_Semestre
            // 
            Lb_Semestre.AutoSize = true;
            Lb_Semestre.Location = new Point(246, 82);
            Lb_Semestre.Name = "Lb_Semestre";
            Lb_Semestre.Size = new Size(70, 20);
            Lb_Semestre.TabIndex = 28;
            Lb_Semestre.Text = "Semestre";
            // 
            // Lb_Cedula
            // 
            Lb_Cedula.AutoSize = true;
            Lb_Cedula.Location = new Point(39, 288);
            Lb_Cedula.Name = "Lb_Cedula";
            Lb_Cedula.Size = new Size(55, 20);
            Lb_Cedula.TabIndex = 27;
            Lb_Cedula.Text = "Cédula";
            // 
            // Txb_Cedula
            // 
            Txb_Cedula.Enabled = false;
            Txb_Cedula.Location = new Point(39, 311);
            Txb_Cedula.Name = "Txb_Cedula";
            Txb_Cedula.Size = new Size(125, 27);
            Txb_Cedula.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 216);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 25;
            label1.Text = "Carrera";
            // 
            // Lb_Nombre
            // 
            Lb_Nombre.AutoSize = true;
            Lb_Nombre.Location = new Point(39, 153);
            Lb_Nombre.Name = "Lb_Nombre";
            Lb_Nombre.Size = new Size(64, 20);
            Lb_Nombre.TabIndex = 24;
            Lb_Nombre.Text = "Nombre";
            // 
            // Txb_Nombre
            // 
            Txb_Nombre.Enabled = false;
            Txb_Nombre.Location = new Point(39, 176);
            Txb_Nombre.Name = "Txb_Nombre";
            Txb_Nombre.Size = new Size(125, 27);
            Txb_Nombre.TabIndex = 23;
            // 
            // Txb_ID
            // 
            Txb_ID.Enabled = false;
            Txb_ID.Location = new Point(39, 105);
            Txb_ID.Name = "Txb_ID";
            Txb_ID.Size = new Size(125, 27);
            Txb_ID.TabIndex = 22;
            // 
            // Lb_ID
            // 
            Lb_ID.AutoSize = true;
            Lb_ID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_ID.Location = new Point(39, 82);
            Lb_ID.Name = "Lb_ID";
            Lb_ID.Size = new Size(25, 20);
            Lb_ID.TabIndex = 21;
            Lb_ID.Text = "ID";
            // 
            // Lb_Titulo
            // 
            Lb_Titulo.AutoSize = true;
            Lb_Titulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Titulo.Location = new Point(113, 32);
            Lb_Titulo.Name = "Lb_Titulo";
            Lb_Titulo.Size = new Size(287, 38);
            Lb_Titulo.TabIndex = 37;
            Lb_Titulo.Text = "Datos del estudiante";
            Lb_Titulo.Click += Lb_Titulo_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { crearToolStripMenuItem, cargarDatosToolStripMenuItem, actualizarDatosToolStripMenuItem, eliminarToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(924, 28);
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
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(246, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 39;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(246, 239);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 40;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(246, 176);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 41;
            // 
            // Lb_Jornada
            // 
            Lb_Jornada.AutoSize = true;
            Lb_Jornada.Location = new Point(246, 154);
            Lb_Jornada.Name = "Lb_Jornada";
            Lb_Jornada.Size = new Size(61, 20);
            Lb_Jornada.TabIndex = 42;
            Lb_Jornada.Text = "Jornada";
            // 
            // Viewer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 397);
            Controls.Add(Lb_Jornada);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(Lb_Titulo);
            Controls.Add(Lb_Contraseña);
            Controls.Add(textBox2);
            Controls.Add(Jornada);
            Controls.Add(Lb_Semestre);
            Controls.Add(Lb_Cedula);
            Controls.Add(Txb_Cedula);
            Controls.Add(label1);
            Controls.Add(Lb_Nombre);
            Controls.Add(Txb_Nombre);
            Controls.Add(Txb_ID);
            Controls.Add(Lb_ID);
            Controls.Add(listBox1);
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
        private ListBox listBox1;
        private Label Lb_Contraseña;
        private TextBox textBox2;
        private Label Jornada;
        private Label Lb_Semestre;
        private Label Lb_Cedula;
        private TextBox Txb_Cedula;
        private Label label1;
        private Label Lb_Nombre;
        private TextBox Txb_Nombre;
        private TextBox Txb_ID;
        private Label Lb_ID;
        private Label Lb_Titulo;
        private MenuStrip menuStrip1;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label Lb_Jornada;
        private ToolStripMenuItem crearToolStripMenuItem;
        private ToolStripMenuItem cargarDatosToolStripMenuItem;
        private ToolStripMenuItem actualizarDatosToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}