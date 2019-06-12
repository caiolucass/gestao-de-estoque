using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace GestaodeVendas
{
    class Controle
    {
        static public int cont = 0;
        static public Produto[] vetProduto = new Produto[100];
        const string Nomearq = "Produtos.txt";
        static private int posicaoItem = 0;

        public void ClienteCompra(int id,int quant)  //metodo para o cliente comprar da loja
        {
            int pos;
            pos = AcharProduto(id);
            if (VerificarQuantidadeProduto(id) >= quant)    //testar se possuo a quantidade desejada
            {
                vetProduto[pos].Quantidade = quant;
            }
        }

        public static void Repor(int id, int quant) //metodo para repor o estoque
        {
            int pos;
            pos = AcharProduto(id);

            if (pos == -1)
            {
                MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else vetProduto[pos].Quantidade += quant;
        }

        public static int AcharProduto(int id) //metodo para achar a posição do produto
        {
            int pos;

            for (int i = 0; i < vetProduto.Length; i++)
            {
                if (( vetProduto[i].Identificador == id )) 
                {
                    pos = i;
                    i = vetProduto.Length;  //break
                    return pos;
                }
            }
            return -1;
        }

        public static bool Verificar(int id)  //verificar existencia desse tipo de prod. no estoque
        {
            bool r = false;
            try
            {
                for (int i = 0; i < vetProduto.Length; i++)
                {
                    if (id == vetProduto[i].Identificador)
                    {
                        r = true;
                        PosicaoItem = i;        //posicao do item desse id
                        i = vetProduto.Length;  //break
                    }
                    else
                    {
                        r = false;
                    }
                }
            }
            catch (NullReferenceException ){ }

            return r;
        }

        public static int PosicaoItem //obter a posição do produto
        {
            get { return posicaoItem; }
            set { if ( value > 0)
                {
                    posicaoItem = value;
                } }
        }


        public static int VerificarQuantidadeProduto(int id) //metodo para verificar a quantidade de produto
        {
            int q = 0;
            if (Verificar(id))
            {
                int pos = posicaoItem;
                q = vetProduto[pos].Quantidade;
            }
            return q;
        }

        public static void LerArquivo() //método para ler o arquivo 
        {
            string linha;
            string [] auxSeparador;
            int id;
            string nome;
            double preço;
            string categoria;
            int quant;
            double lucro;

            for(int i = 0; i< vetProduto.Length; i++)
            {
                vetProduto[i] = new Produto();
            }
            if (File.Exists(Nomearq))
            {
                StreamReader Lerarq = new StreamReader(Nomearq);
                linha = Lerarq.ReadLine();

                while (linha != null)
                {
                    auxSeparador = linha.Split(';');
                    categoria = (auxSeparador[0]);
                    id = Convert.ToInt32(auxSeparador[1]);
                    nome = (auxSeparador[2]);
                    preço = Convert.ToDouble(auxSeparador[3]);
                    quant = Convert.ToInt32(auxSeparador[4]);
                    lucro = Convert.ToDouble(auxSeparador[5]);

                    if (auxSeparador[0] == "Bebida")
                    {
                        Bebida aux = new Bebida(categoria, id, DateTime.Now, nome, preço, quant,lucro);
                        vetProduto[cont] = aux;
                        cont++;
                    }
                    else if (auxSeparador[0] == "Comida")
                    {
                        Comida aux = new Comida(categoria, id, DateTime.Now, nome, preço, quant,lucro);
                        vetProduto[cont] = aux;
                        cont++;
                    }
                    else if (auxSeparador[0] == "Limpeza")
                    {
                        Limpeza aux = new Limpeza(categoria, id, DateTime.Now, nome, preço, quant,lucro);
                        vetProduto[cont] = aux;
                        cont++;
                    }
                    linha = Lerarq.ReadLine();
                }//fim while
                Lerarq.Close();
            }//fim if     
        }
    }
}
