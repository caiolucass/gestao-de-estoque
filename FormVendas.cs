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
    partial class FormVendas : Form
    {

        double preçofinal; //preço da venda de um produto
        double preçoGeral; //preço da venda de todos os produtos
        int id;
        string nome;
        int cont = 0;   //contador de quantidade de vendas
        int vendas = 0;
        StringBuilder auxstring;

        public FormVendas()
        {
            InitializeComponent();

            if (vendas == 0)
            {
                button1_vender.Enabled = false;
                button1_finalizar.Enabled = false;
            }
            else    //salva após fazer ao menos uma venda
            {
                button1_vender.Enabled = true;
                button1_vender.Cursor = System.Windows.Forms.Cursors.Hand;
            }
        }

        public bool liberarVendas() //botão de finalizar venda,disponivel somente se entrar nessas condições
        {
            return (textBox1_id.TextLength != 0 && textBox2_nome.TextLength != 0 && textBox3_quantidade.TextLength != 0);
        }

        private void button1_Click(object sender, EventArgs e) //botão para fazer a venda dos produtos
        {
            auxstring = new StringBuilder();
            nome = (textBox2_nome.Text);
            int i = Controle.AcharProduto(id);

            if (i != -1)
            {
                string linha = Convert.ToString(id) + ";" + nome + ";" + textBox5_preçofinal.Text + ";" + DateTime.Now;
                MessageBox.Show("Itens vendidos com sucesso.\nClique em \"Finalizar Vendas\" para concluir, ou continue comprando.", "Vendido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vendas++;
                Controle.vetProduto[i].Quantidade -= Convert.ToInt32(textBox3_quantidade.Text);
                preçoGeral += preçofinal; //salvar o preço final
                
                if (Controle.VerificarQuantidadeProduto(id) <= 5)
                {
                    Controle.Repor(id, 15);
                    MessageBox.Show("Produto " + " " + Controle.vetProduto[i].Nome + " " +
                   "reposto no estoque." + "\nQuantidade reposta:" + Controle.vetProduto[i].Quantidade, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                auxstring.AppendLine("\nID:" + id + "\nNome:" + nome + "\nPreço:" + Convert.ToDouble(textBox4_preçouni.Text) * cont + "\nData:" + DateTime.Now);
                textBox3_quantidade.Text = "1";
                textBox1_id.Clear(); textBox2_nome.Clear(); textBox3_quantidade.Clear(); textBox4_preçouni.Clear(); textBox5_preçofinal.Clear();
            }
            if (vendas > 0)
            {
                button1_finalizar.Enabled = true;
            }
        }//fim botao de venda
            

        private void button1_finalizar_Click(object sender, EventArgs e) //botão para confirmar e salvar e gerar um arquivo de vendas feitas
        { 
            StreamReader sn = new StreamReader("VendasFeitas.txt");
            StringBuilder auxstringleitura = new StringBuilder();
            string linha;

            while (!sn.EndOfStream)
            {
                linha = sn.ReadLine();
                auxstringleitura.AppendLine(linha);
            }
            sn.Close();
            StreamWriter sr = new StreamWriter("VendasFeitas.txt");

            auxstring.AppendLine("Preço Final:" + preçofinal);

            sr.Write(auxstringleitura);
            sr.WriteLine(auxstring);

            sr.Close();
           
            MessageBox.Show("Suas vendas foram salvas com sucesso!", "Salvando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button1_finalizar.Enabled = true;

        }//fim botão finalizar

        private void button3_mais_Click(object sender, EventArgs e) //botão para aumentar a quantidade de produto
        {

            if (cont >= 0 && cont <= Controle.vetProduto[id].Quantidade - 1)
            {
                cont++;
                textBox3_quantidade.Text = Convert.ToString(cont);
                preçofinal = Convert.ToDouble(textBox4_preçouni.Text) * cont;
                textBox5_preçofinal.Text = Convert.ToString(preçofinal);
            }
        }//fim botão mais

        private void button2_menos_Click(object sender, EventArgs e) //botão para diminuir a quantidade de produto
        {
            if (cont > 0)
            {
                cont--;
                textBox3_quantidade.Text = Convert.ToString(cont);
                preçofinal = Convert.ToDouble(textBox4_preçouni.Text) * cont;
                textBox5_preçofinal.Text = Convert.ToString(preçofinal);
            }
        }//fim botão menos

        private void FormVendas_Load(object sender, EventArgs e)
        {
            //metodo nulo e/ou vazio
        }

        private void Button1_Click_1(object sender, EventArgs e) //botão para voltar ao menu principal
        {
            Form1_Gestor formMenu = new Form1_Gestor();
            this.Hide();
            formMenu.ShowDialog();
        }//fim voltar ao menu

        private void button2_Click(object sender, EventArgs e) //botão para listar as vendas feitas
        {
            this.Hide();
            FormListaVendas vendas = new FormListaVendas();
            vendas.ShowDialog();
        }//fim listar vendas

        private void button3_Click(object sender, EventArgs e) //botão de procurar produto no estoque
        {
            try
            {
                id = Convert.ToInt32(textBox1_id.Text);

                //procurar produto no estoque
                for (int i = 0; i < Controle.vetProduto.Length; i++)
                {
                    if (Controle.Verificar(id))  //existe produtos com esse ID
                    {
                        if (Controle.VerificarQuantidadeProduto(id) > 0) //possui pelo menos 1 produto desse  
                        {
                            //possui
                            FormListaProcura flp = new FormListaProcura(id);
                            flp.Show();
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
                MessageBox.Show(exc.Message + "\nSomente números no campo ID!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//fim procurar no estoque

        private void button4_estoque_Click(object sender, EventArgs e) //botão para listar os produtos no estoque
        {
            FormListaEstoque fle = new FormListaEstoque();
            fle.ShowDialog();
        }//fim forms estoque

        private void textBox1_id_TextChanged(object sender, EventArgs e)
        {
            //metodo nulo e/ou vazio.
        }

        private void textBox2_nome_TextChanged(object sender, EventArgs e) //textbox do nome 
        {
            //metodo nulo e/ou vazio.
        }

        private void button4_procurar_Click(object sender, EventArgs e) //verificar se o produto está disponivel
        {
            try
            {
                id = Convert.ToInt32(textBox1_id.Text);
                button1_vender.Enabled = true;

                for (int i = 0; i < Controle.vetProduto.Length; i++)//achar a posição no vetor
                {
                    if (Controle.Verificar(id)) //verificar o id
                    {
                        if (Controle.vetProduto[i].Identificador == id) //verificar se o id achado é igual ao requerido
                        {
                            textBox2_nome.Text = Controle.vetProduto[i].Nome;
                            textBox4_preçouni.Text = string.Format("{0:N}",(Controle.vetProduto[i].ValorFinal()));
                            textBox3_quantidade.Text = Convert.ToString(cont);
                        }
                    }
                    else
                    {
                        MessageBox.Show("O ID procurado não encontra-se cadastrado no estoque.", "ID Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        i = Controle.vetProduto.Length;
                        textBox1_id.Text = "";
                    }
                }
            }
            catch(FormatException fe)
            {
                MessageBox.Show("ERRO! Formato incorreto na entrada de dados!!","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }//fim botão procurar
    }//fim forms venda
}//fim gestãovendas




