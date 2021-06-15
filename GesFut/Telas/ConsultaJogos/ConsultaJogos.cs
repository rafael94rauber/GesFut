using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GesFut
{
    public partial class ConsultaJogos : Form
    {
        public ConsultaJogos()
        {
            InitializeComponent();
        }

        private void ConsultaJogos_Load(object sender, EventArgs e)
        {
            LoadDados();
        }
        private void LoadDados()
        {
            ConexaoDB conexao = new ConexaoDB();
            DataSet dataset = conexao.RetornarDados(Jogos.GetSQLConsulta());
            gdvConsultaJogos.DataSource = dataset.Tables[0];
        }
    }
}
