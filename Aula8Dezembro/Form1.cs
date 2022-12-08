using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula8Dezembro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Mensagem2.Visible = false;
        }


        private void Recebe_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enviar1_Click(object sender, EventArgs e)
        {
            Mensagem2.Visible=true;
            Mensagem2.Text = "Olá " + Recebe.Text + ". Seja bem vindo!!";
            Recebe.Visible=false;   
            Enviar1.Visible=false;
            Mensagem1.Visible=false;

        }
    }
}
