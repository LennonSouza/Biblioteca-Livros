namespace Biblioteca_da_Patricia.Opcoes
{
    partial class Deletar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deletar));
            this.gbDeletar = new System.Windows.Forms.GroupBox();
            this.lblId_Deletar = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtId_Deletar = new System.Windows.Forms.TextBox();
            this.gbDeletar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDeletar
            // 
            this.gbDeletar.Controls.Add(this.lblId_Deletar);
            this.gbDeletar.Controls.Add(this.btnDeletar);
            this.gbDeletar.Controls.Add(this.txtId_Deletar);
            this.gbDeletar.Location = new System.Drawing.Point(12, 27);
            this.gbDeletar.Name = "gbDeletar";
            this.gbDeletar.Size = new System.Drawing.Size(147, 54);
            this.gbDeletar.TabIndex = 14;
            this.gbDeletar.TabStop = false;
            this.gbDeletar.Text = "Deletar Livros";
            // 
            // lblId_Deletar
            // 
            this.lblId_Deletar.AutoSize = true;
            this.lblId_Deletar.Location = new System.Drawing.Point(6, 23);
            this.lblId_Deletar.Name = "lblId_Deletar";
            this.lblId_Deletar.Size = new System.Drawing.Size(23, 14);
            this.lblId_Deletar.TabIndex = 12;
            this.lblId_Deletar.Text = "ID:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(87, 17);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(50, 25);
            this.btnDeletar.TabIndex = 10;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txtId_Deletar
            // 
            this.txtId_Deletar.Location = new System.Drawing.Point(33, 19);
            this.txtId_Deletar.Name = "txtId_Deletar";
            this.txtId_Deletar.Size = new System.Drawing.Size(48, 20);
            this.txtId_Deletar.TabIndex = 11;
            // 
            // Deletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 89);
            this.Controls.Add(this.gbDeletar);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Deletar";
            this.Padding = new System.Windows.Forms.Padding(20, 65, 20, 22);
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Deletar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Deletar_FormClosing);
            this.gbDeletar.ResumeLayout(false);
            this.gbDeletar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDeletar;
        private System.Windows.Forms.Label lblId_Deletar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox txtId_Deletar;
    }
}