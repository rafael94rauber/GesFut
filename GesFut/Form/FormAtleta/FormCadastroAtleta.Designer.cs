
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
            this.edtCPF = new System.Windows.Forms.MaskedTextBox();
            this.edtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.edtSexo = new System.Windows.Forms.TextBox();
            this.btnToAvaliacaoMedica = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFCMaxima = new System.Windows.Forms.TextBox();
            this.txtFCMinima = new System.Windows.Forms.TextBox();
            this.txtFCMedia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // salvarAtleta
            // 
            this.salvarAtleta.Location = new System.Drawing.Point(490, 312);
            this.salvarAtleta.Name = "salvarAtleta";
            this.salvarAtleta.Size = new System.Drawing.Size(75, 22);
            this.salvarAtleta.TabIndex = 0;
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
            this.label5.Location = new System.Drawing.Point(23, 259);
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
            this.edtNascimento.TabIndex = 11;
            this.edtNascimento.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // edtEndereco
            // 
            this.edtEndereco.Location = new System.Drawing.Point(133, 256);
            this.edtEndereco.Name = "edtEndereco";
            this.edtEndereco.Size = new System.Drawing.Size(432, 23);
            this.edtEndereco.TabIndex = 13;
            // 
            // edtEmail
            // 
            this.edtEmail.Location = new System.Drawing.Point(133, 81);
            this.edtEmail.Name = "edtEmail";
            this.edtEmail.Size = new System.Drawing.Size(100, 23);
            this.edtEmail.TabIndex = 15;
            // 
            // edtCPF
            // 
            this.edtCPF.Location = new System.Drawing.Point(465, 125);
            this.edtCPF.Mask = "000,000,000-00";
            this.edtCPF.Name = "edtCPF";
            this.edtCPF.Size = new System.Drawing.Size(100, 23);
            this.edtCPF.TabIndex = 17;
            // 
            // edtTelefone
            // 
            this.edtTelefone.Location = new System.Drawing.Point(133, 125);
            this.edtTelefone.Mask = "(99) 00000-0000";
            this.edtTelefone.Name = "edtTelefone";
            this.edtTelefone.Size = new System.Drawing.Size(100, 23);
            this.edtTelefone.TabIndex = 18;
            // 
            // edtSexo
            // 
            this.edtSexo.Location = new System.Drawing.Point(465, 81);
            this.edtSexo.Name = "edtSexo";
            this.edtSexo.Size = new System.Drawing.Size(100, 23);
            this.edtSexo.TabIndex = 12;
            // 
            // btnToAvaliacaoMedica
            // 
            this.btnToAvaliacaoMedica.Location = new System.Drawing.Point(23, 311);
            this.btnToAvaliacaoMedica.Name = "btnToAvaliacaoMedica";
            this.btnToAvaliacaoMedica.Size = new System.Drawing.Size(108, 22);
            this.btnToAvaliacaoMedica.TabIndex = 19;
            this.btnToAvaliacaoMedica.Text = "Ir p/ Avaliação Médica";
            this.btnToAvaliacaoMedica.UseVisualStyleBackColor = true;
            this.btnToAvaliacaoMedica.Click += new System.EventHandler(this.btnToAvaliacaoMedica_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "FC Máxima";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "FC em repouso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(397, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "FC Média";
            // 
            // txtFCMaxima
            // 
            this.txtFCMaxima.Location = new System.Drawing.Point(23, 196);
            this.txtFCMaxima.Name = "txtFCMaxima";
            this.txtFCMaxima.Size = new System.Drawing.Size(100, 23);
            this.txtFCMaxima.TabIndex = 23;
            // 
            // txtFCMinima
            // 
            this.txtFCMinima.Location = new System.Drawing.Point(194, 196);
            this.txtFCMinima.Name = "txtFCMinima";
            this.txtFCMinima.Size = new System.Drawing.Size(100, 23);
            this.txtFCMinima.TabIndex = 24;
            // 
            // txtFCMedia
            // 
            this.txtFCMedia.Location = new System.Drawing.Point(397, 196);
            this.txtFCMedia.Name = "txtFCMedia";
            this.txtFCMedia.Size = new System.Drawing.Size(100, 23);
            this.txtFCMedia.TabIndex = 25;
            // 
            // FormCadastroAtleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 345);
            this.Controls.Add(this.txtFCMedia);
            this.Controls.Add(this.txtFCMinima);
            this.Controls.Add(this.txtFCMaxima);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnToAvaliacaoMedica);
            this.Controls.Add(this.edtTelefone);
            this.Controls.Add(this.edtCPF);
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
        private System.Windows.Forms.MaskedTextBox edtCPF;
        private System.Windows.Forms.MaskedTextBox edtTelefone;
        private System.Windows.Forms.TextBox edtSexo;
        private System.Windows.Forms.Button btnToAvaliacaoMedica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFCMaxima;
        private System.Windows.Forms.TextBox txtFCMinima;
        private System.Windows.Forms.TextBox txtFCMedia;
    }
}