
namespace GesFut
{
    partial class FormBemVindo
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtleta = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsultaJogos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem-Vindo ao GesFut";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnAtleta
            // 
            this.btnAtleta.Location = new System.Drawing.Point(50, 72);
            this.btnAtleta.Name = "btnAtleta";
            this.btnAtleta.Size = new System.Drawing.Size(129, 92);
            this.btnAtleta.TabIndex = 1;
            this.btnAtleta.Text = "Atleta";
            this.btnAtleta.UseVisualStyleBackColor = true;
            this.btnAtleta.Click += new System.EventHandler(this.btnCadastroAtleta_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(692, 404);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(96, 34);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnConsultaJogos
            // 
            this.btnConsultaJogos.Location = new System.Drawing.Point(215, 72);
            this.btnConsultaJogos.Name = "btnConsultaJogos";
            this.btnConsultaJogos.Size = new System.Drawing.Size(129, 92);
            this.btnConsultaJogos.TabIndex = 5;
            this.btnConsultaJogos.Text = "Consulta de Jogos";
            this.btnConsultaJogos.UseVisualStyleBackColor = true;
            this.btnConsultaJogos.Click += new System.EventHandler(this.btnConsultaJogos_Click);
            // 
            // FormBemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultaJogos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAtleta);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormBemVindo";
            this.Text = "GesFut";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtleta;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConsultaJogos;
    }
}