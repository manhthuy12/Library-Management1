using DataAccess.Repository;
using BussinessObject;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        public MemberObject loginMember { get; set; }
        public bool isAdmin { get; set; }
        IMemberRepository memberRepository = new MemberRepository();

        BindingSource source;

        public frmMembers()
        {
            InitializeComponent();
        }
        private void frmMembers_Load(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            dgvMemberList.CellDoubleClick += DgvMemberList_CellDoubleClick!;
            isAdmin = loginMember!.Email.Equals("admin@fstore.com");
            if(!isAdmin )
            {
                btnAddNew.Enabled = false;
            }
        }
        private void DgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail()
            {
                Text = "Update Information",
                InsertOrUpdate = true,
                MemberInfo = GetMemberObject(),
                MemberRepository = memberRepository
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }
        private void LoadMemberList()
        {
            List<MemberObject> members = Enumerable.Empty<MemberObject>().ToList();
            if (isAdmin)
            {
                members = memberRepository.GetMembers().ToList();
            }
            else
            {
                members.Add(memberRepository.GetMemberByID(loginMember.MemberID));
            }
            try
            {
                //The bindingSource component is designed to simplyfy the process of binding controls to an underlying datasource
                source = new BindingSource();
                source.DataSource = members;

                txtMemberID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (members.Count() == 0)
                {
                    ClearText();
                    if(!isAdmin) {btnRemove.Enabled = false; }
                    
                }
                else
                {
                    btnRemove.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }

        }
        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }
        private MemberObject GetMemberObject()
        {
            MemberObject member = null!;
            try
            {
                member = new MemberObject()
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return member;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail()
            {
                Text = "Add new member",
                InsertOrUpdate = false,
                MemberInfo = loginMember,
                MemberRepository = memberRepository
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberRepository.RemoveMember(member.MemberID);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove a member");
            }
        }
    }


}
