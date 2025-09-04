using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interativopdv.model
{
    internal class OwnerModel
    {
        private int idOwner;
        private string firstName;
        private string lastName;
        private string cpf;


        public int IdOwner
        {   get { return idOwner; }
            set { idOwner = value; }
        }
        public string FirstName
        {   get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Cpf
        {   get { return cpf; }
            set { cpf = value; }
        }
    }
}
