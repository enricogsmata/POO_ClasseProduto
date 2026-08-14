using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_POO {
    public class Produto {

        #region atributos
        private string _descricao;
        private double _precoCusto; 
        private double _margemLucro; 
        #endregion

        #region construtores
        public Produto(string desc, double precoCusto, double margemLucro) {
            _descricao = desc;
            _precoCusto = precoCusto;
            _margemLucro = margemLucro;
        }
        #endregion

        #region métodos de negócio
        public double ValorVenda() {
            double valorVenda = _precoCusto * (1 + _margemLucro);
            return valorVenda;
        }

        public string NotaDeVenda() {
            double valorVenda = ValorVenda();
            return $"=== NOTA VENDA === \nProduto: {_descricao}\nPreço de Custo: {_precoCusto}\nMargem de Lucro: {_margemLucro}\nValor de Venda: {valorVenda}";
        }
        #endregion
    }
}
