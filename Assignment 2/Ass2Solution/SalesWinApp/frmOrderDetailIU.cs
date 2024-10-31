using DataAccess.Repository;
using BussinessObject;

namespace SalesWinApp
{
    public partial class frmOrderDetailIU : Form
    {
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public bool InsertOrUpdate { get; set; }
        public OrderDetailObject orderDetailInfo { get; set; }
        public frmOrderDetailIU()
        {
            InitializeComponent();
        }

        private void OrderDetailIU_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)//Update Mode
            {
                txtOrderID.Text = orderDetailInfo.OrderID.ToString();
                txtProductID.Text = orderDetailInfo.ProductID.ToString();
                txtUnitPrice.Text = orderDetailInfo.UnitPrice.ToString();
                txtQuantity.Text = orderDetailInfo.Quantity.ToString();
                txtDiscount.Text = orderDetailInfo.Discount.ToString();
            }
            else
            {
                txtOrderID.Text = orderDetailInfo.OrderID.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var orderDetail = new OrderDetailObject
                {
                    OrderID = int.Parse(txtOrderID.Text),
                    ProductID = int.Parse(txtProductID.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount = float.Parse(txtDiscount.Text)
                };
                if (InsertOrUpdate == false)
                {
                    orderDetailRepository.AddOrderDetails(orderDetail);
                    MessageBox.Show("Successfully!");

                }
                else
                {
                    orderDetailRepository.UpdateOrderDetails(orderDetail);
                    MessageBox.Show("Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new order detail" : "Update a order detail");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
