namespace ProjetoLog
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            tb_login = new TextBox();
            tb_senha = new TextBox();
            pictureBox1 = new PictureBox();
            btn_Sair = new Button();
            btn_Entrar = new Button();
            btn_Cadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(172, 87);
            label1.Name = "label1";
            label1.Size = new Size(51, 18);
            label1.TabIndex = 0;
            label1.Text = "Login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(172, 130);
            label2.Name = "label2";
            label2.Size = new Size(57, 18);
            label2.TabIndex = 1;
            label2.Text = "Senha:";
            // 
            // tb_login
            // 
            tb_login.Location = new Point(235, 82);
            tb_login.Name = "tb_login";
            tb_login.Size = new Size(141, 23);
            tb_login.TabIndex = 2;
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(235, 125);
            tb_senha.Name = "tb_senha";
            tb_senha.PasswordChar = '*';
            tb_senha.Size = new Size(141, 23);
            tb_senha.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_Sair
            // 
            btn_Sair.Location = new Point(287, 162);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(89, 34);
            btn_Sair.TabIndex = 5;
            btn_Sair.Text = "Sair";
            btn_Sair.UseVisualStyleBackColor = true;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // btn_Entrar
            // 
            btn_Entrar.Location = new Point(192, 162);
            btn_Entrar.Name = "btn_Entrar";
            btn_Entrar.Size = new Size(89, 34);
            btn_Entrar.TabIndex = 6;
            btn_Entrar.Text = "Entrar";
            btn_Entrar.UseVisualStyleBackColor = true;
            btn_Entrar.Click += btn_Entrar_Click;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.Location = new Point(287, 225);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(89, 32);
            btn_Cadastrar.TabIndex = 7;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = true;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 269);
            Controls.Add(btn_Cadastrar);
            Controls.Add(btn_Entrar);
            Controls.Add(btn_Sair);
            Controls.Add(pictureBox1);
            Controls.Add(tb_senha);
            Controls.Add(tb_login);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_login;
        private TextBox tb_senha;
        private PictureBox pictureBox1;
        private Button btn_Sair;
        private Button btn_Entrar;
        private Button btn_Cadastrar;
    }
}