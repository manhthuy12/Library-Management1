using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BussinessObject;
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        public frmMemberDetails()
        {
            InitializeComponent();
        }
        public IMemberRepository MemberRepository = new MemberRepository();
        public bool InsertOrUpdate { get; set; } //False: Insert, True Update
        public MemberObject Member { get; set; }
        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            txtID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtID.Text = Member.MemberID.ToString();
                txtEmail.Text = Member.Email;
                txtPassword.Text = Member.Password;
                txtMemberName.Text = Member.MemberName;
                txtCity.Text = Member.City;
                txtCountry.Text = Member.Country;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject
                {
                    MemberID = int.Parse(txtID.Text),
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    MemberName = txtMemberName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                };
                if (InsertOrUpdate == false)
                {
                    MemberRepository.AddMember(member);
                    MessageBox.Show("Member added successfully!", "Add new member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MemberRepository.UpdateMember(member);
                    MessageBox.Show("Member updated successfully!", "Update member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new member" : "Update a member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
