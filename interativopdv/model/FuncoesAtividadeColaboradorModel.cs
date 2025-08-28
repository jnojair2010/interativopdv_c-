using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interativopdv.model
{
    internal class FuncoesAtividadeColaboradorModel
    {

        private int idFuncoes;
        private string name;

        public int IdFuncoes { 
            get { return idFuncoes; }
            set { idFuncoes = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
