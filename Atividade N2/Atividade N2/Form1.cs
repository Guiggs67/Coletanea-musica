using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_N2
{
    public partial class Form1 : Form
    {
        string[] musica = new string[100];
        string[] artista = new string[100];
        string[] album = new string[100];
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < musica.Length; i++)
            musica[i] = (string)this.textBox1.Text;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < musica.Length; i++)
            artista[i] = (string)this.textBox1.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < musica.Length; i++)
            album[i] = (string)this.textBox1.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < musica.Length; i++)
            {
                Armazenar P = new Armazenar(musica[i], artista[i], album[i]);
                
            }
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < musica.Length; i++)
            {
                Armazenar P = new Armazenar(musica[i], artista[i], album[i]);
                textBox4.Text = P.Conjunto();
            }
        }

        
    }
}
