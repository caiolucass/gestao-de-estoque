using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaodeVendas
{
    class Bebida:Produto
    {
        public Bebida(string categoria ,int id, DateTime data, string nome, double preço, int quant,double lucro) : base(categoria,id,nome,preço,quant,lucro,data)
        {
            imposto = 0.50;
        }
    }
}
