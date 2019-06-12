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

namespace GestaodeVendas
{
    public partial class FormListaEstoque : Form
    {
        static int cont;

        List<Produto> listaTodosProds = new List<Produto>();
        public FormListaEstoque()
        {
            InitializeComponent();
        }

        private void FormListaEstoque_Load(object sender, EventArgs e)
        {
            try
            {
                int id;
                string categoria = "";
                int quant = 0;
                string nome = "";
                double preco = 0.0;
                DateTime data;

                fillList(); //produtos antigos + novos produtos
                File.Delete("NovosCadastros.txt");

                for (int i = 0; i < Controle.vetProduto.Length; i++)
                {
                    if (Controle.vetProduto[i].Categoria != null)
                    {
                        ListViewItem lv = new ListViewItem(Controle.vetProduto[i].Nome);

                        id = Controle.vetProduto[i].Identificador;
                        data = (Controle.vetProduto[i].Data);
                        nome = Controle.vetProduto[i].Nome;
                        quant = Controle.vetProduto[i].Quantidade;
                        preco = Controle.vetProduto[i].Preço;
                        categoria = Controle.vetProduto[i].Categoria;

                        lv.SubItems.Add(id.ToString());
                        lv.SubItems.Add(categoria);
                        lv.SubItems.Add(Convert.ToString(quant));
                        lv.SubItems.Add(Convert.ToString(data));
                        lv.SubItems.Add(Convert.ToString(preco));
                        lv_produtos.Items.Add(lv);
                    }//fim if
                }//fim for
            }//fim try
            catch (Exception )
            {
            }
            finally
            {
                cont = 1;
            }
        }//fim lista estoque
                   
        public void fillList()
        {
            int id;
            string categoria = "";
            int quant = 0;
            string nome = "";
            double preco = 0.0;

            try
            {
                for (int i = 0; i < Controle.vetProduto.Length; i++)
                {
                    listaTodosProds.Add(Controle.vetProduto[i]);
                }
            }catch(Exception  ) {  }

            try { 
                StreamReader sr = new StreamReader("NovosCadastrados.txt");
                string linha = "";
                linha = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    if (linha != null)
                    {
                        string [] tmp = linha.Split(';');
                        categoria = (tmp[0]);
                        id = int.Parse(tmp[1]);
                        nome = tmp[2];
                        preco = double.Parse(tmp[3]);

                        if (categoria == "Bebida")
                        {

                            id = cont ;
                            quant = Controle.VerificarQuantidadeProduto(id);
                        }
                        else if (categoria == "Comida")
                        {
                            id = cont;
                            quant = Controle.VerificarQuantidadeProduto(id);
                        }
                        else if (categoria == "Limpeza")
                        {
                            id = cont;
                            quant = Controle.VerificarQuantidadeProduto(id);
                        }

                        Produto p = new Produto(categoria,id,nome, preco, quant, preco, Convert.ToDateTime(tmp[4]));
                        listaTodosProds.Add(p);
                        linha = sr.ReadLine();
                    }
                }
                sr.Close();
            }
            catch (Exception ){ }
        }

        private void Button1_Click(object sender, EventArgs e)  //botão voltar
        {
            this.Hide();
            FormEstoque fe = new FormEstoque();
            fe.ShowDialog();
        }

    }
}
