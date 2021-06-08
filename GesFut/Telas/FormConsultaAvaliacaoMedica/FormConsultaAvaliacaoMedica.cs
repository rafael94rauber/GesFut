using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GesFut.Telas.FormConsultaAvaliacaoMedica
{
    public partial class FormConsultaAvaliacaoMedica : Form
    {
        private int CodigoAtleta;
        public FormConsultaAvaliacaoMedica(int CodigoAtleta)
        {
            InitializeComponent();
            this.CodigoAtleta = CodigoAtleta;
            LoadDados();
        }

        private void LoadDados()
        {
            ConexaoDB conexao = new ConexaoDB();
            DataSet dataset = conexao.RetornarDados(AvaliacaoMedica.GetSQLConsulta(this.CodigoAtleta));
        }


        private void btnCadastrarAvaliacao_Click(object sender, EventArgs e)
        {
            FormAvaliacaoMedica formAvaliacaoMedica = new FormAvaliacaoMedica(1);
            formAvaliacaoMedica.ShowDialog();
            LoadDados();
        }
    }
}
