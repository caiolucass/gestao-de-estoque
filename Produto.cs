using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaodeVendas
{
    class Produto
    {
        protected string nome;
        protected DateTime data;
        protected int id;
        protected double preço;
        int quant = 0;//quantidade de cada tipo de produto cadastrado no estoque
        protected double imposto;
        protected double lucro;
        protected string categoria;

        public Produto(string categoria,int id,string nome, double preço, int quant,double lucro,DateTime data) //construtor com valores
        {
            this.nome = nome;
            this.data = data;
            this.id = id;
            this.preço = preço;
            this.quant = quant;
            this.lucro = lucro;
            this.categoria = categoria;
        }

        public Produto() //construtor sem valores
        {
            nome = null;
            DateTime data = DateTime.MinValue;
            id = 0;
            preço = 0.0;
            quant = 0;
            lucro = 0;
            categoria = null;
        }

        public string Nome { get { return nome; } set { nome = value; } } 
        public DateTime Data { get { return data; } set { data = value; } }
        public int Identificador { get { return id; } set { id = value; } } 
        public double Preço { get { return preço; } set { preço = value; } } 
        public double Imposto { get { return preço; } set { imposto = value; } }
        public int Quantidade { get { return quant; } set { quant = value; } }
        public double Lucro { get { return lucro; }set { lucro = value; } }
        public string Categoria { get { return categoria; } set { categoria = value; } }

        public double ValorLucro()  //metodo para calcular o valor do lucro sobre a venda
        {
            return preço * lucro;
        }

        public double ValorFinal() //metodo para calcular o valor final da venda
        {
            return (preço + (preço * lucro)) * imposto;
        }
    }
}

