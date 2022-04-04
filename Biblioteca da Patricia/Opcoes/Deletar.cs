using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca_da_Patricia.Opcoes
{
    public partial class Deletar : MetroFramework.Forms.MetroForm
    {
        int i;
        public Deletar()
        {
            InitializeComponent();
            this.ActiveControl = txtId_Deletar;
            txtId_Deletar.Focus();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("DB.json");
            try
            {
                var jObject = JObject.Parse(json);
                JArray arrayExperiencias = (JArray)jObject["Livros"];

                string id = txtId_Deletar.Text;
                bool b = int.TryParse(id, out i);

                if (b)
                {
                    var idLivro = Convert.ToInt32(id);

                    var livroADeletar = arrayExperiencias.FirstOrDefault(obj => obj["id"].Value<int>() == idLivro);

                    arrayExperiencias.Remove(livroADeletar);

                    string saida = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                    File.WriteAllText("DB.json", saida);
                    MessageBox.Show("Livro deletado com sucesso!");
                }
                else
                {
                    MessageBox.Show("O ID do Livro é inválido, tente novamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Deletar: " + ex.Message.ToString());
            }
            Limpar.LimparTODOSTextBox(this);
        }

        private void Deletar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form1 att = new Form1();
            att.ShowDialog();
            this.Show();
        }
    }
}
