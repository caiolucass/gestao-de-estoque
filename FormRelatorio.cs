using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GestaodeVendas
{
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
            RelatorioCadastro();
            RelatorioVendas();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //metodo nulo e/ou vazio
        }

        private void RelatorioCadastro() // listar os cadastros feitos
        {
            try
            {
                StreamReader r2 = new StreamReader("NovosCadastros.txt");
                string linha;

                while (!r2.EndOfStream)
                {
                    linha = r2.ReadLine();
                    listBox1_cadastros.Items.Add(linha);
                }
                r2.Close();
            }
            catch( FileNotFoundException fnf )
            {
                MessageBox.Show(fnf.Message + "\nO Relatório não pode ser gerado \"em branco\".", "Relatorio invalido.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//fim listar relatório

        private void button1_Click(object sender, EventArgs e) //botão de voltar
        {
            Form1_Gestor formMenu = new Form1_Gestor();
            this.Hide();
            formMenu.ShowDialog();
        }

        private void listBox1_vendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //metudo nulo e/ou vazio
        }

        public void RelatorioVendas() //listar as vendas feitas
        {
            try
            {
                StreamReader r1 = new StreamReader("Vendasfeitas.txt");
                string linha;

                while (!r1.EndOfStream)
                {
                    linha = r1.ReadLine();
                    listBox1_vendas.Items.Add(linha);
                }
                r1.Close();
            }
            catch (FileNotFoundException fnf)
            {
                MessageBox.Show(fnf.Message + "\nO Relatorio não pode ser gerado \"em branco\".", "Relatorio invalido.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//fim relatorio vendas
    }

}
