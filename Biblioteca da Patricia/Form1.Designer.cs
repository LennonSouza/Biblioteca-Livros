namespace Biblioteca_da_Patricia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkbox_adicionar = new System.Windows.Forms.CheckBox();
            this.gbox_adicionar = new System.Windows.Forms.GroupBox();
            this.gbox_atualizar = new System.Windows.Forms.GroupBox();
            this.checkbox_atualizar = new System.Windows.Forms.CheckBox();
            this.gbbox_deletar = new System.Windows.Forms.GroupBox();
            this.checkbox_deletar = new System.Windows.Forms.CheckBox();
            this.gbbox_pesquisar = new System.Windows.Forms.GroupBox();
            this.checkbox_pesquisar = new System.Windows.Forms.CheckBox();
            this.checkbox_imprimir = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbox_adicionar.SuspendLayout();
            this.gbox_atualizar.SuspendLayout();
            this.gbbox_deletar.SuspendLayout();
            this.gbbox_pesquisar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkbox_adicionar
            // 
            this.checkbox_adicionar.AutoSize = true;
            this.checkbox_adicionar.ForeColor = System.Drawing.Color.Black;
            this.checkbox_adicionar.Location = new System.Drawing.Point(6, 17);
            this.checkbox_adicionar.Name = "checkbox_adicionar";
            this.checkbox_adicionar.Size = new System.Drawing.Size(75, 18);
            this.checkbox_adicionar.TabIndex = 0;
            this.checkbox_adicionar.Text = "Selecionar";
            this.checkbox_adicionar.UseVisualStyleBackColor = true;
            this.checkbox_adicionar.CheckedChanged += new System.EventHandler(this.checkbox_adicionar_CheckedChanged);
            // 
            // gbox_adicionar
            // 
            this.gbox_adicionar.Controls.Add(this.checkbox_adicionar);
            this.gbox_adicionar.ForeColor = System.Drawing.Color.Black;
            this.gbox_adicionar.Location = new System.Drawing.Point(297, 14);
            this.gbox_adicionar.Name = "gbox_adicionar";
            this.gbox_adicionar.Size = new System.Drawing.Size(81, 48);
            this.gbox_adicionar.TabIndex = 2;
            this.gbox_adicionar.TabStop = false;
            this.gbox_adicionar.Text = "Adicionar";
            // 
            // gbox_atualizar
            // 
            this.gbox_atualizar.Controls.Add(this.checkbox_atualizar);
            this.gbox_atualizar.ForeColor = System.Drawing.Color.Black;
            this.gbox_atualizar.Location = new System.Drawing.Point(385, 15);
            this.gbox_atualizar.Name = "gbox_atualizar";
            this.gbox_atualizar.Size = new System.Drawing.Size(82, 47);
            this.gbox_atualizar.TabIndex = 3;
            this.gbox_atualizar.TabStop = false;
            this.gbox_atualizar.Text = "Atualizar";
            // 
            // checkbox_atualizar
            // 
            this.checkbox_atualizar.AutoSize = true;
            this.checkbox_atualizar.ForeColor = System.Drawing.Color.Black;
            this.checkbox_atualizar.Location = new System.Drawing.Point(6, 16);
            this.checkbox_atualizar.Name = "checkbox_atualizar";
            this.checkbox_atualizar.Size = new System.Drawing.Size(75, 18);
            this.checkbox_atualizar.TabIndex = 0;
            this.checkbox_atualizar.Text = "Selecionar";
            this.checkbox_atualizar.UseVisualStyleBackColor = true;
            this.checkbox_atualizar.CheckedChanged += new System.EventHandler(this.checkbox_atualizar_CheckedChanged);
            // 
            // gbbox_deletar
            // 
            this.gbbox_deletar.Controls.Add(this.checkbox_deletar);
            this.gbbox_deletar.ForeColor = System.Drawing.Color.Black;
            this.gbbox_deletar.Location = new System.Drawing.Point(473, 15);
            this.gbbox_deletar.Name = "gbbox_deletar";
            this.gbbox_deletar.Size = new System.Drawing.Size(82, 48);
            this.gbbox_deletar.TabIndex = 4;
            this.gbbox_deletar.TabStop = false;
            this.gbbox_deletar.Text = "Deletar";
            // 
            // checkbox_deletar
            // 
            this.checkbox_deletar.AutoSize = true;
            this.checkbox_deletar.ForeColor = System.Drawing.Color.Black;
            this.checkbox_deletar.Location = new System.Drawing.Point(6, 16);
            this.checkbox_deletar.Name = "checkbox_deletar";
            this.checkbox_deletar.Size = new System.Drawing.Size(75, 18);
            this.checkbox_deletar.TabIndex = 0;
            this.checkbox_deletar.Text = "Selecionar";
            this.checkbox_deletar.UseVisualStyleBackColor = true;
            this.checkbox_deletar.CheckedChanged += new System.EventHandler(this.checkbox_deletar_CheckedChanged);
            // 
            // gbbox_pesquisar
            // 
            this.gbbox_pesquisar.Controls.Add(this.checkbox_pesquisar);
            this.gbbox_pesquisar.ForeColor = System.Drawing.Color.Black;
            this.gbbox_pesquisar.Location = new System.Drawing.Point(561, 15);
            this.gbbox_pesquisar.Name = "gbbox_pesquisar";
            this.gbbox_pesquisar.Size = new System.Drawing.Size(82, 47);
            this.gbbox_pesquisar.TabIndex = 5;
            this.gbbox_pesquisar.TabStop = false;
            this.gbbox_pesquisar.Text = "Pesquisar";
            // 
            // checkbox_pesquisar
            // 
            this.checkbox_pesquisar.AutoSize = true;
            this.checkbox_pesquisar.ForeColor = System.Drawing.Color.Black;
            this.checkbox_pesquisar.Location = new System.Drawing.Point(6, 16);
            this.checkbox_pesquisar.Name = "checkbox_pesquisar";
            this.checkbox_pesquisar.Size = new System.Drawing.Size(75, 18);
            this.checkbox_pesquisar.TabIndex = 0;
            this.checkbox_pesquisar.Text = "Selecionar";
            this.checkbox_pesquisar.UseVisualStyleBackColor = true;
            this.checkbox_pesquisar.CheckedChanged += new System.EventHandler(this.checkbox_pesquisar_CheckedChanged);
            // 
            // checkbox_imprimir
            // 
            this.checkbox_imprimir.AutoSize = true;
            this.checkbox_imprimir.BackColor = System.Drawing.Color.White;
            this.checkbox_imprimir.ForeColor = System.Drawing.Color.Black;
            this.checkbox_imprimir.Location = new System.Drawing.Point(6, 16);
            this.checkbox_imprimir.Name = "checkbox_imprimir";
            this.checkbox_imprimir.Size = new System.Drawing.Size(75, 18);
            this.checkbox_imprimir.TabIndex = 7;
            this.checkbox_imprimir.Text = "Selecionar";
            this.checkbox_imprimir.UseVisualStyleBackColor = false;
            this.checkbox_imprimir.CheckedChanged += new System.EventHandler(this.checkbox_imprimir_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkbox_imprimir);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(649, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(85, 47);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imprimir";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(764, 180);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(790, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbbox_pesquisar);
            this.Controls.Add(this.gbbox_deletar);
            this.Controls.Add(this.gbox_atualizar);
            this.Controls.Add(this.gbox_adicionar);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 65, 20, 22);
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Biblioteca da Paty V1.4.0";
            this.TransparencyKey = System.Drawing.Color.Snow;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.gbox_adicionar.ResumeLayout(false);
            this.gbox_adicionar.PerformLayout();
            this.gbox_atualizar.ResumeLayout(false);
            this.gbox_atualizar.PerformLayout();
            this.gbbox_deletar.ResumeLayout(false);
            this.gbbox_deletar.PerformLayout();
            this.gbbox_pesquisar.ResumeLayout(false);
            this.gbbox_pesquisar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkbox_adicionar;
        private System.Windows.Forms.GroupBox gbox_adicionar;
        private System.Windows.Forms.GroupBox gbox_atualizar;
        private System.Windows.Forms.CheckBox checkbox_atualizar;
        private System.Windows.Forms.GroupBox gbbox_deletar;
        private System.Windows.Forms.CheckBox checkbox_deletar;
        private System.Windows.Forms.GroupBox gbbox_pesquisar;
        private System.Windows.Forms.CheckBox checkbox_pesquisar;
        private System.Windows.Forms.CheckBox checkbox_imprimir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

