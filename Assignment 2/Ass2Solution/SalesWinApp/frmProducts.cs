using DataAccess.Repository;
using BussinessObject;

namespace SalesWinApp
{
    public partial class frmProducts : Form
    {
        IProductRepository ProductRepository = new ProductRepository();
        public MemberObject loginMember { get; set; }
        bool isAdmin { get; set; }
        BindingSource source { get; set; }
        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            dgvProductList.CellDoubleClick += DgvProductList_CellDoubleClick!;
            isAdmin = loginMember!.Email.Equals("admin@fstore.com");

        }

        private void DgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductDetail frmProductDetail = new frmProductDetail()
            {
                Text = "Update Product",
                InsertOrUpdate = true,
                ProductInfo = GetProductObject(),
                ProductRepository = ProductRepository
            };
            if (frmProductDetail.ShowDialog() == DialogResult.OK)
            {
                LoadProductList(ProductRepository.GetProducts().ToList());
                source.Position = source.Count - 1;
            }
        }
        private void LoadProductList(List<ProductObject> products)
        {
            try
            {
                //The bindingSource component is designed to simplyfy the process of binding controls to an underlying datasource
                source = new BindingSource();
                source.DataSource = products;

                txtProductID.DataBindings.Clear();
                txtCategoryID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitInStock.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", source, "ProductID");
                txtCategoryID.DataBindings.Add("Text", source, "CategoryID");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitInStock.DataBindings.Add("Text", source, "UnitInStock");

                dgvProductList.DataSource = null;
                dgvProductList.DataSource = source;
                if (products.Count() == 0 || !isAdmin)
                {
                    ClearText();
                    btnRemove.Enabled = false;
                }
                else
                {
                    btnRemove.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product a list");
            }

        }
        private void ClearText()
        {
            txtProductID.Text = string.Empty;
            txtCategoryID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtSearch.Text = string.Empty;
            txtUnitInStock.Text = string.Empty;
        }
        private ProductObject GetProductObject()
        {
            ProductObject product = null!;
            try
            {
                product = new ProductObject()
                {
                    ProductID = int.Parse(txtProductID.Text),
                    CategoryID = int.Parse(txtCategoryID.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitInStock = int.Parse(txtUnitInStock.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Product Object");
            }
            return product;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProductList(ProductRepository.GetProducts().ToList());
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmProductDetail frmProductDetail = new frmProductDetail()
            {
                Text = "Add new member",
                InsertOrUpdate = false,
                ProductInfo = GetProductObject(),
                ProductRepository = ProductRepository
            };
            if (frmProductDetail.ShowDialog() == DialogResult.OK)
            {
                LoadProductList(ProductRepository.GetProducts().ToList());
                source.Position = source.Count - 1;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductObject();
                ProductRepository.RemoveProduct(product.ProductID);
                LoadProductList(ProductRepository.GetProducts().ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove a product");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ProductObject> searchList = new List<ProductObject>();
            switch (cboSearch.SelectedIndex)
            {
                case 0:
                    int id = int.Parse(txtSearch.Text);
                    searchList.Add(ProductRepository.GetProductByID(id));
                    break;
                case 1:
                    string name = txtSearch.Text;
                    searchList = ProductRepository.GetProductByName(name).ToList();
                    break;
                case 2:
                    decimal unitPrice = decimal.Parse(txtSearch.Text);
                    searchList = ProductRepository.GetProductByUnitPrice(unitPrice).ToList();
                    break;
                case 3:
                    int unitInStock = int.Parse(txtSearch.Text);
                    searchList = ProductRepository.GetProductByUnitInStock(unitInStock).ToList();
                    break;
            }
            LoadProductList(searchList);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
