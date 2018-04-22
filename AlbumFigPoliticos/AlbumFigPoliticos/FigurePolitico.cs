using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumFigPoliticos
{
    class FigurePolitico:Figurinha
    {
        private string partido;
        private int chapa;
                    //Deputado Federal: 4 dígitos + Confirma.
                    //Seguido por Senador: 3 dígitos + Confirma.
                    //Governador: 2 dígitos + Confirma
                    //Presidente: 2 dígitos + Confirma
        private string cargo; 
    }
}
