using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRelatorio
{
    class Compra
    {
        private int codigo;
        private string descricao;
        private string genero;
        private int estoque;
        private double valor_unitario;

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public int Estoque
        {
            get
            {
                return estoque;
            }

            set
            {
                estoque = value;
            }
        }

        public double Valor_unitario
        {
            get
            {
                return valor_unitario;
            }

            set
            {
                valor_unitario = value;
            }
        }

        public string mostraDadosCadastrados()
        {
            return " Código: " + codigo + "\n Descrição: " + descricao + "\n Gênero: " + genero + "\n Estoque: " + estoque + "\n Valor Unitário: " + Valor_unitario;
        }
    }
}
