using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios.Capitulo_9;
using Ejercicios.Capitulo_10;

namespace Ejercicios
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Capitulo9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capitulo9 capitulo9 = new Capitulo9
            {
                MdiParent = this
            };
            capitulo9.Show();
        }

        private void Capitulo10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capitulo10 capitulo = new Capitulo10
            {
                MdiParent = this
            };
            capitulo.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
