using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BussinessObject;

namespace DataAccess.Repository
{
    public class MemberRepository:IMemberRepository
    {
        public void AddMember(MemberObject member) => MemberDAO.Instance.AddMember(member);

        public void DeleteMember(int MemberID) => MemberDAO.Instance.Delete(MemberID);

        public List<MemberObject> GetMemberList()
        {
            return MemberDAO.Instance.GetMemberList();
        }
        public List<MemberObject> SearchMember(int id)
        {
            return MemberDAO.Instance.SearchMemberByID(id);
        }

        public List<MemberObject> SearchMember(string name)
        {
            return MemberDAO.Instance.SearchMemberByName(name);
        }
        public MemberObject Login(string Email, string Password)
        {
            return MemberDAO.Instance.Login(Email, Password);
        }



        public void UpdateMember(MemberObject member) => MemberDAO.Instance.UpdateMember(member);

        public List<MemberObject> SearchMemberByCountry(string country, List<MemberObject> searchList)
        {
            return MemberDAO.Instance.SearchMemberByCountry(country, searchList);
        }

        public List<MemberObject> SearchMemberByCity(string country, string city, List<MemberObject> searchList)
        {
            return MemberDAO.Instance.SearchMemberByCity(country, city, searchList);
        }
    }
}
