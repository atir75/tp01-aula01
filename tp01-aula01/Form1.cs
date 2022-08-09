using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp01_aula01
{
    public partial class Form1 : Form
    {

        Dado dado = new Dado();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dado.setCodigo(textBox1.Text);
            dado.setDado1(textBox2.Text);
            dado.setDado2(textBox3.Text);
            dado.setDado3(textBox4.Text);
            dado.setDado4(textBox5.Text);

            DadoBLL.validaDados(dado, 'i');

            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
                MessageBox.Show("Dados inseridos com sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dado.setCodigo(textBox1.Text);

            DadoBLL.validaDados(dado, 'c');

            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
            {
                textBox1.Text = dado.getCodigo();
                textBox2.Text = dado.getDado1();
                textBox3.Text = dado.getDado2();
                textBox4.Text = dado.getDado3();
                textBox5.Text = dado.getDado4();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dado.setCodigo(textBox1.Text);
            dado.setDado1(textBox2.Text);
            dado.setDado2(textBox3.Text);
            dado.setDado3(textBox4.Text);
            dado.setDado4(textBox5.Text);

            DadoBLL.validaDados(dado, 'a');

            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
                MessageBox.Show("Dados alterados com sucesso!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dado.setCodigo(textBox1.Text);

            DadoBLL.validaDados(dado, 'e');

            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
                MessageBox.Show("Dado Excluído!");
        }
    }
}
