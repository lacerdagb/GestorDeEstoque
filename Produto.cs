using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstoque
{
    [System.Serializable]
    internal abstract class Produto
    {
        public string nome;
        public double preco;
    }
}
