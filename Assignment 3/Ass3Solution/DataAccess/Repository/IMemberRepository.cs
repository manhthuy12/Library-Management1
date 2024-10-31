using BusinessObject.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetList();
        Member GetMemberById(int id);
        void InsertMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int id);
        bool Login(string email, string pwd);
        bool CheckEmail(string email);
        Member GetMemberByEmail(string email);
    }
}
