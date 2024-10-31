using BussinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProductDetail : Form
    {
        public IProductRepository ProductRepository { get; set; }
        public bool InsertOrUpdate { get; set; }//False: Insert, True: Update
        public ProductObject ProductInfo { get; set; }

        public frmProductDetail()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {
            txtProductID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)//Update Mode
            {
                txtProductID.Text = ProductInfo.ProductID.ToString();
                txtCategoryID.Text = ProductInfo.CategoryID.ToString();
                txtProductName.Text = ProductInfo.ProductName;
                txtWeight.Text = ProductInfo.Weight;
                txtUnitPrice.Text = ProductInfo.UnitPrice.ToString();
                txtUnitInStock.Text = ProductInfo.UnitInStock.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new ProductObject
                {
                    ProductID = int.Parse(txtProductID.Text),
                    CategoryID = int.Parse(txtCategoryID.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = int.Parse(txtUnitPrice.Text),
                    UnitInStock = int.Parse(txtUnitInStock.Text)
                };
                if (InsertOrUpdate == false)
                {
                    ProductRepository.AddNewProduct(product);
                    MessageBox.Show("Successfully!");
                }
                else
                {
                    ProductRepository.UpdateProduct(product);
                    MessageBox.Show("Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new product" : "Update a product");
            }
        }
    }
}
