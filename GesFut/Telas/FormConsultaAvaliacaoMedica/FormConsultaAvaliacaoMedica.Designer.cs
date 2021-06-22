
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
            this.dbgAvaliacaoMedica = new System.Windows.Forms.DataGridView();
            this.btnCadastrarAvaliacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbgAvaliacaoMedica)).BeginInit();
            this.SuspendLayout();
            // 
            // dbgAvaliacaoMedica
            // 
            this.dbgAvaliacaoMedica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgAvaliacaoMedica.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dbgAvaliacaoMedica.Location = new System.Drawing.Point(12, 12);
            this.dbgAvaliacaoMedica.MultiSelect = false;
            this.dbgAvaliacaoMedica.Name = "dbgAvaliacaoMedica";
            this.dbgAvaliacaoMedica.ReadOnly = true;
            this.dbgAvaliacaoMedica.RowTemplate.Height = 25;
            this.dbgAvaliacaoMedica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbgAvaliacaoMedica.Size = new System.Drawing.Size(776, 279);
            this.dbgAvaliacaoMedica.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.btnCadastrarAvaliacao);
            this.Controls.Add(this.dbgAvaliacaoMedica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaAvaliacaoMedica";
            this.Text = "FormConsultaAvaliacaoMedica";
            ((System.ComponentModel.ISupportInitialize)(this.dbgAvaliacaoMedica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbgAvaliacaoMedica;
        private System.Windows.Forms.Button btnCadastrarAvaliacao;
    }
}