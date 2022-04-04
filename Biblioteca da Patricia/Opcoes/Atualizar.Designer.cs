namespace Biblioteca_da_Patricia.Opcoes
{
    partial class Atualizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Atualizar));
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.txtpratileira = new System.Windows.Forms.TextBox();
            this.lblpratileira = new System.Windows.Forms.Label();
            this.cblido = new System.Windows.Forms.CheckBox();
            this.lbllido = new System.Windows.Forms.Label();
            this.cbsubgenero = new System.Windows.Forms.ComboBox();
            this.cbgenero = new System.Windows.Forms.ComboBox();
            this.lblsubgenero = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtId_Add = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblautor = new System.Windows.Forms.Label();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.lblano = new System.Windows.Forms.Label();
            this.txtano = new System.Windows.Forms.TextBox();
            this.lblgenero = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.txtpratileira);
            this.gbAdd.Controls.Add(this.lblpratileira);
            this.gbAdd.Controls.Add(this.cblido);
            this.gbAdd.Controls.Add(this.lbllido);
            this.gbAdd.Controls.Add(this.cbsubgenero);
            this.gbAdd.Controls.Add(this.cbgenero);
            this.gbAdd.Controls.Add(this.lblsubgenero);
            this.gbAdd.Controls.Add(this.btnAtualizar);
            this.gbAdd.Controls.Add(this.txtId_Add);
            this.gbAdd.Controls.Add(this.lblid);
            this.gbAdd.Controls.Add(this.lblautor);
            this.gbAdd.Controls.Add(this.txtautor);
            this.gbAdd.Controls.Add(this.lblano);
            this.gbAdd.Controls.Add(this.txtano);
            this.gbAdd.Controls.Add(this.lblgenero);
            this.gbAdd.Controls.Add(this.lblnome);
            this.gbAdd.Controls.Add(this.txtnome);
            this.gbAdd.Location = new System.Drawing.Point(12, 13);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(637, 99);
            this.gbAdd.TabIndex = 3;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Atualizar Livros";
            // 
            // txtpratileira
            // 
            this.txtpratileira.Location = new System.Drawing.Point(244, 70);
            this.txtpratileira.Name = "txtpratileira";
            this.txtpratileira.Size = new System.Drawing.Size(63, 20);
            this.txtpratileira.TabIndex = 4;
            // 
            // lblpratileira
            // 
            this.lblpratileira.AutoSize = true;
            this.lblpratileira.Location = new System.Drawing.Point(188, 74);
            this.lblpratileira.Name = "lblpratileira";
            this.lblpratileira.Size = new System.Drawing.Size(55, 14);
            this.lblpratileira.TabIndex = 21;
            this.lblpratileira.Text = "Pratileira:";
            // 
            // cblido
            // 
            this.cblido.AutoSize = true;
            this.cblido.Location = new System.Drawing.Point(610, 39);
            this.cblido.Name = "cblido";
            this.cblido.Size = new System.Drawing.Size(15, 14);
            this.cblido.TabIndex = 7;
            this.cblido.UseVisualStyleBackColor = true;
            // 
            // lbllido
            // 
            this.lbllido.AutoSize = true;
            this.lbllido.Location = new System.Drawing.Point(547, 39);
            this.lbllido.Name = "lbllido";
            this.lbllido.Size = new System.Drawing.Size(52, 14);
            this.lbllido.TabIndex = 19;
            this.lbllido.Text = "Você Leu:";
            // 
            // cbsubgenero
            // 
            this.cbsubgenero.FormattingEnabled = true;
            this.cbsubgenero.Location = new System.Drawing.Point(391, 71);
            this.cbsubgenero.Name = "cbsubgenero";
            this.cbsubgenero.Size = new System.Drawing.Size(150, 22);
            this.cbsubgenero.TabIndex = 6;
            this.cbsubgenero.Visible = false;
            // 
            // cbgenero
            // 
            this.cbgenero.FormattingEnabled = true;
            this.cbgenero.Location = new System.Drawing.Point(391, 42);
            this.cbgenero.Name = "cbgenero";
            this.cbgenero.Size = new System.Drawing.Size(150, 22);
            this.cbgenero.TabIndex = 5;
            this.cbgenero.SelectedIndexChanged += new System.EventHandler(this.cbgenero_SelectedIndexChanged);
            // 
            // lblsubgenero
            // 
            this.lblsubgenero.AutoSize = true;
            this.lblsubgenero.Location = new System.Drawing.Point(320, 74);
            this.lblsubgenero.Name = "lblsubgenero";
            this.lblsubgenero.Size = new System.Drawing.Size(67, 14);
            this.lblsubgenero.TabIndex = 16;
            this.lblsubgenero.Text = "Sub-Gênero:";
            this.lblsubgenero.Visible = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(547, 56);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(79, 38);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtId_Add
            // 
            this.txtId_Add.Location = new System.Drawing.Point(49, 16);
            this.txtId_Add.Name = "txtId_Add";
            this.txtId_Add.Size = new System.Drawing.Size(42, 20);
            this.txtId_Add.TabIndex = 0;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(6, 19);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(23, 14);
            this.lblid.TabIndex = 9;
            this.lblid.Text = "ID:";
            // 
            // lblautor
            // 
            this.lblautor.AutoSize = true;
            this.lblautor.Location = new System.Drawing.Point(6, 73);
            this.lblautor.Name = "lblautor";
            this.lblautor.Size = new System.Drawing.Size(37, 14);
            this.lblautor.TabIndex = 3;
            this.lblautor.Text = "Autor:";
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(49, 70);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(124, 20);
            this.txtautor.TabIndex = 2;
            // 
            // lblano
            // 
            this.lblano.AutoSize = true;
            this.lblano.Location = new System.Drawing.Point(188, 45);
            this.lblano.Name = "lblano";
            this.lblano.Size = new System.Drawing.Size(30, 14);
            this.lblano.TabIndex = 8;
            this.lblano.Text = "Ano:";
            // 
            // txtano
            // 
            this.txtano.Location = new System.Drawing.Point(244, 42);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(63, 20);
            this.txtano.TabIndex = 3;
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Location = new System.Drawing.Point(320, 46);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(45, 14);
            this.lblgenero.TabIndex = 5;
            this.lblgenero.Text = "Gênero:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(6, 45);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 14);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(49, 42);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(124, 20);
            this.txtnome.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(783, 180);
            this.dataGridView1.TabIndex = 23;
            // 
            // Atualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 309);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbAdd);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Atualizar";
            this.Padding = new System.Windows.Forms.Padding(20, 65, 20, 22);
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Atualizar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Atualizar_FormClosing);
            this.Load += new System.EventHandler(this.Atualizar_Load);
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtId_Add;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblautor;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.Label lblano;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblsubgenero;
        private System.Windows.Forms.ComboBox cbgenero;
        private System.Windows.Forms.ComboBox cbsubgenero;
        private System.Windows.Forms.CheckBox cblido;
        private System.Windows.Forms.Label lbllido;
        private System.Windows.Forms.TextBox txtpratileira;
        private System.Windows.Forms.Label lblpratileira;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}