using interativopdv.server;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interativopdv.view
{
    public partial class SelectOwner : Form
    {
        ServiceOwner servOwner = new ServiceOwner();
        public SelectOwner()
        {
            InitializeComponent();
            listViewOwner.View = View.Details;

            listViewOwner.FullRowSelect = true;


            listViewOwner.GridLines = true;

            listViewOwner.LabelEdit = true;

            listViewOwner.Columns.Add("Nome", 433, HorizontalAlignment.Left);

            

            if (servOwner.geOwnerOfServer().IdOwner > 0)
            {
                addNameSelect($" {servOwner.geOwnerOfServer().FirstName} {servOwner.geOwnerOfServer().LastName} ");
            }
            else
            {
               // addNameSelect(servOwner.getOwner().FirstName());
            }
        }
        private void addNameSelect(string name)
        {
            ListViewItem lvi = new ListViewItem(name);
            listViewOwner.Items.Add(lvi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            for(int i=0;i< listViewOwner.SelectedItems.Count; i++)
            {
                MessageBox.Show($"Selecionado com sucesso");

                //só retorna a messangem de sucesso por que não precisa reatribuir um Owner no service Owner ja atribuido

                closeForm();
            }
        }
        public void closeForm()
        {
            this.Close();
        }
    }
}
