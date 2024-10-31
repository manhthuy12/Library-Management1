using DataAccess.Repository;
using BussinessObject;

namespace SalesWinApp
{
    public partial class frmMemberDetail : Form
    {
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }//False: Insert, True: Update
        public MemberObject MemberInfo { get; set; }
        public frmMemberDetail()
        {
            InitializeComponent();
        }

        private void MemberDetail_Load(object sender, EventArgs e)
        {
            txtMemberID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)//Update Mode
            {
                txtMemberID.Text = MemberInfo.MemberID.ToString();
                txtEmail.Text = MemberInfo.Email;
                txtPassword.Text = MemberInfo.Password;
                txtCompanyName.Text = MemberInfo.CompanyName;
                txtCity.Text = MemberInfo.City;
                txtCountry.Text = MemberInfo.Country;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
                if (InsertOrUpdate == false)
                {
                    MemberRepository.AddNewMember(member);
                    MessageBox.Show("Successfully!");

                }
                else
                {
                    MemberRepository.UpdateMember(member);
                    MessageBox.Show("Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new member" : "Update a member");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
