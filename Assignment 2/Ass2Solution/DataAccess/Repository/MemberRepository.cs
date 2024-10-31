using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public IEnumerable<MemberObject> GetMembers() => MemberDAO.Instance.GetMembers();
        public MemberObject GetMemberByID(int id) => MemberDAO.Instance.GetMemberByID(id);
        public void AddNewMember(MemberObject member) => MemberDAO.Instance.AddNewMember(member);
        public void RemoveMember(int memberID) => MemberDAO.Instance.RemoveMember(memberID);
        public void UpdateMember(MemberObject member) => MemberDAO.Instance.UpdateMember(member);
        public MemberObject Login(string email, string password) => MemberDAO.Instance.Login(email, password)!;
    }
}
