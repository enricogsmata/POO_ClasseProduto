using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_POO {
    public class Produto {

        #region atributos
        // TODO: declarar atributos

        #endregion

        #region construtores
        public Produto(string desc, double precoCusto, double margemLucro) {
            //TODO: lógica do construtor
        }
        #endregion

        #region métodos de negócio
        public double ValorVenda() {
            //TODO: calcular valor de venda de acordo com a regra do produto
            return 0;
        }

        public string NotaDeVenda() {
            //TODO: criar nota de venda formatada de acordo com a regra do produto
            return "";
        }
        #endregion
    }
}
