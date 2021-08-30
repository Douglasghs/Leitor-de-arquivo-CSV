using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_Read
{
    public partial class Form1 : Form
    {
        ClassService Servico_Classe = new ClassService();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_SelctFile_Click(object sender, EventArgs e)
        {
            textBox1.Text = Servico_Classe.MostrarArquivCSV();
        }
    }
}
