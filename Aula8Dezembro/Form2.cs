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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            Tela.AppendText("\r\n" + "Pressionei a tecla : " + e.KeyCode);
            Tela.AppendText("\r\n" + "\t"+"Código da tecla: "+((int)e.KeyCode));
        }
    }
}
