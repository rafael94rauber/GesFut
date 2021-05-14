using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            FormCadastroAtleta formCadastroAtleta = new FormCadastroAtleta();
            formCadastroAtleta.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAvaliacaoMedia_Click(object sender, EventArgs e)
        {
            FormAvaliacaoMedica formAvaliacaoMedica = new FormAvaliacaoMedica();
            formAvaliacaoMedica.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
