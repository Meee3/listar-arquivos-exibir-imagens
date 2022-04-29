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

namespace WFAula22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciando objeto
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            //Alterando a propriedade para exibir o botão nova pasta
            dialog.ShowNewFolderButton = true;


            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
                Environment.SpecialFolder root = dialog.RootFolder;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string pathText = textBox1.Text;
            DirectoryInfo diretorio = new DirectoryInfo($@"{pathText}");
            FileInfo[] arquivos = diretorio.GetFiles("*");
            foreach (FileInfo a in arquivos)
            {
                listBox1.Items.Add(a);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pathText = textBox1.Text;
            pictureBox1.Image = Image.FromFile($@"{pathText}\" + listBox1.Text);
           
        }
    }
}
