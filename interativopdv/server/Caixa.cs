using interativopdv.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interativopdv.server
{
    internal class Caixa
    {
        private int idCaixa;
        private bool isOpen;
        private DateTime openDataTime = new DateTime();
        private DateTime closeDataTime = new DateTime();
        private int employeeId;
        private int company_id;


        private List<ProductoModel> produtos = new List<ProductoModel>();

        public int IdCaixa
        {
            get { return idCaixa; }
            set { idCaixa = value; }
        }
        public bool IsOpen
        {
            get { return isOpen; }
            set { isOpen = value; }
        }
        public DateTime OpenDataTime
        {   get { return openDataTime; }
            set { openDataTime = value; }
        }
        public DateTime CloseDataTime
        {
            get { return closeDataTime; }
            set { closeDataTime = value; }
        }
        public int EmployeeId
        {   get { return employeeId; }
            set { employeeId = value; } 
        }
        public int CompanyId
        {
            get { return company_id; }
            set { company_id = value; }
        }
        public void addProdutoCar(ProductoModel prod)
        {
            produtos.Add(prod);
        }

        public void deleteProdutoCar(ProductoModel prod)
        {
            int count = produtos.Count;

            for (int i = 0; i < count; i++)
            {
                if (produtos[i].id == prod.id)
                {
                    produtos.RemoveAt(i);
                }
               
            }
        }
        public List<ProductoModel> getListaProducto()
        {
            return produtos;
        }


    }
}
