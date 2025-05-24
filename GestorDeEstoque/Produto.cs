using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstoque
{
    [Serializable]
    abstract class Produto //Serve como pai, mas não é possivel criar instâncias dela
    {
        public string nome;
        public float preco;
    }
}
