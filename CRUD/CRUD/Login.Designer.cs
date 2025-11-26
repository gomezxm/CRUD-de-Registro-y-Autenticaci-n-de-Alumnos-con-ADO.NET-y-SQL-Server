namespace CRUD
{
    partial class Login
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
            Lb_CreacionTitulo = new Label();
            label1 = new Label();
            txt_NmbrUsuario = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Lb_CreacionTitulo
            // 
            Lb_CreacionTitulo.AutoSize = true;
            Lb_CreacionTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_CreacionTitulo.Location = new Point(102, 24);
            Lb_CreacionTitulo.Name = "Lb_CreacionTitulo";
            Lb_CreacionTitulo.Size = new Size(173, 32);
            Lb_CreacionTitulo.TabIndex = 22;
            Lb_CreacionTitulo.Text = "Autenticación";
            Lb_CreacionTitulo.Click += Lb_CreacionTitulo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 86);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 23;
            label1.Text = "Nombre de usuario";
            label1.Click += label1_Click;
            // 
            // txt_NmbrUsuario
            // 
            txt_NmbrUsuario.Location = new Point(162, 84);
            txt_NmbrUsuario.Margin = new Padding(3, 2, 3, 2);
            txt_NmbrUsuario.Name = "txt_NmbrUsuario";
            txt_NmbrUsuario.Size = new Size(159, 23);
            txt_NmbrUsuario.TabIndex = 24;
            txt_NmbrUsuario.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 122);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 25;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 124);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 26;
            label2.Text = "Contraseña";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(162, 164);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(159, 23);
            textBox3.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 166);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 28;
            label3.Text = "Nombre del servidor";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(162, 204);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(159, 23);
            textBox4.TabIndex = 29;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 209);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 30;
            label4.Text = "Base de Datos";
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(130, 264);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(107, 22);
            button1.TabIndex = 31;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 320);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(txt_NmbrUsuario);
            Controls.Add(label1);
            Controls.Add(Lb_CreacionTitulo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lb_CreacionTitulo;
        private Label label1;
        private TextBox txt_NmbrUsuario;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Button button1;
    }
}