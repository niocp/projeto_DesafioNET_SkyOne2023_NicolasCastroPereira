namespace test_04
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
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            lblLogin = new Label();
            lblSenha = new Label();
            btnEntrar = new Button();
            lblMsg1 = new Label();
            lblMsg2 = new Label();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Location = new Point(233, 168);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Location = new Point(381, 168);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(233, 150);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(381, 150);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Location = new Point(512, 168);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(87, 23);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblMsg1
            // 
            lblMsg1.AutoSize = true;
            lblMsg1.Location = new Point(233, 208);
            lblMsg1.Name = "lblMsg1";
            lblMsg1.Size = new Size(0, 15);
            lblMsg1.TabIndex = 5;
            // 
            // lblMsg2
            // 
            lblMsg2.AutoSize = true;
            lblMsg2.Location = new Point(381, 208);
            lblMsg2.Name = "lblMsg2";
            lblMsg2.Size = new Size(0, 15);
            lblMsg2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMsg2);
            Controls.Add(lblMsg1);
            Controls.Add(btnEntrar);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label lblLogin;
        private Label lblSenha;
        private Button btnEntrar;
        private Label lblMsg1;
        private Label lblMsg2;
    }
}