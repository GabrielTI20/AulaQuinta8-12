namespace Aula8Dezembro
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
            this.Recebe = new System.Windows.Forms.TextBox();
            this.Mensagem1 = new System.Windows.Forms.Label();
            this.Enviar1 = new System.Windows.Forms.Button();
            this.Mensagem2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Recebe
            // 
            this.Recebe.Location = new System.Drawing.Point(53, 109);
            this.Recebe.Name = "Recebe";
            this.Recebe.Size = new System.Drawing.Size(247, 20);
            this.Recebe.TabIndex = 0;
            this.Recebe.TextChanged += new System.EventHandler(this.Recebe_TextChanged);
            // 
            // Mensagem1
            // 
            this.Mensagem1.AutoSize = true;
            this.Mensagem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Mensagem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensagem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mensagem1.Location = new System.Drawing.Point(48, 59);
            this.Mensagem1.Name = "Mensagem1";
            this.Mensagem1.Size = new System.Drawing.Size(196, 25);
            this.Mensagem1.TabIndex = 1;
            this.Mensagem1.Text = "Digite seu nome :";
            // 
            // Enviar1
            // 
            this.Enviar1.BackColor = System.Drawing.Color.White;
            this.Enviar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enviar1.Location = new System.Drawing.Point(53, 144);
            this.Enviar1.Name = "Enviar1";
            this.Enviar1.Size = new System.Drawing.Size(187, 63);
            this.Enviar1.TabIndex = 2;
            this.Enviar1.Text = "Enviar\r\n";
            this.Enviar1.UseVisualStyleBackColor = false;
            this.Enviar1.Click += new System.EventHandler(this.Enviar1_Click);
            // 
            // Mensagem2
            // 
            this.Mensagem2.AutoSize = true;
            this.Mensagem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensagem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mensagem2.Location = new System.Drawing.Point(246, 182);
            this.Mensagem2.Name = "Mensagem2";
            this.Mensagem2.Size = new System.Drawing.Size(72, 25);
            this.Mensagem2.TabIndex = 3;
            this.Mensagem2.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mensagem2);
            this.Controls.Add(this.Enviar1);
            this.Controls.Add(this.Mensagem1);
            this.Controls.Add(this.Recebe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Recebe;
        private System.Windows.Forms.Label Mensagem1;
        private System.Windows.Forms.Button Enviar1;
        private System.Windows.Forms.Label Mensagem2;
    }
}

