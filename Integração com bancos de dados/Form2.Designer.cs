namespace Integração_com_bancos_de_dados_
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
            labelCriarUsuario = new Label();
            label1 = new Label();
            label2 = new Label();
            txtCriarSenha = new TextBox();
            btnRegistrar = new Button();
            txtCriarUsuario = new TextBox();
            SuspendLayout();
            // 
            // labelCriarUsuario
            // 
            labelCriarUsuario.AutoSize = true;
            labelCriarUsuario.Location = new Point(153, 199);
            labelCriarUsuario.Name = "labelCriarUsuario";
            labelCriarUsuario.Size = new Size(64, 25);
            labelCriarUsuario.TabIndex = 0;
            labelCriarUsuario.Text = "Senha:";
            labelCriarUsuario.Click += labelCriarUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 80);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 2;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 66);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 3;
            // 
            // txtCriarSenha
            // 
            txtCriarSenha.Location = new Point(153, 227);
            txtCriarSenha.Name = "txtCriarSenha";
            txtCriarSenha.Size = new Size(339, 31);
            txtCriarSenha.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(250, 332);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtCriarUsuario
            // 
            txtCriarUsuario.Location = new Point(153, 108);
            txtCriarUsuario.Name = "txtCriarUsuario";
            txtCriarUsuario.Size = new Size(339, 31);
            txtCriarUsuario.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 450);
            Controls.Add(txtCriarUsuario);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCriarSenha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelCriarUsuario);
            Name = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCriarUsuario;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtCriarSenha;
        private Button btnRegistrar;
        private TextBox txtCriarUsuario;
    }
}