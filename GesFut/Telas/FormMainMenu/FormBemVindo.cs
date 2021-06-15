using System;
using System.Windows.Forms;

namespace GesFut
{
    public partial class FormBemVindo : Form
    {
        public FormBemVindo()
        {
            InitializeComponent();
        }

        private void btnCadastroAtleta_Click(object sender, EventArgs e)
        {
            FormConsultaAtleta formConsultaAtleta = new FormConsultaAtleta();
            formConsultaAtleta.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConsultaJogos_Click(object sender, EventArgs e)
        {
            ConsultaJogos formConsultaJogos = new ConsultaJogos();
            formConsultaJogos.Show();
        }
    }
}
