using BussinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        public MemberObject loginMember { get; set; }
        IMemberRepository memberRepository = new MemberRepository();

        BindingSource source;
        BindingSource citySource;
        BindingSource countrySource;

        bool search = false;
        bool filter = false;
        List<MemberObject> dataSource;
        List<MemberObject> searchResult;
        List<MemberObject> filterResult;

        List<string> countryList;
        Dictionary<string, List<string>> cityDictionary;
        public frmMemberManagement()
        {
            InitializeComponent();
        }
        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvMemberList.CellDoubleClick += DgvMemberList_CellDoubleClick!;
            LoadCountryFilterCbo();
            cboSort.SelectedIndex = 0;
        }
        private void LoadCountryFilterCbo()
        {
            cboFilterCountry.Items.Clear();
            var uniqueCountries = memberRepository.GetMemberList().Select(member => member.Country).Distinct();
            cboFilterCountry.Items.Add("All");
            cboFilterCountry.Items.AddRange(uniqueCountries.ToArray()!);
            cboFilterCountry.SelectedIndex = 0;
        }
        private void DgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails()
            {
                Text = "Update member",
                InsertOrUpdate = true,
                Member = GetMemberObject(),
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadFullMember();
                source.Position = source.Count - 1;
            }
        }
        private MemberObject GetMemberObject()
        {
            MemberObject member = null;
            try
            {
                member = new MemberObject()
                {
                    MemberID = int.Parse(txtID.Text),
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    MemberName = txtMemberName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return member;
        }
        private void LoadFullMember()
        {
            var members = memberRepository.GetMemberList();
            LoadMemberList(members);
        }
        private void LoadMemberList(List<MemberObject> members)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "MemberID");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (members.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void ClearText()
        {
            txtID.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadFullMember();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails()
            {
                Text = "Add New Member",
                Member = loginMember,
                MemberRepository = memberRepository,
                InsertOrUpdate = false,
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadFullMember();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberID);
                LoadFullMember();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<MemberObject> members = null!;
            try
            {
                if (cboSearch.Text.Equals("ID"))
                {
                    int searchId;
                    if (int.TryParse(txtSearch.Text, out searchId))
                    {
                        members = memberRepository.SearchMember(searchId);
                    }
                    else
                    {
                        MessageBox.Show("Invalid input for ID. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (cboSearch.Text.Equals("Name"))
                {
                    members = memberRepository.SearchMember(txtSearch.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (members != null)
            {
                LoadMemberList(members);
            }
            else
            {
                MessageBox.Show("No members found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFilterCountry.SelectedIndex == 0)
            {
                cboFilterCity.Items.Clear();
                cboFilterCity.Enabled = false;
            }
            else
            {
                cboFilterCity.Enabled = true;
                LoadCityFilterCbo(cboFilterCountry.Text);
            }
        }
        private void LoadCityFilterCbo(string country)
        {
            cboFilterCity.Items.Clear();

            var citiesInCountryC = memberRepository.GetMemberList()
                                    .Where(member => member.Country == country)
                                    .Select(member => member.City)
                                    .Distinct();

            cboFilterCity.Items.Add("All");
            cboFilterCity.Items.AddRange(citiesInCountryC.ToArray()!);
            cboFilterCity.SelectedIndex = 0;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cboFilterCountry.SelectedIndex == 0)
            {
                LoadFullMember();
            }
            else
            {
                List<MemberObject> members;
                if (cboFilterCity.SelectedIndex == 0)
                {
                    members = memberRepository.SearchMemberByCountry(cboFilterCountry.Text, memberRepository.GetMemberList());
                    LoadMemberList(members);
                }
                else
                {
                    members = memberRepository.SearchMemberByCity(cboFilterCountry.Text, cboFilterCity.Text, memberRepository.GetMemberList());
                    LoadMemberList(members);
                }
            }

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            BindingSource source = (BindingSource)dgvMemberList.DataSource;
            List<MemberObject> members = (List<MemberObject>)source.DataSource;
            List<MemberObject> sortedMembers = new List<MemberObject>();
            switch (cboSort.SelectedIndex)
            {
                case 0:
                    sortedMembers = members.OrderBy(member => member.MemberID).ToList();
                    LoadMemberList(sortedMembers);
                    break;
                case 1:
                    sortedMembers = members.OrderByDescending(member => member.MemberID).ToList();
                    LoadMemberList(sortedMembers);
                    break;
                case 2:
                    sortedMembers = members.OrderBy(member => member.MemberName).ToList();
                    LoadMemberList(sortedMembers);
                    break;
                case 3:
                    sortedMembers = members.OrderByDescending(member => member.MemberName).ToList();
                    LoadMemberList(sortedMembers);
                    break;
            }
        }
    }
}
