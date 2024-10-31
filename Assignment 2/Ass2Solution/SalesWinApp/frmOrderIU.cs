using DataAccess.Repository;
using BussinessObject;
using System.Reflection;

namespace SalesWinApp
{
    public partial class frmOrderIU : Form
    {
        public IOrderRepository orderRepository = new OrderRepository();
        public bool InsertOrUpdate { get; set; }
        public OrderObject orderInfo { get; set; }
        public frmOrderIU()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOrderIU_Load(object sender, EventArgs e)
        {
            txtMemberID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)//Update Mode
            {
                txtOrderID.Text = orderInfo.OrderID.ToString();
                txtMemberID.Text = orderInfo.MemberID.ToString();
                dtpOrderDate.Text = orderInfo.OrderDate.ToString();
                dtpRequiredDate.Text = orderInfo.RequiredDate.ToString();
                dtpShippedDate.Text = orderInfo.ShippedDate.ToString();
                txtFreight.Text = orderInfo.Freight.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var order = new OrderObject
                {
                    OrderID = int.Parse(txtOrderID.Text),
                    MemberID = int.Parse(txtMemberID.Text),
                    OrderDate = dtpOrderDate.Value,
                    RequiredDate = dtpRequiredDate.Value,
                    ShippedDate = dtpShippedDate.Value,
                    Freight = decimal.Parse(txtFreight.Text),
                };
                if (InsertOrUpdate == false)
                {
                    orderRepository.CreateOrder(order);
                    MessageBox.Show("Successfully!");

                }
                else
                {
                    orderRepository.UpdateOrder(order);
                    MessageBox.Show("Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new order" : "Update a order");
            }
        }
    }
}
