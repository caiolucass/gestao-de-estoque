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
    public partial class FormListaProcura : Form
    {
        int id;
        string nome;
        int quant;
        public FormListaProcura(int id)
        {
            InitializeComponent();
            this.id = id;
            this.nome = Controle.vetProduto[id -1].Nome;
            this.quant = Controle.vetProduto[id - 1].Quantidade;
        }

        private void FormListaProcura_Load(object sender, EventArgs e)
        {
            try
            {
                double preco = 0.0;
                int pos = Controle.PosicaoItem;
                string categoria = Controle.vetProduto[pos].Categoria;
                id = Controle.vetProduto[pos].Identificador;
                DateTime data;

                ListViewItem lv = new ListViewItem(nome);
              
                data = Controle.vetProduto[pos].Data;
                preco = Controle.vetProduto[pos].Preço;
                lv.SubItems.Add(id.ToString());
                lv.SubItems.Add(categoria);
                lv.SubItems.Add(Convert.ToString(quant));
                lv.SubItems.Add(Convert.ToString(data));
                lv.SubItems.Add(Convert.ToString(preco));
                lv_produtos.Items.Add(lv);             
            }
            catch (Exception)
            {

            }       
        }
        private void Button1_Click(object sender, EventArgs e) //botão de voltar
        {
            this.Hide();
            FormEstoque fe = new FormEstoque();
            fe.ShowDialog();
        }
    }
}
