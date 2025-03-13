using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }

        public Produto (string nome, decimal preco, string descricao)
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
        }
        public string ExibirDetalhes()
        {

        return $"Nome: {Nome}\n Preco: {Preco}\n Descricao: {Descricao}" ; 
        
        }
    }
}
