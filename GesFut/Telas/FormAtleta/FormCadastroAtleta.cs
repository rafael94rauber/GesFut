using System;
using System.Text;
using System.Windows.Forms;

namespace GesFut
{
    public partial class FormCadastroAtleta : Form
    {
        private Atleta atleta;
        public FormCadastroAtleta()
        {
            InitializeComponent();
            atleta = null;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastroAtleta_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ClearCampos()
        {
            edtCPF.Clear();
            edtEmail.Clear();
            edtEndereco.Clear();
            edtNascimento.Clear();
            edtNome.Clear();
            edtSexo.Clear();
            edtTelefone.Clear();
        }

        private void salvarAtleta_Click(object sender, EventArgs e)
        {
            var resultado = validaTela();
            if (!(resultado is null))
            {
                MessageBox.Show(resultado);
                return;
            }
            if (this.atleta == null)
            {
                this.atleta = new Atleta(0)
                {
                    //   CodigoAtleta = Cod
                    Nome = edtNome.Text,
                    Email = edtEmail.Text,
                    Telefone = edtTelefone.Text,
                    Endereco = edtEndereco.Text,
                    DataNascimento = Convert.ToDateTime(edtNascimento.Text),
                    Sexo = edtSexo.Text,
                    CPF = edtCPF.Text
                };
                ConexaoDB conexao = new ConexaoDB();
                conexao.InsertDados(atleta);
            }
            else
            {
                this.atleta.Nome = edtNome.Text;
                this.atleta.Email = edtEmail.Text;
                this.atleta.Telefone = edtTelefone.Text;
                this.atleta.Endereco = edtEndereco.Text;
                this.atleta.DataNascimento = Convert.ToDateTime(edtNascimento.Text);
                this.atleta.Sexo = edtSexo.Text;
                this.atleta.CPF = edtCPF.Text;
                ConexaoDB conexao = new ConexaoDB();
                conexao.AtualizarDados(atleta);
            };
            LimpaTela();
            MessageBox.Show("Informações Salvas!");
            this.Close();
        }

        private void LimpaTela()
        {
            edtNome.Text = "";
            edtEmail.Text = "";
            edtTelefone.Text = "";
            edtEndereco.Text = "";
            edtNascimento.Text = "";
            edtSexo.Text = "";
            edtCPF.Text = "";
            ClearCampos();
        }

        private void btnToAvaliacaoMedica_Click(object sender, EventArgs e)
        {
            FormAvaliacaoMedica formAvaliacaoMedica = new FormAvaliacaoMedica(this.atleta.CodigoAtleta);
            formAvaliacaoMedica.ShowDialog();
        }
        private string validaTela()
        {
            StringBuilder mensagem = new StringBuilder();
            mensagem.Clear();

            if (string.IsNullOrWhiteSpace(edtNome.Text))
            {
                mensagem.AppendLine("Nome");
                edtNome.Focus();
            }

            if (string.IsNullOrWhiteSpace(edtCPF.Text))
            {
                mensagem.AppendLine("CPF");
                edtCPF.Focus();
            }

            try
            {
                Convert.ToDateTime(edtNascimento.Text.Trim());
            }
            catch
            {
                mensagem.AppendLine("Data de Nascimento");
                edtNascimento.Focus();
            }

            if (edtCPF.Text.Length != 11)
            {
                mensagem.AppendLine("CPF invalido");
                edtCPF.Focus();
            }

            if (string.IsNullOrEmpty(mensagem.ToString()))
            {
                return null;
            }

            return $"Obrigatório informar os campos: \n{mensagem}";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void edtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
