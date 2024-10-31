using BussinessObject;
using DataAccess;
using DataAccess.Repository;
namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public MemberObject loginMember { get; set; }
        IMemberRepository memberRepository { get; set; }
        bool isAdmin { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "Welcome [ " + loginMember.Email + " ]";
            isAdmin = loginMember!.Email.Equals("admin@fstore.com");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMembers frmMembers = new frmMembers
            {
                loginMember = loginMember,
            };
            frmMembers.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                frmProducts frmProducts = new frmProducts
                {
                    loginMember = loginMember,
                };
                frmProducts.Show();
            }
            else
            {
                MessageBox.Show("You are not Admin");
            }
        }

        private void orderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                frmOrders frmOrders = new frmOrders();
                frmOrders.Show();
            }
            else
            {
                MessageBox.Show("You are not Admin");
            }
            
        }
    }
}
