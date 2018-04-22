using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumFigPoliticos
{
    class Figurinha
    {
        private string nome;
        private int codigo;
        private string imagem;

        public string Nome { get => nome; set => nome = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Imagem { get => imagem; set => imagem = value; }
    }
}
