using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ficheiros
{
    public partial class Form1 : Form
    {
        String pasta_Config = "C:\\Users\\HENRIQUE\\Desktop\\csharp\\teste\\";
 
        public Form1()
        {
            InitializeComponent();
        }

     
        private void btngravar_Click(object sender, EventArgs e)
        {
            string[] lista_ficheiro = Directory.GetFiles("C:\\Users\\HENRIQUE\\Desktop\\","*.txt");
           // File.Move("C:\\Users\\HENRIQUE\\Desktop\\file.txt", "C:\\Users\\HENRIQUE\\Desktop\\UseKbsa\\file.txt");

            foreach (string ficheiros in lista_ficheiro)
            {
                listBox1.Items.Add(Path.GetFileName(ficheiros));
            }
        }
    }
}
