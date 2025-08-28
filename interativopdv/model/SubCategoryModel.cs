using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interativopdv.model
{
    internal class SubCategoryModel
    {
        private int idCategory;
        private string name;
        private int cantegoryId;

        public int IdCategory
        {
            get { return idCategory; }
            set { idCategory = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int CantegoryId
        { get { return cantegoryId; }
          set { cantegoryId = value; }
        }

    }
}
