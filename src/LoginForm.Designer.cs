namespace FazendaSuinos
{
    partial class LoginForm
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
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_senha = new System.Windows.Forms.Label();
            this.botao_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(317, 96);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(147, 42);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Rodolfo";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(272, 164);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(70, 16);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(275, 237);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Location = new System.Drawing.Point(272, 218);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(46, 16);
            this.label_senha.TabIndex = 3;
            this.label_senha.Text = "Senha";
            // 
            // botao_login
            // 
            this.botao_login.Location = new System.Drawing.Point(423, 282);
            this.botao_login.Name = "botao_login";
            this.botao_login.Size = new System.Drawing.Size(82, 28);
            this.botao_login.TabIndex = 5;
            this.botao_login.Text = "Login";
            this.botao_login.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botao_login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_titulo);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.Button botao_login;
    }
}