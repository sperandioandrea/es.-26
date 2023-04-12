using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;///

namespace es._26
{
    public partial class Form1 : Form
    {
        string cancellazionelogica;///
        public Form1()
        {
            InitializeComponent();
            cancellazionelogica = @"cancellazionelogica.txt"; ///
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //funzione che crea il file
        public void CreazioneFile(string nprodotti, string prezzo)
        {
            if (!File.Exists(cancellazionelogica))
            {
                using (StreamWriter sw = new StreamWriter(cancellazionelogica, append: false))
                {
                    sw.WriteLine(nprodotti + " " + prezzo + " ");
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(cancellazionelogica, append: true))
                {
                    sw.WriteLine(nprodotti + " " + prezzo + " ");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreazioneFile(textBox1.Text, textBox2.Text);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //cancellazione
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
