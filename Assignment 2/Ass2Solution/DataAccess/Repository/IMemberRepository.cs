using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject;
namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetMembers();
        MemberObject GetMemberByID(int id);
        void AddNewMember(MemberObject member);
        void RemoveMember(int memberID);
        void UpdateMember(MemberObject member);
        MemberObject Login(string username, string password);
    }
}
