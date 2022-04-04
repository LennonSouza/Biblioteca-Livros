using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca_da_Patricia.Opcoes
{
    public partial class Procurar : MetroFramework.Forms.MetroForm
    {
        public Procurar()
        {
            InitializeComponent();
            this.ActiveControl = txtpesquisar;
            txtpesquisar.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Encoding utf8 = Encoding.UTF8;
            string json = File.ReadAllText("DB.json").ToLower();

            Livro mafile = JsonConvert.DeserializeObject<Livro>(json);
            try
            {
                var jObject = JObject.Parse(json);
                JArray arrayExperiencias = (JArray)jObject["Livros".ToLower()];

                string id = txtpesquisar.Text.ToLower();

                if (json.Contains(id))
                {
                    var idLivro = id;

                    foreach (var livro in arrayExperiencias.Where(obj => obj["nome"].Value<string>() == idLivro))
                    {
                        MessageBox.Show($"Id: { livro["id"]} " +
                            $"\nNome: { livro["nome"]} " +
                            $"\nAutor: {livro["autor"]} " +
                            $"\nGêmero: {livro["genero"]} " +
                            $"\nSub-Gênero: {livro["subgenero"]} " +
                            $"\nAno: {livro["ano"]}");
                    }
                }
                else
                {
                    MessageBox.Show("O nome do Livro é inválido, tente novamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Deletar: " + ex.Message.ToString());
            }
            Limpar.LimparTODOSTextBox(this);
        }
    }
}
