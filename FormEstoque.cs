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
    partial class FormEstoque : Form
    {
        List<Produto> lp = new List<Produto>();
        int id = 0;
        int contCadastros = 0;  //controlar a quantidade de cadastros feitos
        string categoria = "";
        string nome = "";
        double preco = 0.0;
        int quantidade = 0;

        public FormEstoque()
        {
            InitializeComponent();
            if (contCadastros == 0)
            {
                botaoSalvar.Enabled = false;
            }
            else    //so posso salvar após fazer pelo menos um cadastro
            {
                botaoSalvar.Enabled = true;
                botaoSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            }
            botaoProcurar.Enabled = true;
            botaoProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void BotaoCadastrar_Click(object sender, EventArgs e) //botão para cadastrar um produto no estoque
        {
            categoria = (textBox1_categoria.Text);
            nome = textBoxNome.Text;
            preco = Double.Parse(textBoxPreco.Text);
            quantidade = int.Parse(textBoxQuantidade.Text);

            if (quantidade <= 20 && quantidade > 0)
            {
                if (Controle.cont < Controle.vetProduto.Length)
                {
                    id = Controle.cont;
                    Produto p1 = new Produto(categoria, id, nome, Convert.ToDouble(textBoxPreco.Text), Convert.ToInt32(textBoxQuantidade.Text), preco, DateTime.Now);
                    lp.Add(p1);
                    Controle.vetProduto[Controle.cont] = p1;  
                    MessageBox.Show(textBoxQuantidade.Text + " produto(s) de ID( " + Controle.vetProduto[Controle.cont].Identificador + ") cadastrado(s)!", "Cadastro efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    contCadastros++;
                    botaoSalvar.Enabled = true;
                    Controle.cont++;
                }
                else
                {
                    MessageBox.Show("ERRO:Este Produto já existe registrado no estoque.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERRO: Nao é possivel cadastrar mais de 20 produtos no estoque.", "Limite", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }//fim botão cadastrar


        private void BotaoSalvar_Click(object sender, EventArgs e)  //botao para salvar todos cadastros
        {
            StreamWriter sr = new StreamWriter("NovosCadastros.txt");
            string linha = "";
            foreach (Produto p in lp)
            {
                linha = Convert.ToString(p.Identificador) + ';' + p.Nome + ';' + p.Preço + ';' + p.Quantidade + ';' + p.Data;
                sr.WriteLine(linha);
            }
            MessageBox.Show("Os cadastros foram salvos com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sr.Close();
        }

        private void Button1_Click(object sender, EventArgs e)  //lista de Produtos
        {
            FormListaEstoque fle = new FormListaEstoque();
            fle.ShowDialog();
        }

        private void BotaoProcurar_Click(object sender, EventArgs e) //Procurar no estoque
        {
            try
            {
                id = Convert.ToInt32(textBoxID.Text);

                //procurar produto no estoque
                for (int i = 0; i < Controle.vetProduto.Length; i++)
                {
                    if (Controle.Verificar(id))  //existe produtos com esse ID
                    {
                        if (Controle.VerificarQuantidadeProduto(id) > 0) //possui pelo menos 1 produto desse  
                        {
                            //possui
                            FormListaProcura flp = new FormListaProcura(id);
                            flp.ShowDialog();
                            i = Controle.vetProduto.Length; //break
                        }
                        else if (Controle.VerificarQuantidadeProduto(id) == 0)
                        {
                            //zero
                            MessageBox.Show("ERRO: Produto em falta no estoque!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            i = Controle.vetProduto.Length; //break
                        }//end elseif
                    }//end if 
                    else
                    {
                        MessageBox.Show("ERRO: Produto não encontrado!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        i = Controle.vetProduto.Length; //break
                    }
                }//end for
            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message + "\nSomente números no campo ID!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//fim BotaoProcurar_Click

        private void Button2_Click(object sender, EventArgs e) //botão para voltar ao menu
        {
            Form1_Gestor formMenu = new Form1_Gestor();
            this.Hide();
            formMenu.ShowDialog();
        }
    }
}
