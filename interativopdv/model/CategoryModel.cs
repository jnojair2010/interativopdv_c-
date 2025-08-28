using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interativopdv.model
{
    internal class CategoryModel
    { private int idCategory; 
      private string name;
      private int companyid;

      private List<SubCategoryModel> subcategory = new List<SubCategoryModel>();

      public int IdCategory { 
           get { return idCategory; }
           set { idCategory = value; }
      }    
      public string Name
      {
            get { return name; }
            set { name = value; }
      }
      public int CompanyId
      {
            get { return companyid;}
            set { companyid = value; }
      }
        public void insertSubCategory(SubCategoryModel subca)
        {
            subcategory.Add(subca);
        }
    }
}
