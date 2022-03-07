using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class dgwProducts : Form
    {
        public dgwProducts()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();

        private void dgwProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmuntUpdate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmunt.Text)
            });

            LoadProducts();

        }

        private void LoadProducts()
        {
            dataGridView1.DataSource = _productDal.GetAll();
        }

        private void SearchProducts(string key)
        {
            //  var resualt = _productDal.GetAll().Where(p=>p.Name.Contains(key)).ToList();
            dataGridView1.DataSource = _productDal.GetByName(key);
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmuntUpdate.Text)
            });
            LoadProducts();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }

        private void tbxGetById_Click(object sender, EventArgs e)
        {
            _productDal.GetById(1);
        }
    }
}
