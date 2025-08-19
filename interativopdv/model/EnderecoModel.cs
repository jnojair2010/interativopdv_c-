using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interativopdv.model
{
    internal class EnderecoModel
    {
        private string logradrouro;
        private string numero;
        private string uf;
        private string bairro;
        private string cidade;
        private string comlemento;
        private string cep;

        public string  Logradouro
        {
            get { return logradrouro; }
            set { logradrouro = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Complemento
        {   
            get { return comlemento; }
            set { comlemento = value; }
        }
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
 
    }
}
