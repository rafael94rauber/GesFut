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
        public FormCadastroAtleta()
        {
            InitializeComponent();
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
            var atleta = new Atleta
            {
                //   CodigoAtleta = Cod
                Nome = nome.Text,
                Idade = Convert.ToInt32(idade.Text),
                Email = email.Text,
                Telefone = telefone.Text,
                Endereco = endereco.Text,
                Nascimento = nascimento.Text,
                Sexo = sexo.Text,
                CPF = CPF.Text,
            };

            // RequestApi request = new RequestApi();
            //var resposta = request.AtualizarAtleta(atleta);

            //LoadData();
            MessageBox.Show("Informações Salvas!");
        }
    }
}
