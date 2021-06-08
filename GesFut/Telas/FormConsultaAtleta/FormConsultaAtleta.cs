using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GesFut;


namespace GesFut.Telas.FormConsultaAtleta
{
    public partial class FormConsultaAtleta : Form
    {
        public FormConsultaAtleta()
        {
            InitializeComponent();
            LoadDados();
        }

        private void LoadDados()
        {
            ConexaoDB conexao = new ConexaoDB();
            DataSet dataset = conexao.RetornarDados(Atleta.GetSQLConsulta());
            dbgAtleta.DataSource = dataset.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormCadastroAtleta formCadastroAtleta = new FormCadastroAtleta();
            formCadastroAtleta.ShowDialog();
            LoadDados();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //dbgAtleta.Selected
            //FormConsultaAvaliacaoMedica formConsultaAvaliacaoMedica = new FormConsultaAvaliacaoMedica(1);
            //formConsultaAvaliacaoMedica.ShowDialog();
        }
    }
}
