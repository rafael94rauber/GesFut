﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GesFut.Telas.FormConsultaAtleta;

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
    }
}
