namespace CRUD
{
    partial class VUptade
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
            Bt_Actualizar = new Button();
            Lb_Contraseña = new Label();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            Rb_Matutina = new RadioButton();
            Rb_Vespertina = new RadioButton();
            Cb_Semestre = new ComboBox();
            comboBox1 = new ComboBox();
            Jornada = new Label();
            Lb_Semestre = new Label();
            Lb_Cedula = new Label();
            Txb_Cedula = new TextBox();
            label1 = new Label();
            Lb_Nombre = new Label();
            Txb_Nombre = new TextBox();
            Lb_ID = new Label();
            Lb_CreacionTitulo = new Label();
            Bt_Cancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Bt_Actualizar
            // 
            Bt_Actualizar.Location = new Point(199, 230);
            Bt_Actualizar.Margin = new Padding(3, 2, 3, 2);
            Bt_Actualizar.Name = "Bt_Actualizar";
            Bt_Actualizar.Size = new Size(132, 22);
            Bt_Actualizar.TabIndex = 36;
            Bt_Actualizar.Text = "Actualizar";
            Bt_Actualizar.UseVisualStyleBackColor = true;
            Bt_Actualizar.Click += Bt_Actualizar_Click;
            // 
            // Lb_Contraseña
            // 
            Lb_Contraseña.AutoSize = true;
            Lb_Contraseña.Location = new Point(55, 124);
            Lb_Contraseña.Name = "Lb_Contraseña";
            Lb_Contraseña.Size = new Size(67, 15);
            Lb_Contraseña.TabIndex = 35;
            Lb_Contraseña.Text = "Contraseña";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(55, 140);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 34;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Rb_Matutina);
            groupBox1.Controls.Add(Rb_Vespertina);
            groupBox1.Location = new Point(199, 129);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(103, 94);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jornada";
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
            // 
            // Cb_Semestre
            // 
            Cb_Semestre.FormattingEnabled = true;
            Cb_Semestre.Items.AddRange(new object[] { "1° ", "2°", "3°", "4°", "5°", "6°", "7°", "8°", "9°", "10°" });
            Cb_Semestre.Location = new Point(199, 93);
            Cb_Semestre.Margin = new Padding(3, 2, 3, 2);
            Cb_Semestre.Name = "Cb_Semestre";
            Cb_Semestre.Size = new Size(133, 23);
            Cb_Semestre.TabIndex = 32;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Licenciatura en Desarrollo y Gestion en Software", "Ingenieria industrial", "Licenciatura en Topografia" });
            comboBox1.Location = new Point(55, 194);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 31;
            // 
            // Jornada
            // 
            Jornada.AutoSize = true;
            Jornada.Location = new Point(259, 129);
            Jornada.Name = "Jornada";
            Jornada.Size = new Size(0, 15);
            Jornada.TabIndex = 30;
            // 
            // Lb_Semestre
            // 
            Lb_Semestre.AutoSize = true;
            Lb_Semestre.Location = new Point(199, 76);
            Lb_Semestre.Name = "Lb_Semestre";
            Lb_Semestre.Size = new Size(55, 15);
            Lb_Semestre.TabIndex = 29;
            Lb_Semestre.Text = "Semestre";
            // 
            // Lb_Cedula
            // 
            Lb_Cedula.AutoSize = true;
            Lb_Cedula.Location = new Point(55, 223);
            Lb_Cedula.Name = "Lb_Cedula";
            Lb_Cedula.Size = new Size(44, 15);
            Lb_Cedula.TabIndex = 28;
            Lb_Cedula.Text = "Cédula";
            // 
            // Txb_Cedula
            // 
            Txb_Cedula.Location = new Point(55, 240);
            Txb_Cedula.Margin = new Padding(3, 2, 3, 2);
            Txb_Cedula.Name = "Txb_Cedula";
            Txb_Cedula.Size = new Size(110, 23);
            Txb_Cedula.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 176);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 26;
            label1.Text = "Carrera";
            // 
            // Lb_Nombre
            // 
            Lb_Nombre.AutoSize = true;
            Lb_Nombre.Location = new Point(55, 75);
            Lb_Nombre.Name = "Lb_Nombre";
            Lb_Nombre.Size = new Size(51, 15);
            Lb_Nombre.TabIndex = 25;
            Lb_Nombre.Text = "Nombre";
            // 
            // Txb_Nombre
            // 
            Txb_Nombre.Location = new Point(55, 92);
            Txb_Nombre.Margin = new Padding(3, 2, 3, 2);
            Txb_Nombre.Name = "Txb_Nombre";
            Txb_Nombre.Size = new Size(110, 23);
            Txb_Nombre.TabIndex = 24;
            // 
            // Lb_ID
            // 
            Lb_ID.AutoSize = true;
            Lb_ID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_ID.Location = new Point(59, 69);
            Lb_ID.Name = "Lb_ID";
            Lb_ID.Size = new Size(0, 15);
            Lb_ID.TabIndex = 22;
            // 
            // Lb_CreacionTitulo
            // 
            Lb_CreacionTitulo.AutoSize = true;
            Lb_CreacionTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_CreacionTitulo.Location = new Point(59, 16);
            Lb_CreacionTitulo.Name = "Lb_CreacionTitulo";
            Lb_CreacionTitulo.Size = new Size(232, 32);
            Lb_CreacionTitulo.TabIndex = 21;
            Lb_CreacionTitulo.Text = "ACTUALIZAR DATO";
            // 
            // Bt_Cancelar
            // 
            Bt_Cancelar.Location = new Point(199, 256);
            Bt_Cancelar.Margin = new Padding(3, 2, 3, 2);
            Bt_Cancelar.Name = "Bt_Cancelar";
            Bt_Cancelar.Size = new Size(132, 22);
            Bt_Cancelar.TabIndex = 37;
            Bt_Cancelar.Text = "Cancelar";
            Bt_Cancelar.UseVisualStyleBackColor = true;
            Bt_Cancelar.Click += Bt_Cancelar_Click;
            // 
            // VUptade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 338);
            Controls.Add(Bt_Cancelar);
            Controls.Add(Bt_Actualizar);
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
            Name = "VUptade";
            Text = "VUptade";
            Load += VUptade_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bt_Actualizar;
        private Label Lb_Contraseña;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private RadioButton Rb_Matutina;
        private RadioButton Rb_Vespertina;
        private ComboBox Cb_Semestre;
        private ComboBox comboBox1;
        private Label Jornada;
        private Label Lb_Semestre;
        private Label Lb_Cedula;
        private TextBox Txb_Cedula;
        private Label label1;
        private Label Lb_Nombre;
        private TextBox Txb_Nombre;
        private Label Lb_ID;
        private Label Lb_CreacionTitulo;
        private Button Bt_Cancelar;
    }
}