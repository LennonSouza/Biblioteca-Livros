using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Biblioteca_da_Patricia.Opcoes
{
    public partial class Adicionar : MetroFramework.Forms.MetroForm
    {
        public string arquivo;
        int i;
        public Adicionar()
        {
            InitializeComponent();
            this.ActiveControl = txtnome;
            txtnome.Focus();

            string arquivo = File.ReadAllText("DB.json");
            RootObject pessoa = JsonConvert.DeserializeObject<RootObject>(arquivo);

            lbl_contador.Text = Convert.ToString(pessoa.Livros.Count + 1);

            dataGridView1.DataSource = pessoa.Livros;
            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 170;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 140;
            dataGridView1.Columns[5].Width = 60;
            dataGridView1.Columns[6].Width = 50;
            dataGridView1.Columns[7].Width = 40;

            txtnome.MaxLength = 30;
            txtautor.MaxLength = 25;
            txtpratileira.MaxLength = 2;
            txtano.MaxLength = 4;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string arquivo = File.ReadAllText("DB.json");
            RootObject pessoa = JsonConvert.DeserializeObject<RootObject>(arquivo);

            if (!arquivo.Contains(txtnome.Text.ToLower().ToUpper()))
            {
                if (cblido.CheckState == CheckState.Checked)
                {
                    cblido.Enabled = true;
                }

                Livro addLivro = new Livro
                {
                    Nome = txtnome.Text,
                    Autor = txtautor.Text,
                    Genero = cbgenero.Text,
                    Subgenero = cbsubgenero.Text,
                    Pratileira = txtpratileira.Text,
                    Lido = cblido.Checked,
                    Id = pessoa.Livros.Count + 1
                };

                string ano = txtano.Text;

                bool b = int.TryParse(ano, out i);
                if (b)
                {
                    addLivro.Ano = Convert.ToInt32(ano);

                    try
                    {
                        pessoa.Livros.Add(addLivro);
                        var DB_serializado = JsonConvert.SerializeObject(pessoa, Formatting.Indented);
                        File.WriteAllText("DB.json", DB_serializado);
                        MessageBox.Show("Livro adicionado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Você digitou um numero incorreto, tente novemente!\n");
                }
            }
            else 
            {
                MessageBox.Show("Você já tem esse livro adicionado!");
            }
            Limpar.LimparTODOSTextBox(this);
            lbl_contador.Text = Convert.ToString(pessoa.Livros.Count + 1);
            dataGridView1.DataSource = pessoa.Livros;
        }

        private void Adicionar_Load(object sender, EventArgs e)
        {
            cbgenero.Items.Add("Ficção");
            cbgenero.Items.Add("Não Ficção");
            cbgenero.Items.Add("Biografia");
            cbgenero.Items.Add("Técnico");
        }

        private void cbgenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbgenero.SelectedIndex == 0 || cbgenero.SelectedIndex == 1 || cbgenero.SelectedIndex == 2 || cbgenero.SelectedIndex == 3)
            {
                cbsubgenero.Visible = true;
                lblsubgenero.Visible = true;
            }

            if (cbgenero.SelectedItem.ToString() == "Ficção")
            {
                string a = cbgenero.SelectedItem.ToString();
                cbsubgenero.Items.Clear();

                if (a == "Ficção")
                {
                    cbsubgenero.Items.Add("Aventura");
                    cbsubgenero.Items.Add("Chick-Lit");
                    cbsubgenero.Items.Add("Clássico");
                    cbsubgenero.Items.Add("Contos");
                    cbsubgenero.Items.Add("Contos de Fada");
                    cbsubgenero.Items.Add("Crônicas");
                    cbsubgenero.Items.Add("Erótica");
                    cbsubgenero.Items.Add("Fantasia");
                    cbsubgenero.Items.Add("Infanto-Juvenil");
                    cbsubgenero.Items.Add("Jovem Adulto (YA)");
                    cbsubgenero.Items.Add("Lad Lit");
                    cbsubgenero.Items.Add("Literatura Nacional");
                    cbsubgenero.Items.Add("Literatura Cristã");
                    cbsubgenero.Items.Add("Livros de Colorir");
                    cbsubgenero.Items.Add("Mistério");
                    cbsubgenero.Items.Add("New Adult");
                    cbsubgenero.Items.Add("Paranormal");
                    cbsubgenero.Items.Add("Poesia");
                    cbsubgenero.Items.Add("Quadrinhos");
                    cbsubgenero.Items.Add("Realismo Fantástico");
                    cbsubgenero.Items.Add("Romance Contemporâneo");
                    cbsubgenero.Items.Add("Romance de Banca");
                    cbsubgenero.Items.Add("Romance Epistolar");
                    cbsubgenero.Items.Add("Romance Gay");
                    cbsubgenero.Items.Add("Romance Gótico");
                    cbsubgenero.Items.Add("Romance Histórico");
                    cbsubgenero.Items.Add("Romance Policial");
                    cbsubgenero.Items.Add("Romance Psicológico");
                    cbsubgenero.Items.Add("Ficção Cientifica");
                    cbsubgenero.Items.Add("Sobrenatural");
                    cbsubgenero.Items.Add("Suspense");
                    cbsubgenero.Items.Add("Suspense Romântico");
                    cbsubgenero.Items.Add("Terror");
                    cbsubgenero.Items.Add("Thriller");
                    cbsubgenero.Items.Add("Thriller Médico");
                    cbsubgenero.Items.Add("Urban Fantasy");
                }
            }
            else if (cbgenero.SelectedItem.ToString() == "Não Ficção")
            {
                string a = cbgenero.SelectedItem.ToString();
                cbsubgenero.Items.Clear();

                if (a == "Não Ficção")
                {
                    cbsubgenero.Items.Add("Almanaque");
                    cbsubgenero.Items.Add("Artigo científico");
                    cbsubgenero.Items.Add("Auto-Ajuda");
                    cbsubgenero.Items.Add("Carta");
                    cbsubgenero.Items.Add("Crítica literária");
                    cbsubgenero.Items.Add("Diagrama");
                    cbsubgenero.Items.Add("Diário");
                    cbsubgenero.Items.Add("Dicionário");
                    cbsubgenero.Items.Add("Documentário");
                    cbsubgenero.Items.Add("Enciclopédia");
                    cbsubgenero.Items.Add("Ensaio");
                    cbsubgenero.Items.Add("Filosofia");
                    cbsubgenero.Items.Add("Fotografia");
                    cbsubgenero.Items.Add("História");
                    cbsubgenero.Items.Add("História natural");
                    cbsubgenero.Items.Add("Jornal");
                    cbsubgenero.Items.Add("Jornalismo");
                    cbsubgenero.Items.Add("Memórias");
                    cbsubgenero.Items.Add("Idiomas");
                    cbsubgenero.Items.Add("Catálogos ");
                    cbsubgenero.Items.Add("Manuais");
                }
            } 
            else if (cbgenero.SelectedItem.ToString() == "Biografia") 
            {
                string a = cbgenero.SelectedItem.ToString();
                cbsubgenero.Items.Clear();

                if (a == "Biografia")
                {
                    cbsubgenero.Items.Add("Auto biografia");
                    cbsubgenero.Items.Add("Biografia Autorizada");
                    cbsubgenero.Items.Add("Biografia Não  Autorizada");
                }
            }
            else if (cbgenero.SelectedItem.ToString() == "Técnico")
            {
                string a = cbgenero.SelectedItem.ToString();
                cbsubgenero.Items.Clear();

                if (a == "Técnico")
                {
                    cbsubgenero.Items.Add("Ciências sociais aplicadas");
                    cbsubgenero.Items.Add("Ciências Humanas");
                    cbsubgenero.Items.Add("Guias");
                    cbsubgenero.Items.Add("Manuais técnicos");
                    cbsubgenero.Items.Add("Culinária");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Adicionar_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
