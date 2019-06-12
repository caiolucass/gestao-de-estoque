using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaodeVendas
{
    partial class Form1_Gestor : Form
    { 
        public Form1_Gestor( )
        {
            InitializeComponent();
        }

        private void button3_Compra_Click(object sender, EventArgs e)
        {
            //acessar o forms de venda para acessar as opçoes disponiveis
            FormVendas f1 = new FormVendas();
            this.Hide();
            f1.ShowDialog();
        }

        private void Button1_Estoque_Click(object sender, EventArgs e)
        {
            //acessar o vetProdutos para pegar todos os produtos e listar no forms
            FormEstoque e1 = new FormEstoque();
            this.Hide();
            e1.ShowDialog();
        }

        private void button2_ReporEstoque_Click(object sender, EventArgs e)
        {
           //metodo nulo e/ou vazio
        }

        private void Form1_Gestor_Load(object sender, EventArgs e)
        {
            //metodo nulo e/ou vazio
        }

        private void Button2_Click(object sender, EventArgs e) //botão para log out
        {
            this.Hide();
            FormLogin fl = new FormLogin();
            fl.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) //botão para gerar um relatório de todas as operaçoes do sistema
        {
            FormRelatorio r1 = new FormRelatorio();
            this.Hide();
            r1.ShowDialog();
        }
    }
}
