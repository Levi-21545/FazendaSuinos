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
            this.botao_login = new System.Windows.Forms.Button();
            this.label_titulo = new System.Windows.Forms.Label();
            this.campo_username = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_senha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botao_login
            // 
            this.botao_login.Location = new System.Drawing.Point(341, 335);
            this.botao_login.Name = "botao_login";
            this.botao_login.Size = new System.Drawing.Size(100, 30);
            this.botao_login.TabIndex = 0;
            this.botao_login.Text = "Login";
            this.botao_login.UseVisualStyleBackColor = true;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(311, 85);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(160, 46);
            this.label_titulo.TabIndex = 1;
            this.label_titulo.Text = "Rodolfo";
            // 
            // campo_username
            // 
            this.campo_username.Location = new System.Drawing.Point(263, 188);
            this.campo_username.Name = "campo_username";
            this.campo_username.Size = new System.Drawing.Size(256, 22);
            this.campo_username.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(263, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(263, 166);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(70, 16);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "Username";
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Location = new System.Drawing.Point(263, 226);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(46, 16);
            this.label_senha.TabIndex = 5;
            this.label_senha.Text = "Senha";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.campo_username);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.botao_login);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao_login;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.TextBox campo_username;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_senha;
    }
}