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
    public partial class FormListaVendas : Form
    {
        List<Produto> listaTodosProds = new List<Produto>();
        public FormListaVendas()
        {
            InitializeComponent();
            listarVendas();
        }
       
        private void button1_Click(object sender, EventArgs e) //botão para voltar a pagina anterior
        {
            this.Hide();
            FormVendas fe = new FormVendas();
            fe.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //metodo nulo e/ou vazio
        }

        private void listarVendas() //lista para listar as vendas feitas
        {
            StreamReader r1 = new StreamReader("Vendasfeitas.txt");
            string linha;
           
            while(!r1.EndOfStream)
            {
                linha = r1.ReadLine();
                listBox1_vendas.Items.Add(linha);
            }
            r1.Close();       
        }//fim listar venda
    }
}
