namespace Aula8Dezembro
{
    partial class Form2
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
            this.CaixaTexto = new System.Windows.Forms.TextBox();
            this.Tela = new System.Windows.Forms.TextBox();
            this.BotaoLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CaixaTexto
            // 
            this.CaixaTexto.Location = new System.Drawing.Point(37, 12);
            this.CaixaTexto.Name = "CaixaTexto";
            this.CaixaTexto.Size = new System.Drawing.Size(206, 20);
            this.CaixaTexto.TabIndex = 0;
            this.CaixaTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // Tela
            // 
            this.Tela.Location = new System.Drawing.Point(37, 79);
            this.Tela.Multiline = true;
            this.Tela.Name = "Tela";
            this.Tela.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Tela.Size = new System.Drawing.Size(525, 300);
            this.Tela.TabIndex = 1;
            // 
            // BotaoLimpar
            // 
            this.BotaoLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotaoLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoLimpar.Location = new System.Drawing.Point(590, 38);
            this.BotaoLimpar.Name = "BotaoLimpar";
            this.BotaoLimpar.Size = new System.Drawing.Size(121, 45);
            this.BotaoLimpar.TabIndex = 2;
            this.BotaoLimpar.Text = "Limpar";
            this.BotaoLimpar.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotaoLimpar);
            this.Controls.Add(this.Tela);
            this.Controls.Add(this.CaixaTexto);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CaixaTexto;
        private System.Windows.Forms.TextBox Tela;
        private System.Windows.Forms.Button BotaoLimpar;
    }
}