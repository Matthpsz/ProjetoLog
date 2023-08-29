namespace ProjetoLog.Forms
{
    partial class Cadastro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_login = new TextBox();
            tb_senha = new TextBox();
            tb_confSenha = new TextBox();
            btn_Cadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 35);
            label1.Name = "label1";
            label1.Size = new Size(47, 18);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 95);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 155);
            label3.Name = "label3";
            label3.Size = new Size(126, 18);
            label3.TabIndex = 2;
            label3.Text = "Confirmar Senha";
            // 
            // tb_login
            // 
            tb_login.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_login.Location = new Point(29, 63);
            tb_login.Name = "tb_login";
            tb_login.Size = new Size(171, 22);
            tb_login.TabIndex = 3;
            // 
            // tb_senha
            // 
            tb_senha.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_senha.Location = new Point(29, 122);
            tb_senha.Name = "tb_senha";
            tb_senha.PasswordChar = '*';
            tb_senha.Size = new Size(128, 22);
            tb_senha.TabIndex = 4;
            // 
            // tb_confSenha
            // 
            tb_confSenha.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_confSenha.Location = new Point(32, 181);
            tb_confSenha.Name = "tb_confSenha";
            tb_confSenha.PasswordChar = '*';
            tb_confSenha.Size = new Size(125, 22);
            tb_confSenha.TabIndex = 5;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cadastrar.Location = new Point(62, 217);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(95, 42);
            btn_Cadastrar.TabIndex = 6;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = true;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 277);
            Controls.Add(btn_Cadastrar);
            Controls.Add(tb_confSenha);
            Controls.Add(tb_senha);
            Controls.Add(tb_login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_login;
        private TextBox tb_senha;
        private TextBox tb_confSenha;
        private Button btn_Cadastrar;
    }
}