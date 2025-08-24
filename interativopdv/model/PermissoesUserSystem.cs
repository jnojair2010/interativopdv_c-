using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interativopdv.model
{
    internal class PermissoesUserSystem
    {   
        // inserir preço de compra
        private bool enterComPrice = false;
        private bool inputPricePurchase = false;
        private bool menuEmpresa = false;
        private bool menuColaborador = false;
        private bool menuFornecedor = false;
        private bool menuProdutos = false;
        private bool menuCaixa = false;


        public bool EnterComPrice
        {
            get { return enterComPrice; }
            set { enterComPrice = value; }
        }

        public bool InputPricePurchase
        {
            get { return inputPricePurchase; }
            set { inputPricePurchase = value; }
        }
        public bool MenuEmpresa
        {
            get { return menuEmpresa; }
            set { menuEmpresa = value; }
        }

        public bool MenuColaborador
        {
            get { return menuColaborador; }
            set { menuColaborador = value;  }
        }

        public bool MenuFornecedor
        {
            get { return menuFornecedor; }
            set { menuFornecedor = value; }
        }
        public bool MenuProdutos
        {
            get { return menuProdutos; }
            set { menuProdutos = value; }
        }
        public bool MenuCaixa
        {
            get { return menuCaixa; }
            set { menuCaixa = value; }
        }


        public void setAtendente()
        {
            MenuCaixa = true;
            MenuProdutos = true;
        }
        public void setAdministrador()
        {
            MenuEmpresa = true;
            EnterComPrice = true;
            InputPricePurchase = true;
            MenuColaborador = true;
            MenuFornecedor = true;
            MenuProdutos = true;
            MenuCaixa = true;
        }
        public void serManager()
        {

            MenuEmpresa = false;
            EnterComPrice = true;
            InputPricePurchase = true;
            MenuColaborador = true;
            MenuFornecedor = true;
            MenuProdutos = true;
            MenuCaixa = true;
        }
        public void setDev()
        {
            MenuEmpresa = true;
            EnterComPrice = true;
            InputPricePurchase = true;
            MenuColaborador = true;
            MenuFornecedor = true;
            MenuProdutos = true;
            MenuCaixa = true;
        }


    }

   
}
