using BussinessObject;
using DataAccess.Repository;
using DataAccess;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            MemberObject loginMember = memberRepository.Login(Email, Password);
            if (loginMember != null)
            {
                MessageBox.Show("Login successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string memberName = loginMember.Email!;
                frmMain frmMain = new frmMain
                {
                    loginMember = loginMember,
                };
                frmMain.Closed += (s, args) => this.Close();
                this.Hide();
                frmMain.Show();
            }
            else
            {
                if (MessageBox.Show("Login failed!!", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
