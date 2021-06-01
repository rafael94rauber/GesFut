using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void salvarAtleta_Click(object sender, EventArgs e)
        {
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
                    CPF = edtCPF.Text,
                };
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
                };
            }

            RequestApi request = new RequestApi();
            var resposta = request.IncluirAtleta(atleta);

            //LoadData();
            MessageBox.Show("Informações Salvas!");
    private void btnToAvaliacaoMedica_Click(object sender, EventArgs e)
        {
            FormAvaliacaoMedica formAvaliacaoMedica = new FormAvaliacaoMedica(this.atleta.CodigoAtleta);
            formAvaliacaoMedica.ShowDialog();
        }
    }
}
