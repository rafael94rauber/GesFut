
namespace GesFut
{
    partial class ConsultaJogos
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
            this.gdvConsultaJogos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gdvConsultaJogos)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvConsultaJogos
            // 
            this.gdvConsultaJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvConsultaJogos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gdvConsultaJogos.Location = new System.Drawing.Point(12, 12);
            this.gdvConsultaJogos.MultiSelect = false;
            this.gdvConsultaJogos.Name = "gdvConsultaJogos";
            this.gdvConsultaJogos.ReadOnly = true;
            this.gdvConsultaJogos.RowTemplate.Height = 25;
            this.gdvConsultaJogos.Size = new System.Drawing.Size(776, 279);
            this.gdvConsultaJogos.TabIndex = 1;
            this.gdvConsultaJogos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvConsultaJogos_CellContentClick);
            // 
            // ConsultaJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 303);
            this.Controls.Add(this.gdvConsultaJogos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaJogos";
            this.Text = "ConsultaJogos";
            this.Load += new System.EventHandler(this.ConsultaJogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvConsultaJogos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvConsultaJogos;
    }
}