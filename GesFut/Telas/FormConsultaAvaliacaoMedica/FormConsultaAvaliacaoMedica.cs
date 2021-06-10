﻿using System;
using System.Data;
using System.Windows.Forms;

namespace GesFut
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
            dbgAvaliacaoMedica.DataSource = dataset.Tables[0];
        }


        private void btnCadastrarAvaliacao_Click(object sender, EventArgs e)
        {
            FormAvaliacaoMedica formAvaliacaoMedica = new FormAvaliacaoMedica(CodigoAtleta);
            formAvaliacaoMedica.ShowDialog();
            LoadDados();
        }
    }
}
