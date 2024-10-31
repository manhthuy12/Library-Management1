using DataAccess.Repository;
using BussinessObject;

namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();

        BindingSource source;
        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnDeleteR.Enabled = false;
            dgvOrder.CellDoubleClick += DgvOrder_CellDoubleClick!;
            dgvOrderDetail.CellDoubleClick += DgvOrderDetail_CellDoubleClick!;
        }
        private void DgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderIU frmOrderIU = new frmOrderIU()
            {
                Text = "Update Order",
                InsertOrUpdate = true,
                orderInfo = GetOrderObject(),
            };
            if (frmOrderIU.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList();
                source.Position = source.Count - 1;
            }
        }
        private void DgvOrderDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetailIU frmOrderDetailIU = new frmOrderDetailIU()
            {
                Text = "Update Order detail",
                InsertOrUpdate = true,
                orderDetailInfo = orderDetailRepository.GetOrderDetailByOIDAndPID(int.Parse(txtOrderIDRight.Text), int.Parse(txtProductID.Text))
            };
            if (frmOrderDetailIU.ShowDialog() == DialogResult.OK)
            {
                LoadOrderDetail(GetOrderObject());
                source.Position = source.Count - 1;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadOrderList();
        }
        private void LoadOrderList()
        {
            var orders = orderRepository.GetOrders();
            try
            {
                //The bindingSource component is designed to simplyfy the process of binding controls to an underlying datasource
                source = new BindingSource();
                source.DataSource = orders;

                txtOrderIDLeft.DataBindings.Clear();
                txtMemberID.DataBindings.Clear();
                txtFreight.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();

                txtOrderIDLeft.DataBindings.Add("Text", source, "OrderID");
                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtFreight.DataBindings.Add("Text", source, "Freight");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");

                dgvOrder.DataSource = null;
                dgvOrder.DataSource = source;
                if (orders.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order list");
            }
        }
        private void ClearText()
        {
            txtOrderIDLeft.Text = string.Empty;
            txtMemberID.Text = string.Empty;
            txtFreight.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            txtRequiredDate.Text = string.Empty;
            txtShippedDate.Text = string.Empty;
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            LoadOrderDetail(GetOrderObject());
        }
        private void LoadOrderDetail(OrderObject order)
        {
            var orderDetails = orderDetailRepository.GetOrderDetailByOrderID(order.OrderID);
            try
            {
                //The bindingSource component is designed to simplyfy the process of binding controls to an underlying datasource
                source = new BindingSource();
                source.DataSource = orderDetails;

                txtOrderIDRight.DataBindings.Clear();
                txtProductID.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtDiscount.DataBindings.Clear();

                txtOrderIDRight.DataBindings.Add("Text", source, "OrderID");
                txtProductID.DataBindings.Add("Text", source, "ProductID");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtDiscount.DataBindings.Add("Text", source, "Discount");

                dgvOrderDetail.DataSource = null;
                dgvOrderDetail.DataSource = source;
                if (orderDetails.Count() == 0)
                {
                    ClearText();
                    btnDeleteR.Enabled = false;
                }
                else
                {
                    btnDeleteR.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order details list");
            }
        }
        private OrderObject GetOrderObject()
        {
            OrderObject order = null!;
            try
            {
                order = new OrderObject()
                {
                    OrderID = int.Parse(txtOrderIDLeft.Text),
                    MemberID = int.Parse(txtMemberID.Text),
                    Freight = decimal.Parse(txtFreight.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order .");
            }
            return order;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This action include delete all details about this Order", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả của MessageBox
            if (result == DialogResult.Yes)
            {
                try
                {
                    orderDetailRepository.DeleteOrderDetailsByOrderID(GetOrderObject().OrderID);
                    orderRepository.DeleteOrder(GetOrderObject().OrderID);
                    LoadOrderList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Remove a order");
                }
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmOrderIU frmOrderIU = new frmOrderIU()
            {
                Text = "Add new order",
                InsertOrUpdate = false,
            };
            if (frmOrderIU.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList();
                source.Position = source.Count - 1;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmOrderDetailIU frmOrderIU = new frmOrderDetailIU()
            {
                Text = "New order detail",
                InsertOrUpdate = false,
                orderDetailInfo = orderDetailRepository.GetOrderDetailByOIDAndPID(int.Parse(txtOrderIDRight.Text), int.Parse(txtProductID.Text))
            };
            if (frmOrderIU.ShowDialog() == DialogResult.OK)
            {
                LoadOrderDetail(GetOrderObject());
                source.Position = source.Count - 1;
            }
        }

        private void btnDeleteR_Click(object sender, EventArgs e)
        {
            try
            {
                orderDetailRepository.DeleteOrderDetailsByOIDAndPID(int.Parse(txtOrderIDRight.Text), int.Parse(txtProductID.Text));
                LoadOrderDetail(GetOrderObject());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove a order detail");
            }
        }
    }
}
