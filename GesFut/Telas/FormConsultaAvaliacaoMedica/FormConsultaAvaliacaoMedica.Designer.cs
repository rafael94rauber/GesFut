
namespace GesFut
{
    partial class FormConsultaAvaliacaoMedica
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCadastrarAvaliacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCadastrarAvaliacao
            // 
            this.btnCadastrarAvaliacao.Location = new System.Drawing.Point(12, 297);
            this.btnCadastrarAvaliacao.Name = "btnCadastrarAvaliacao";
            this.btnCadastrarAvaliacao.Size = new System.Drawing.Size(163, 23);
            this.btnCadastrarAvaliacao.TabIndex = 1;
            this.btnCadastrarAvaliacao.Text = "Cadastrar Avaliação Médica";
            this.btnCadastrarAvaliacao.UseVisualStyleBackColor = true;
            this.btnCadastrarAvaliacao.Click += new System.EventHandler(this.btnCadastrarAvaliacao_Click);
            // 
            // FormConsultaAvaliacaoMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarAvaliacao);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormConsultaAvaliacaoMedica";
            this.Text = "FormConsultaAvaliacaoMedica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCadastrarAvaliacao;
    }
}