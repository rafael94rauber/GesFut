using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GesFut;
using GesFut.Telas.FormConsultaAvaliacaoMedica;


namespace GesFut.Telas.FormConsultaAtleta
{
    public partial class FormConsultaAtleta : Form
    {
        private int CodigoAtleta;
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

            FormConsultaAvaliacaoMedica formConsultaAvaliacaoMedica = new FormConsultaAvaliacaoMedica(CodigoAtleta);
            formConsultaAvaliacaoMedica.ShowDialog();
        }

        private void dbgAtleta_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CodigoAtleta = Convert.ToInt32(dbgAtleta.Rows[e.RowIndex].Cells[1].Value.ToString());
        }
    }
}
