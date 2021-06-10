using System;
using System.Data;
using System.Windows.Forms;


namespace GesFut
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
            if (CodigoAtleta <= 0)
            {
                MessageBox.Show("Selecione um atleta");
                return;
            } 
            
            FormConsultaAvaliacaoMedica formConsultaAvaliacaoMedica = new FormConsultaAvaliacaoMedica(CodigoAtleta);
            formConsultaAvaliacaoMedica.ShowDialog();
        }

        private void dbgAtleta_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CodigoAtleta = Convert.ToInt32(dbgAtleta.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch
            {
                CodigoAtleta = 0;
            }

        }
    }
}
