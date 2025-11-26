namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Lb_CreacionTitulo = new Label();
            Lb_ID = new Label();
            Txb_Nombre = new TextBox();
            Lb_Nombre = new Label();
            label1 = new Label();
            Txb_Cedula = new TextBox();
            Lb_Cedula = new Label();
            Lb_Semestre = new Label();
            Jornada = new Label();
            comboBox1 = new ComboBox();
            Rb_Matutina = new RadioButton();
            Rb_Vespertina = new RadioButton();
            Cb_Semestre = new ComboBox();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            Lb_Contraseña = new Label();
            Bt_Registrar = new Button();
            Bt_Cancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Lb_CreacionTitulo
            // 
            Lb_CreacionTitulo.AutoSize = true;
            Lb_CreacionTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_CreacionTitulo.Location = new Point(30, 17);
            Lb_CreacionTitulo.Name = "Lb_CreacionTitulo";
            Lb_CreacionTitulo.Size = new Size(295, 32);
            Lb_CreacionTitulo.TabIndex = 0;
            Lb_CreacionTitulo.Text = "CREACION DE REGISTRO";
            Lb_CreacionTitulo.Click += label1_Click;
            // 
            // Lb_ID
            // 
            Lb_ID.AutoSize = true;
            Lb_ID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_ID.Location = new Point(34, 48);
            Lb_ID.Name = "Lb_ID";
            Lb_ID.Size = new Size(0, 15);
            Lb_ID.TabIndex = 1;
            // 
            // Txb_Nombre
            // 
            Txb_Nombre.Location = new Point(30, 76);
            Txb_Nombre.Margin = new Padding(3, 2, 3, 2);
            Txb_Nombre.Name = "Txb_Nombre";
            Txb_Nombre.Size = new Size(110, 23);
            Txb_Nombre.TabIndex = 3;
            Txb_Nombre.TextChanged += textBox1_TextChanged_1;
            // 
            // Lb_Nombre
            // 
            Lb_Nombre.AutoSize = true;
            Lb_Nombre.Location = new Point(30, 59);
            Lb_Nombre.Name = "Lb_Nombre";
            Lb_Nombre.Size = new Size(51, 15);
            Lb_Nombre.TabIndex = 4;
            Lb_Nombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 160);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 6;
            label1.Text = "Carrera";
            // 
            // Txb_Cedula
            // 
            Txb_Cedula.Location = new Point(30, 224);
            Txb_Cedula.Margin = new Padding(3, 2, 3, 2);
            Txb_Cedula.Name = "Txb_Cedula";
            Txb_Cedula.Size = new Size(110, 23);
            Txb_Cedula.TabIndex = 7;
            Txb_Cedula.TextChanged += textBox3_TextChanged;
            // 
            // Lb_Cedula
            // 
            Lb_Cedula.AutoSize = true;
            Lb_Cedula.Location = new Point(30, 207);
            Lb_Cedula.Name = "Lb_Cedula";
            Lb_Cedula.Size = new Size(44, 15);
            Lb_Cedula.TabIndex = 8;
            Lb_Cedula.Text = "Cédula";
            // 
            // Lb_Semestre
            // 
            Lb_Semestre.AutoSize = true;
            Lb_Semestre.Location = new Point(200, 61);
            Lb_Semestre.Name = "Lb_Semestre";
            Lb_Semestre.Size = new Size(55, 15);
            Lb_Semestre.TabIndex = 10;
            Lb_Semestre.Text = "Semestre";
            // 
            // Jornada
            // 
            Jornada.AutoSize = true;
            Jornada.Location = new Point(260, 114);
            Jornada.Name = "Jornada";
            Jornada.Size = new Size(0, 15);
            Jornada.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Licenciatura en Desarrollo y Gestion en Software", "Ingenieria industrial", "Licenciatura en Topografia" });
            comboBox1.Location = new Point(30, 178);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Rb_Matutina
            // 
            Rb_Matutina.AutoSize = true;
            Rb_Matutina.Location = new Point(9, 23);
            Rb_Matutina.Margin = new Padding(3, 2, 3, 2);
            Rb_Matutina.Name = "Rb_Matutina";
            Rb_Matutina.Size = new Size(73, 19);
            Rb_Matutina.TabIndex = 14;
            Rb_Matutina.TabStop = true;
            Rb_Matutina.Text = "Matutina";
            Rb_Matutina.UseVisualStyleBackColor = true;
            Rb_Matutina.CheckedChanged += Rb_Matutina_CheckedChanged;
            // 
            // Rb_Vespertina
            // 
            Rb_Vespertina.AutoSize = true;
            Rb_Vespertina.Location = new Point(9, 46);
            Rb_Vespertina.Margin = new Padding(3, 2, 3, 2);
            Rb_Vespertina.Name = "Rb_Vespertina";
            Rb_Vespertina.Size = new Size(79, 19);
            Rb_Vespertina.TabIndex = 15;
            Rb_Vespertina.TabStop = true;
            Rb_Vespertina.Text = "Vespertina";
            Rb_Vespertina.UseVisualStyleBackColor = true;
            Rb_Vespertina.CheckedChanged += Rb_Vespertina_CheckedChanged;
            // 
            // Cb_Semestre
            // 
            Cb_Semestre.FormattingEnabled = true;
            Cb_Semestre.Items.AddRange(new object[] { "1° ", "2°", "3°", "4°", "5°", "6°", "7°", "8°", "9°", "10°" });
            Cb_Semestre.Location = new Point(200, 78);
            Cb_Semestre.Margin = new Padding(3, 2, 3, 2);
            Cb_Semestre.Name = "Cb_Semestre";
            Cb_Semestre.Size = new Size(133, 23);
            Cb_Semestre.TabIndex = 16;
            Cb_Semestre.SelectedIndexChanged += Cb_Semestre_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Rb_Matutina);
            groupBox1.Controls.Add(Rb_Vespertina);
            groupBox1.Location = new Point(200, 114);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(103, 94);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jornada";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 124);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 18;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Lb_Contraseña
            // 
            Lb_Contraseña.AutoSize = true;
            Lb_Contraseña.Location = new Point(30, 108);
            Lb_Contraseña.Name = "Lb_Contraseña";
            Lb_Contraseña.Size = new Size(67, 15);
            Lb_Contraseña.TabIndex = 19;
            Lb_Contraseña.Text = "Contraseña";
            // 
            // Bt_Registrar
            // 
            Bt_Registrar.Location = new Point(200, 215);
            Bt_Registrar.Margin = new Padding(3, 2, 3, 2);
            Bt_Registrar.Name = "Bt_Registrar";
            Bt_Registrar.Size = new Size(132, 22);
            Bt_Registrar.TabIndex = 20;
            Bt_Registrar.Text = "Registrar";
            Bt_Registrar.UseVisualStyleBackColor = true;
            Bt_Registrar.Click += Bt_Registrar_Click;
            // 
            // Bt_Cancelar
            // 
            Bt_Cancelar.Location = new Point(200, 242);
            Bt_Cancelar.Margin = new Padding(3, 2, 3, 2);
            Bt_Cancelar.Name = "Bt_Cancelar";
            Bt_Cancelar.Size = new Size(132, 22);
            Bt_Cancelar.TabIndex = 38;
            Bt_Cancelar.Text = "Cancelar";
            Bt_Cancelar.UseVisualStyleBackColor = true;
            Bt_Cancelar.Click += Bt_Cancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 338);
            Controls.Add(Bt_Cancelar);
            Controls.Add(Bt_Registrar);
            Controls.Add(Lb_Contraseña);
            Controls.Add(textBox2);
            Controls.Add(groupBox1);
            Controls.Add(Cb_Semestre);
            Controls.Add(comboBox1);
            Controls.Add(Jornada);
            Controls.Add(Lb_Semestre);
            Controls.Add(Lb_Cedula);
            Controls.Add(Txb_Cedula);
            Controls.Add(label1);
            Controls.Add(Lb_Nombre);
            Controls.Add(Txb_Nombre);
            Controls.Add(Lb_ID);
            Controls.Add(Lb_CreacionTitulo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lb_CreacionTitulo;
        private Label Lb_ID;
        private TextBox Txb_Nombre;
        private Label Lb_Nombre;
        private Label label1;
        private TextBox Txb_Cedula;
        private Label Lb_Cedula;
        private Label Lb_Semestre;
        private Label Jornada;
        private ComboBox comboBox1;
        private RadioButton Rb_Matutina;
        private RadioButton Rb_Vespertina;
        private ComboBox Cb_Semestre;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label Lb_Contraseña;
        private Button Bt_Registrar;
        private Button Bt_Cancelar;
    }
}
