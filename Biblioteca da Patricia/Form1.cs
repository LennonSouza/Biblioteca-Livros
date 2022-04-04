using Biblioteca_da_Patricia.Opcoes;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Biblioteca_da_Patricia
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();

            string arquivo = File.ReadAllText("DB.json");
            RootObject pessoa = JsonConvert.DeserializeObject<RootObject>(arquivo);
            dataGridView1.DataSource = pessoa.Livros;
            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 168;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 140;
            dataGridView1.Columns[5].Width = 60;
            dataGridView1.Columns[6].Width = 50;
            dataGridView1.Columns[7].Width = 40;
        }

        private void checkbox_adicionar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_adicionar.Checked == true)
            {
                this.Hide();
                Adicionar add = new Adicionar();
                add.ShowDialog();
                this.Show();

                checkbox_adicionar.Checked = false;
            }
        }

        private void checkbox_atualizar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_atualizar.Checked == true)
            {
                this.Hide();
                Atualizar att = new Atualizar();
                att.ShowDialog();
                this.Show();

                checkbox_atualizar.Checked = false;
            }
        }

        private void checkbox_deletar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_deletar.Checked == true)
            {
                Deletar del = new Deletar();
                del.Show();

                checkbox_deletar.Checked = false;
            }
        }

        private void checkbox_pesquisar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_pesquisar.Checked == true)
            {
                Procurar pesquisar = new Procurar();
                pesquisar.Show();

                checkbox_pesquisar.Checked = false;
            }
        }

        private void checkbox_imprimir_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_imprimir.Checked == true)
            {
                this.Hide();
                ImprimindoPDF imprimir = new ImprimindoPDF();
                imprimir.ShowDialog();
                this.Show();

                checkbox_imprimir.Checked = false;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }      
}
