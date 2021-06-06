using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesFut
{
    public partial class FormAvaliacaoMedica : Form
    {
        public FormAvaliacaoMedica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AvaliacaoMedica avaliacao = new AvaliacaoMedica();
            avaliacao.CodigoAtleta = Convert.ToInt32(txtCodigoAtleta.Text);
            avaliacao.DataAvaliacao = DateTime.Now;
            avaliacao.UsuarioResponsavel = 1; // admin
            avaliacao.Peso = Convert.ToDouble(txtPeso.Text);
            avaliacao.TemperaturaCorporal = Convert.ToDouble(txtTemperaturaCorporal.Text);
            avaliacao.Pressao = txtPressao.Text;
            avaliacao.BatimentosCardiacos = Convert.ToInt32(txtBatimentosCardiacos.Text);
            avaliacao.Alergias = txtAlergias.Text;
            avaliacao.Lesao = chkLesao.Checked;

            ConexaoDB conexao = new ConexaoDB();
            conexao.InsertDados(avaliacao);

            LoadData();
            MessageBox.Show("Informações Salvas!");

            //teste de commit 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("jnksdvsdnjksdvjk");

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            ConexaoDB conexao = new ConexaoDB();
            DataSet dataset = conexao.RetornarDados(AvaliacaoMedica.GetSelect());

            //atribui o datatable ao datagridview para exibir o resultado
            dbgAvaliacoes.DataSource = dataset.Tables[0];
        }


    }
}
