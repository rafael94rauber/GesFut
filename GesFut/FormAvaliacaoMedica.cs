using System;
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
            var avaliacao = new Avaliacao
            {
                CodigoAtleta = Convert.ToInt32(txtCodigoAtleta.Text),
                DataAvaliacao = DateTime.Now,
                UsuarioResponsavel = 1, // admin
                Peso = Convert.ToDouble(txtPeso.Text),
                //TemperaturaCorporal = Convert.ToDouble(txtTemperaturaCorporal.Text),
                //Pressao = txtPressao.Text,
                //BatimentosCardiacos = Convert.ToInt32(txtBatimentosCardiacos.Text),
                //Alergias = txtAlergias.Text,
                //Lesao = chkLesao.Checked
            };

            RequestApi request = new RequestApi();
            var resposta = request.AtualizarAvaliacao(avaliacao);

            LoadData();
            LimpaTela();
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
            //buscar metodo da api

            //atribui o datatable ao datagridview para exibir o resultado
            //dbgAvaliacoes.DataSource = dataset.Tables[0];
        }

        public voida LimpaTela()
        {
            txtCodigoAtleta.Text = "";
            txtPeso.Text = "";
            txtTemperaturaCorporal.Text = "";
            txtPressao.Text = "";
            txtBatimentosCardiacos.Text = "";
            txtAlergias.Text = "";
            chkLesao.Checked = false;
        }


    }
}
