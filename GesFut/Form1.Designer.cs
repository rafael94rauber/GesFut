
namespace GesFut
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTempoJogo = new System.Windows.Forms.TextBox();
            this.txtPercentualGordura = new System.Windows.Forms.TextBox();
            this.txtVelocidadeMedia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTemperaturaCorporal = new System.Windows.Forms.TextBox();
            this.txtPressao = new System.Windows.Forms.TextBox();
            this.txtBatimentosCardiacos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlergias = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigoAtleta = new System.Windows.Forms.TextBox();
            this.chkLesao = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.dbgAvaliacoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dbgAvaliacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salvar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Avaliação Médica de Desempenho de Atleta";
            // 
            // txtTempoJogo
            // 
            this.txtTempoJogo.Location = new System.Drawing.Point(54, 82);
            this.txtTempoJogo.Name = "txtTempoJogo";
            this.txtTempoJogo.Size = new System.Drawing.Size(100, 23);
            this.txtTempoJogo.TabIndex = 2;
            // 
            // txtPercentualGordura
            // 
            this.txtPercentualGordura.Location = new System.Drawing.Point(54, 144);
            this.txtPercentualGordura.Name = "txtPercentualGordura";
            this.txtPercentualGordura.Size = new System.Drawing.Size(100, 23);
            this.txtPercentualGordura.TabIndex = 3;
            // 
            // txtVelocidadeMedia
            // 
            this.txtVelocidadeMedia.Location = new System.Drawing.Point(54, 212);
            this.txtVelocidadeMedia.Name = "txtVelocidadeMedia";
            this.txtVelocidadeMedia.Size = new System.Drawing.Size(100, 23);
            this.txtVelocidadeMedia.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tempo de Jogo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Percentual de Gordura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Velocidade Média";
            // 
            // txtTemperaturaCorporal
            // 
            this.txtTemperaturaCorporal.Location = new System.Drawing.Point(344, 81);
            this.txtTemperaturaCorporal.Name = "txtTemperaturaCorporal";
            this.txtTemperaturaCorporal.Size = new System.Drawing.Size(100, 23);
            this.txtTemperaturaCorporal.TabIndex = 8;
            // 
            // txtPressao
            // 
            this.txtPressao.Location = new System.Drawing.Point(343, 144);
            this.txtPressao.Name = "txtPressao";
            this.txtPressao.Size = new System.Drawing.Size(100, 23);
            this.txtPressao.TabIndex = 9;
            // 
            // txtBatimentosCardiacos
            // 
            this.txtBatimentosCardiacos.Location = new System.Drawing.Point(343, 212);
            this.txtBatimentosCardiacos.Name = "txtBatimentosCardiacos";
            this.txtBatimentosCardiacos.Size = new System.Drawing.Size(100, 23);
            this.txtBatimentosCardiacos.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Temperatura Corporal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pressão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Batimentos Cárdiacos";
            // 
            // txtAlergias
            // 
            this.txtAlergias.Location = new System.Drawing.Point(344, 260);
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.Size = new System.Drawing.Size(100, 23);
            this.txtAlergias.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Alergias";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Codigo Atleta";
            // 
            // txtCodigoAtleta
            // 
            this.txtCodigoAtleta.Location = new System.Drawing.Point(54, 53);
            this.txtCodigoAtleta.Name = "txtCodigoAtleta";
            this.txtCodigoAtleta.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoAtleta.TabIndex = 20;
            // 
            // chkLesao
            // 
            this.chkLesao.AutoSize = true;
            this.chkLesao.Location = new System.Drawing.Point(54, 262);
            this.chkLesao.Name = "chkLesao";
            this.chkLesao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkLesao.Size = new System.Drawing.Size(56, 19);
            this.chkLesao.TabIndex = 22;
            this.chkLesao.Text = "Lesão";
            this.chkLesao.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(161, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(54, 287);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 23);
            this.txtPeso.TabIndex = 23;
            // 
            // dbgAvaliacoes
            // 
            this.dbgAvaliacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgAvaliacoes.Location = new System.Drawing.Point(12, 330);
            this.dbgAvaliacoes.Name = "dbgAvaliacoes";
            this.dbgAvaliacoes.RowTemplate.Height = 25;
            this.dbgAvaliacoes.Size = new System.Drawing.Size(776, 279);
            this.dbgAvaliacoes.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.dbgAvaliacoes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.chkLesao);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCodigoAtleta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAlergias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBatimentosCardiacos);
            this.Controls.Add(this.txtPressao);
            this.Controls.Add(this.txtTemperaturaCorporal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVelocidadeMedia);
            this.Controls.Add(this.txtPercentualGordura);
            this.Controls.Add(this.txtTempoJogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Avaliação Médica de Desempenho de Atleta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbgAvaliacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTempoJogo;
        private System.Windows.Forms.TextBox txtPercentualGordura;
        private System.Windows.Forms.TextBox txtVelocidadeMedia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTemperaturaCorporal;
        private System.Windows.Forms.TextBox txtPressao;
        private System.Windows.Forms.TextBox txtBatimentosCardiacos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAlergias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigoAtleta;
        private System.Windows.Forms.CheckBox chkLesao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.DataGridView dbgAvaliacoes;
    }
}

