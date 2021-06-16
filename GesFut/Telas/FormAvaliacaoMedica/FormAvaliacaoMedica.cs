using System;
using System.Text;
using System.Windows.Forms;

namespace GesFut
{
    public partial class FormAvaliacaoMedica : Form
    {
        private int CodigoAtleta;
        public FormAvaliacaoMedica(int CodigoAtleta)
        {
            InitializeComponent();
            this.CodigoAtleta = CodigoAtleta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = ValidaTela();
            if (!(resultado is null))
            {
                MessageBox.Show(resultado);
                return;
            }

            //Calculo de Aptidao
            int aptidao = (Convert.ToInt32(txtFadiga.Text) + Convert.ToInt32(txtFitness.Text)) / 2;

            MessageBox.Show("Atleta com " + aptidao + "% de aptidão para o próximo jogo");


            var avaliacao = new AvaliacaoMedica
            {
                CodigoAtleta = this.CodigoAtleta,
                DataAvaliacao = DateTime.Now,
                UsuarioResponsavel = 1, // admin
                Peso = Convert.ToDouble(txtPeso.Text),
                TemperaturaCorporal = Convert.ToDouble(txtTemperaturaCorporal.Text),
                Pressao = txtPressao.Text,
                BatimentosCardiacos = Convert.ToInt32(txtBatimentosCardiacos.Text),
                Alergias = txtAlergias.Text,
                Lesao = chkLesao.Checked,
                Fadiga = Convert.ToInt32(txtFadiga.Text),
                Fitness = Convert.ToInt32(txtFitness.Text)
            };

            ConexaoDB conexao = new ConexaoDB();
            conexao.InsertDados(avaliacao);

            LimpaTela();
            MessageBox.Show("Informações Salvas!");
            this.Close();

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

        public void LimpaTela()
        {
            txtTempoJogo.Text = "";
            txtTemperaturaCorporal.Text = "";
            txtPercentualGordura.Text = "";
            txtPressao.Text = "";
            txtVelocidadeMedia.Text = "";
            txtBatimentosCardiacos.Text = "";
            txtPeso.Text = "";
            txtAlergias.Text = "";
            chkLesao.Checked = false;
            txtFadiga.Text = "";
            txtFitness.Text = "";
        }

        private void chkLesao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private string ValidaTela()
        {
            StringBuilder mensagem = new StringBuilder();
            mensagem.Clear();

            try
            {
                Convert.ToDouble(txtPeso.Text);
            }
            catch
            {
                mensagem.AppendLine("Peso");
                txtPeso.Focus();
            }
            try
            {
                Convert.ToDouble(txtTemperaturaCorporal.Text);
            }
            catch
            {
                mensagem.AppendLine("Temperatura Corporal");
                txtTemperaturaCorporal.Focus();
            }

            try
            {
                Convert.ToInt32(txtBatimentosCardiacos.Text);
            }
            catch
            {
                mensagem.AppendLine("Batimentos Cardíacoszn");
                txtBatimentosCardiacos.Focus();
            }

            try
            {
                Convert.ToInt32(txtFadiga.Text);
            }
            catch
            {
                mensagem.AppendLine("Fadiga");
                txtFadiga.Focus();
            }

            try
            {
                Convert.ToInt32(txtFitness.Text);
            }
            catch
            {
                mensagem.AppendLine("Fitness");
                txtFitness.Focus();
            }

            if (string.IsNullOrEmpty(mensagem.ToString()))
            {
                return null;
            }

            return $"Obrigatório informar os campos: \n{mensagem}";
        }
    }
}
