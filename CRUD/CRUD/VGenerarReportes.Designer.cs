namespace CRUD
{
    partial class VGenerarReportes
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
            Lb_TGR = new Label();
            lb_General_Estuidante = new Label();
            lb_PorCarrera = new Label();
            lb_porJornada = new Label();
            bt_alumnosFechas = new Button();
            lb_alumnosFechas = new Label();
            lb_alumnoSeleccionado = new Label();
            cmbJornada = new ComboBox();
            button1 = new Button();
            cb_porCarrera = new ComboBox();
            bt_GeneralEstudiante = new Button();
            bt_porCarrera = new Button();
            bt_Jornada = new Button();
            cb_jornada = new ComboBox();
            lsb_Estudiante = new ListBox();
            bt_AlumSelecionado = new Button();
            btnRefrescar = new Button();
            SuspendLayout();
            // 
            // Lb_TGR
            // 
            Lb_TGR.AutoSize = true;
            Lb_TGR.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_TGR.Location = new Point(130, 9);
            Lb_TGR.Name = "Lb_TGR";
            Lb_TGR.Size = new Size(217, 38);
            Lb_TGR.TabIndex = 38;
            Lb_TGR.Text = "ELIGE REPORTE";
            Lb_TGR.Click += Lb_Titulo_Click;
            // 
            // lb_General_Estuidante
            // 
            lb_General_Estuidante.AutoSize = true;
            lb_General_Estuidante.Location = new Point(340, 62);
            lb_General_Estuidante.Name = "lb_General_Estuidante";
            lb_General_Estuidante.Size = new Size(197, 20);
            lb_General_Estuidante.TabIndex = 39;
            lb_General_Estuidante.Text = "Reporte general de alumnos";
            lb_General_Estuidante.Click += lb_General_Estuidante_Click;
            // 
            // lb_PorCarrera
            // 
            lb_PorCarrera.AutoSize = true;
            lb_PorCarrera.Location = new Point(340, 111);
            lb_PorCarrera.Name = "lb_PorCarrera";
            lb_PorCarrera.Size = new Size(139, 20);
            lb_PorCarrera.TabIndex = 42;
            lb_PorCarrera.Text = "Reporte por carrera";
            // 
            // lb_porJornada
            // 
            lb_porJornada.AutoSize = true;
            lb_porJornada.Location = new Point(341, 157);
            lb_porJornada.Name = "lb_porJornada";
            lb_porJornada.Size = new Size(144, 20);
            lb_porJornada.TabIndex = 44;
            lb_porJornada.Text = "Reporte por jornada";
            // 
            // bt_alumnosFechas
            // 
            bt_alumnosFechas.Location = new Point(21, 213);
            bt_alumnosFechas.Name = "bt_alumnosFechas";
            bt_alumnosFechas.Size = new Size(94, 29);
            bt_alumnosFechas.TabIndex = 45;
            bt_alumnosFechas.UseVisualStyleBackColor = true;
            // 
            // lb_alumnosFechas
            // 
            lb_alumnosFechas.AutoSize = true;
            lb_alumnosFechas.Location = new Point(130, 217);
            lb_alumnosFechas.Name = "lb_alumnosFechas";
            lb_alumnosFechas.Size = new Size(371, 20);
            lb_alumnosFechas.TabIndex = 46;
            lb_alumnosFechas.Text = "Reporte de alumnos registrados en un rango de fechas";
            // 
            // lb_alumnoSeleccionado
            // 
            lb_alumnoSeleccionado.AutoSize = true;
            lb_alumnoSeleccionado.Location = new Point(340, 274);
            lb_alumnoSeleccionado.Name = "lb_alumnoSeleccionado";
            lb_alumnoSeleccionado.Size = new Size(216, 20);
            lb_alumnoSeleccionado.TabIndex = 48;
            lb_alumnoSeleccionado.Text = " Perfil del alumno seleccionado";
            // 
            // cmbJornada
            // 
            cmbJornada.FormattingEnabled = true;
            cmbJornada.Items.AddRange(new object[] { "Todas", "Matutina", "Vespertina" });
            cmbJornada.Location = new Point(21, 59);
            cmbJornada.Name = "cmbJornada";
            cmbJornada.Size = new Size(177, 28);
            cmbJornada.TabIndex = 49;
            // 
            // button1
            // 
            button1.Location = new Point(530, 359);
            button1.Name = "button1";
            button1.Size = new Size(145, 29);
            button1.TabIndex = 50;
            button1.Text = "boton Prueba";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cb_porCarrera
            // 
            cb_porCarrera.FormattingEnabled = true;
            cb_porCarrera.Items.AddRange(new object[] { "Ingenieria software", "Desarrollo en software" });
            cb_porCarrera.Location = new Point(21, 107);
            cb_porCarrera.Name = "cb_porCarrera";
            cb_porCarrera.Size = new Size(177, 28);
            cb_porCarrera.TabIndex = 51;
            // 
            // bt_GeneralEstudiante
            // 
            bt_GeneralEstudiante.Location = new Point(218, 62);
            bt_GeneralEstudiante.Name = "bt_GeneralEstudiante";
            bt_GeneralEstudiante.Size = new Size(94, 29);
            bt_GeneralEstudiante.TabIndex = 52;
            bt_GeneralEstudiante.Text = "Generar";
            bt_GeneralEstudiante.UseVisualStyleBackColor = true;
            bt_GeneralEstudiante.Click += bt_GeneralEstudiante_Click_1;
            // 
            // bt_porCarrera
            // 
            bt_porCarrera.Location = new Point(218, 107);
            bt_porCarrera.Name = "bt_porCarrera";
            bt_porCarrera.Size = new Size(94, 29);
            bt_porCarrera.TabIndex = 53;
            bt_porCarrera.Text = "Generar";
            bt_porCarrera.UseVisualStyleBackColor = true;
            bt_porCarrera.Click += bt_porCarrera_Click_1;
            // 
            // bt_Jornada
            // 
            bt_Jornada.Location = new Point(218, 157);
            bt_Jornada.Name = "bt_Jornada";
            bt_Jornada.Size = new Size(94, 29);
            bt_Jornada.TabIndex = 54;
            bt_Jornada.Text = "Generar";
            bt_Jornada.UseVisualStyleBackColor = true;
            bt_Jornada.Click += bt_Jornada_Click;
            // 
            // cb_jornada
            // 
            cb_jornada.FormattingEnabled = true;
            cb_jornada.Items.AddRange(new object[] { "Matutina", "Vespertina" });
            cb_jornada.Location = new Point(21, 158);
            cb_jornada.Name = "cb_jornada";
            cb_jornada.Size = new Size(177, 28);
            cb_jornada.TabIndex = 55;
            // 
            // lsb_Estudiante
            // 
            lsb_Estudiante.FormattingEnabled = true;
            lsb_Estudiante.Location = new Point(21, 274);
            lsb_Estudiante.Name = "lsb_Estudiante";
            lsb_Estudiante.Size = new Size(177, 104);
            lsb_Estudiante.TabIndex = 56;
            // 
            // bt_AlumSelecionado
            // 
            bt_AlumSelecionado.Location = new Point(218, 274);
            bt_AlumSelecionado.Name = "bt_AlumSelecionado";
            bt_AlumSelecionado.Size = new Size(94, 29);
            bt_AlumSelecionado.TabIndex = 57;
            bt_AlumSelecionado.Text = "Generar";
            bt_AlumSelecionado.UseVisualStyleBackColor = true;
            bt_AlumSelecionado.Click += bt_AlumSelecionado_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(597, 18);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(94, 29);
            btnRefrescar.TabIndex = 58;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // VGenerarReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 646);
            Controls.Add(btnRefrescar);
            Controls.Add(bt_AlumSelecionado);
            Controls.Add(lsb_Estudiante);
            Controls.Add(cb_jornada);
            Controls.Add(bt_Jornada);
            Controls.Add(bt_porCarrera);
            Controls.Add(bt_GeneralEstudiante);
            Controls.Add(cb_porCarrera);
            Controls.Add(button1);
            Controls.Add(cmbJornada);
            Controls.Add(lb_alumnoSeleccionado);
            Controls.Add(lb_alumnosFechas);
            Controls.Add(bt_alumnosFechas);
            Controls.Add(lb_porJornada);
            Controls.Add(lb_PorCarrera);
            Controls.Add(lb_General_Estuidante);
            Controls.Add(Lb_TGR);
            Name = "VGenerarReportes";
            Text = "VGenerarReportes";
            Load += VGenerarReportes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lb_TGR;
        private Label lb_General_Estuidante;
        private Label lb_PorCarrera;
        private Label lb_porJornada;
        private Button bt_alumnosFechas;
        private Label lb_alumnosFechas;
        private Label lb_alumnoSeleccionado;
        private ComboBox cmbJornada;
        private Button button1;
        private ComboBox cb_porCarrera;
        private Button bt_GeneralEstudiante;
        private Button bt_porCarrera;
        private Button bt_Jornada;
        private ComboBox cb_jornada;
        private ListBox lsb_Estudiante;
        private Button bt_AlumSelecionado;
        private Button btnRefrescar;
    }
}