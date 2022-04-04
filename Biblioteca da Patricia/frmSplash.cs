using System;
using System.Windows.Forms;

namespace Biblioteca_da_Patricia
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            progressBar1.Maximum = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCarregamento.Text = progressBar1.Value + "%";

            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;

                this.Hide();
                Form1 MDI = new Form1();
                MDI.ShowDialog(); 
            }
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FrmSplash_FormClosed(object sender, FormClosedEventArgs e)
        {
           // this.Close();
        }
    }
}