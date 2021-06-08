
namespace GesFut.Telas.FormConsultaAtleta
{
    partial class FormConsultaAtleta
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
            this.dbgAtleta = new System.Windows.Forms.DataGridView();
            this.btnCadastrarAtleta = new System.Windows.Forms.Button();
            this.btnAvaliacoesMedicas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbgAtleta)).BeginInit();
            this.SuspendLayout();
            // 
            // dbgAtleta
            // 
            this.dbgAtleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgAtleta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dbgAtleta.Location = new System.Drawing.Point(13, 13);
            this.dbgAtleta.MultiSelect = false;
            this.dbgAtleta.Name = "dbgAtleta";
            this.dbgAtleta.ReadOnly = true;
            this.dbgAtleta.RowTemplate.Height = 25;
            this.dbgAtleta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbgAtleta.Size = new System.Drawing.Size(775, 235);
            this.dbgAtleta.TabIndex = 0;
            this.dbgAtleta.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgAtleta_RowEnter);
            // 
            // btnCadastrarAtleta
            // 
            this.btnCadastrarAtleta.Location = new System.Drawing.Point(12, 254);
            this.btnCadastrarAtleta.Name = "btnCadastrarAtleta";
            this.btnCadastrarAtleta.Size = new System.Drawing.Size(123, 23);
            this.btnCadastrarAtleta.TabIndex = 1;
            this.btnCadastrarAtleta.Text = "Cadastrar Atleta";
            this.btnCadastrarAtleta.UseVisualStyleBackColor = true;
            this.btnCadastrarAtleta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAvaliacoesMedicas
            // 
            this.btnAvaliacoesMedicas.Location = new System.Drawing.Point(141, 254);
            this.btnAvaliacoesMedicas.Name = "btnAvaliacoesMedicas";
            this.btnAvaliacoesMedicas.Size = new System.Drawing.Size(127, 23);
            this.btnAvaliacoesMedicas.TabIndex = 2;
            this.btnAvaliacoesMedicas.Text = "Avaliações Médicas";
            this.btnAvaliacoesMedicas.UseVisualStyleBackColor = true;
            this.btnAvaliacoesMedicas.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormConsultaAtleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 294);
            this.Controls.Add(this.btnAvaliacoesMedicas);
            this.Controls.Add(this.btnCadastrarAtleta);
            this.Controls.Add(this.dbgAtleta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormConsultaAtleta";
            this.Text = "FormConsultaAtleta";
            ((System.ComponentModel.ISupportInitialize)(this.dbgAtleta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCadastrarAtleta;
        private System.Windows.Forms.DataGridView dbgAtleta;
        private System.Windows.Forms.Button btnAvaliacoesMedicas;
    }
}