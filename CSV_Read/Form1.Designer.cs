
namespace CSV_Read
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_SelctFile = new System.Windows.Forms.Button();
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(857, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button_SelctFile
            // 
            this.button_SelctFile.Location = new System.Drawing.Point(13, 14);
            this.button_SelctFile.Name = "button_SelctFile";
            this.button_SelctFile.Size = new System.Drawing.Size(139, 23);
            this.button_SelctFile.TabIndex = 2;
            this.button_SelctFile.Text = "Selecionar Arquivo ";
            this.button_SelctFile.UseVisualStyleBackColor = true;
            this.button_SelctFile.Click += new System.EventHandler(this.button_SelctFile_Click);
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Location = new System.Drawing.Point(1029, 15);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(131, 23);
            this.button_OpenFile.TabIndex = 3;
            this.button_OpenFile.Text = "Abrir Arquivo";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.button_OpenFile);
            this.Controls.Add(this.button_SelctFile);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_SelctFile;
        private System.Windows.Forms.Button button_OpenFile;
    }
}

