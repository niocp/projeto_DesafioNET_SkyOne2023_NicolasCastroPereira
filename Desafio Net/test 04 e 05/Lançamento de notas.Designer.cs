namespace test_04
{
    partial class Form2
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
            lblNome = new Label();
            txtNome = new TextBox();
            lblNota1 = new Label();
            lblNota2 = new Label();
            label4 = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            lblResultado = new Label();
            btnEnviar = new Button();
            btnLimpar = new Button();
            lblMsgNota1 = new Label();
            lblMsgNome = new Label();
            lblMsgNota2 = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(143, 67);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(93, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome do aluno:";
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(143, 97);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(314, 23);
            txtNome.TabIndex = 1;
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(143, 168);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(118, 15);
            lblNota1.TabIndex = 2;
            lblNota1.Text = "Nota do 1º Semestre:";
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(342, 168);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(118, 15);
            lblNota2.TabIndex = 3;
            lblNota2.Text = "Nota do 2º Semestre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 353);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 4;
            label4.Text = "Status do Aluno:";
            // 
            // txtNota1
            // 
            txtNota1.BorderStyle = BorderStyle.FixedSingle;
            txtNota1.Location = new Point(143, 208);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(118, 23);
            txtNota1.TabIndex = 5;
            // 
            // txtNota2
            // 
            txtNota2.BorderStyle = BorderStyle.FixedSingle;
            txtNota2.Location = new Point(342, 208);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(115, 23);
            txtNota2.TabIndex = 6;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.ForeColor = Color.SlateGray;
            lblResultado.Location = new Point(243, 353);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(135, 15);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Nota ainda não enviada.";
            // 
            // btnEnviar
            // 
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Location = new Point(143, 286);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(182, 32);
            btnEnviar.TabIndex = 8;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Location = new Point(342, 286);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(115, 32);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar Campos";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblMsgNota1
            // 
            lblMsgNota1.AutoSize = true;
            lblMsgNota1.Location = new Point(143, 245);
            lblMsgNota1.Name = "lblMsgNota1";
            lblMsgNota1.Size = new Size(0, 15);
            lblMsgNota1.TabIndex = 10;
            // 
            // lblMsgNome
            // 
            lblMsgNome.AutoSize = true;
            lblMsgNome.Location = new Point(143, 135);
            lblMsgNome.Name = "lblMsgNome";
            lblMsgNome.Size = new Size(0, 15);
            lblMsgNome.TabIndex = 11;
            // 
            // lblMsgNota2
            // 
            lblMsgNota2.AutoSize = true;
            lblMsgNota2.Location = new Point(342, 245);
            lblMsgNota2.Name = "lblMsgNota2";
            lblMsgNota2.Size = new Size(0, 15);
            lblMsgNota2.TabIndex = 12;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMsgNota2);
            Controls.Add(lblMsgNome);
            Controls.Add(lblMsgNota1);
            Controls.Add(btnLimpar);
            Controls.Add(btnEnviar);
            Controls.Add(lblResultado);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(label4);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblNota1;
        private Label lblNota2;
        private Label label4;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private Label lblResultado;
        private Button btnEnviar;
        private Button btnLimpar;
        private Label lblMsgNota1;
        private Label lblMsgNome;
        private Label lblMsgNota2;
    }
}