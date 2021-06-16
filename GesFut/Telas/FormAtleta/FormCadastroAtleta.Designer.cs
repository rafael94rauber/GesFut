
namespace GesFut
{
    partial class FormCadastroAtleta
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
            this.salvarAtleta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtNascimento = new System.Windows.Forms.TextBox();
            this.edtEndereco = new System.Windows.Forms.TextBox();
            this.edtEmail = new System.Windows.Forms.TextBox();
            this.edtSexo = new System.Windows.Forms.TextBox();
            this.edtTelefone = new System.Windows.Forms.TextBox();
            this.edtCPF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // salvarAtleta
            // 
            this.salvarAtleta.Location = new System.Drawing.Point(490, 218);
            this.salvarAtleta.Name = "salvarAtleta";
            this.salvarAtleta.Size = new System.Drawing.Size(75, 22);
            this.salvarAtleta.TabIndex = 8;
            this.salvarAtleta.Text = "Salvar";
            this.salvarAtleta.UseVisualStyleBackColor = true;
            this.salvarAtleta.Click += new System.EventHandler(this.salvarAtleta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Endereço";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "CPF";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sexo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Data de Nascimento";
            // 
            // edtNome
            // 
            this.edtNome.Location = new System.Drawing.Point(133, 40);
            this.edtNome.Name = "edtNome";
            this.edtNome.Size = new System.Drawing.Size(100, 23);
            this.edtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email para Contato";
            // 
            // edtNascimento
            // 
            this.edtNascimento.Location = new System.Drawing.Point(465, 40);
            this.edtNascimento.Name = "edtNascimento";
            this.edtNascimento.Size = new System.Drawing.Size(100, 23);
            this.edtNascimento.TabIndex = 5;
            this.edtNascimento.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // edtEndereco
            // 
            this.edtEndereco.Location = new System.Drawing.Point(133, 167);
            this.edtEndereco.Name = "edtEndereco";
            this.edtEndereco.Size = new System.Drawing.Size(432, 23);
            this.edtEndereco.TabIndex = 4;
            // 
            // edtEmail
            // 
            this.edtEmail.Location = new System.Drawing.Point(133, 81);
            this.edtEmail.Name = "edtEmail";
            this.edtEmail.Size = new System.Drawing.Size(100, 23);
            this.edtEmail.TabIndex = 2;
            // 
            // edtSexo
            // 
            this.edtSexo.Location = new System.Drawing.Point(465, 81);
            this.edtSexo.Name = "edtSexo";
            this.edtSexo.Size = new System.Drawing.Size(100, 23);
            this.edtSexo.TabIndex = 6;
            // 
            // edtTelefone
            // 
            this.edtTelefone.Location = new System.Drawing.Point(133, 124);
            this.edtTelefone.Name = "edtTelefone";
            this.edtTelefone.Size = new System.Drawing.Size(100, 23);
            this.edtTelefone.TabIndex = 3;
            // 
            // edtCPF
            // 
            this.edtCPF.Location = new System.Drawing.Point(465, 125);
            this.edtCPF.Name = "edtCPF";
            this.edtCPF.Size = new System.Drawing.Size(100, 23);
            this.edtCPF.TabIndex = 7;
            // 
            // FormCadastroAtleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 253);
            this.Controls.Add(this.edtCPF);
            this.Controls.Add(this.edtTelefone);
            this.Controls.Add(this.edtEmail);
            this.Controls.Add(this.edtEndereco);
            this.Controls.Add(this.edtSexo);
            this.Controls.Add(this.edtNascimento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtNome);
            this.Controls.Add(this.salvarAtleta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroAtleta";
            this.Text = "Cadastro de Atleta";
            this.Load += new System.EventHandler(this.FormCadastroAtleta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salvarAtleta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtNascimento;
        private System.Windows.Forms.TextBox edtEndereco;
        private System.Windows.Forms.TextBox edtEmail;
        private System.Windows.Forms.TextBox edtSexo;
        private System.Windows.Forms.TextBox edtTelefone;
        private System.Windows.Forms.TextBox edtCPF;
    }
}