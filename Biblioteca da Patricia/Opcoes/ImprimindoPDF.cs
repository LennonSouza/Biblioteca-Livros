using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Root.Reports;

namespace Biblioteca_da_Patricia
{
    public partial class ImprimindoPDF : MetroFramework.Forms.MetroForm
    {
        public ImprimindoPDF()
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

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            string arquivo = File.ReadAllText("DB.json");
            RootObject pessoa = JsonConvert.DeserializeObject<RootObject>(arquivo);

            // Variavel do Nome e caminho do arquivo
            string vArq = "";

            // Abre janela para usuário escolher a pasta onde o arquivo será gerado
            FolderBrowserDialog vSalvar = new FolderBrowserDialog();

            // Verifica se o usuário clicou em ok ou cancelar na janela de seleção da pasta
            if (vSalvar.ShowDialog() == DialogResult.Cancel)

                return; // Cancela todo processo

            //Define hora exata para o nome do arquivo (dia_mes_ano_hora_minuto_segundo_milisegundo)
            DateTime hora = DateTime.Now;
            string nomeArquivo = hora.ToString("dd_MMMM_yyyy_H_mm_ss_fff");

            // Insere na variavel o caminho selecionado pelo usuário e concatena com o nome do arquivo
            vArq = vSalvar.SelectedPath + "\\" + nomeArquivo + ".pdf";
           
            try
            {
                // Cria um objeto PDF
                Report vPdf = new Report(new PdfFormatter());

                // Define a fonte que sera usada no relatório PDF
                FontDef vDef = new FontDef(vPdf, FontDef.StandardFont.TimesRoman);
                FontProp vDrop = new FontProp(vDef, 6);

                // Cria uma Nova Pagina
                Page vPage = new Page(vPdf);
                Double rX = 15;
                Double rY = 10;
                vPage.AddMM(rX, rY, new RepString(vDrop, "Id"));
                vPage.AddMM(rX + 10, rY, new RepString(vDrop, "Nome"));
                vPage.AddMM(rX + 50, rY, new RepString(vDrop, "Autor"));
                vPage.AddMM(rX + 80, rY, new RepString(vDrop, "Gênero"));
                vPage.AddMM(rX + 100, rY, new RepString(vDrop, "Sub-Gênero"));
                vPage.AddMM(rX + 135, rY, new RepString(vDrop, "Pratileira"));
                vPage.AddMM(rX + 150, rY, new RepString(vDrop, "Ano"));
                vPage.AddMM(rX + 165, rY, new RepString(vDrop, "Lido"));
                foreach (var livro in pessoa.Livros)
                {
                    rY += vDrop.rLineFeedMM;
                    // Escreve no Arquivo
                    
                    vPage.AddMM(rX, rY, new RepString(vDrop, Convert.ToString(livro.Id)));
                    vPage.AddMM(rX + 10, rY, new RepString(vDrop, livro.Nome));
                    vPage.AddMM(rX + 50, rY, new RepString(vDrop, livro.Autor));
                    vPage.AddMM(rX + 80, rY, new RepString(vDrop, livro.Genero));
                    vPage.AddMM(rX + 100, rY, new RepString(vDrop, livro.Subgenero));
                    vPage.AddMM(rX + 135, rY, new RepString(vDrop, livro.Pratileira));
                    vPage.AddMM(rX + 150, rY, new RepString(vDrop, Convert.ToString(livro.Ano)));
                    vPage.AddMM(rX + 165, rY, new RepString(vDrop, Convert.ToString(livro.Lido.ToString().Replace("True", "Sim").Replace("False","Não"))));
                }

                // Salvar Arquivo no disco
                vPdf.Save(vArq);

                MessageBox.Show("Arquivo Gerado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Gerar arquivo: {ex.Message}.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
